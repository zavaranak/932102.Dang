#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <signal.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <errno.h>

#define PORT 3000
#define BACKLOG 5

volatile sig_atomic_t  wasSigHup = 0;

void sigHupHandler(int sigNumber) {
     wasSigHup = 1;
}

int main() {
    int serverFD;                               //sever Socket
    int incomingSocketFD = 0;                   //client Socket
    struct sockaddr_in socketAddress;           //internet adresss, port
    int addressLength = sizeof(socketAddress);  //used for request connection
    fd_set fds;
    struct sigaction sa;
    sigset_t blockedMask, origMask;
    char buffer[1024] = { 0 };
    int readBytes;
    int maxFd;
    int signalOrConnectionCount = 0;

    // Socket creating socket(domain,type,protocol)
    if ((serverFD = socket(AF_INET, SOCK_STREAM, 0)) == 0) {
        perror("create error");
        exit(EXIT_FAILURE);
    }

    // Setting socket address parameters
    socketAddress.sin_family = AF_INET;         //IPV4
    socketAddress.sin_addr.s_addr = INADDR_ANY; //Adress
    socketAddress.sin_port = htons(PORT);       //Port

    // Socket binding to the address
    //  bind(int sock, struct sock address, socket_length_adress)
    if (bind(serverFD, (struct sockaddr*)&socketAddress, sizeof(socketAddress)) < 0) {
        perror("bind error");
        exit(EXIT_FAILURE);
    }

    // Started socket listenig
    // listen(serverFD, BACKLOG)
    if (listen(serverFD, BACKLOG) < 0) {
        perror("listen error");
        exit(EXIT_FAILURE);
    }

    printf("Server started on port %d \n", PORT);

    // Signal handler registration
    sigaction(SIGHUP, NULL, &sa);
    sa.sa_handler = sigHupHandler;
    sa.sa_flags |= SA_RESTART;
    sigaction(SIGHUP, &sa, NULL);

    // Setting up signal blocking
    sigemptyset(&blockedMask);
    sigemptyset(&origMask);
    sigaddset(&blockedMask, SIGHUP);
    sigprocmask(SIG_BLOCK, &blockedMask, &origMask);
   
    while (signalOrConnectionCount < 3) {
        FD_ZERO(&fds); 
        FD_SET(serverFD, &fds); 
        
        if (incomingSocketFD > 0) { 
            FD_SET(incomingSocketFD, &fds); 
        } 
        
        maxFd = (incomingSocketFD > serverFD) ? incomingSocketFD : serverFD; 
 
        if (pselect(maxFd + 1, &fds, NULL, NULL, NULL, &origMask) < 0 && errno != EINTR) { 
            perror("pselect error"); 
            exit(EXIT_FAILURE); 
        }

        // Receiving SIGHUP signal check
        if ( wasSigHup) {
            printf("SIGHUP received.\n");
             wasSigHup = 0;
            signalOrConnectionCount++;
            continue;
        }
    
        // Reading incoming bytes
        if (incomingSocketFD > 0 && FD_ISSET(incomingSocketFD, &fds)) { 
            readBytes = read(incomingSocketFD, buffer, 1024);

            if (readBytes > 0) { 
                printf("Received data: %d bytes\n", readBytes); 
            } else {
                if (readBytes == 0) {
                    close(incomingSocketFD); 
                    incomingSocketFD = 0; 
                } else { 
                    perror("read error"); 
                } 
                signalOrConnectionCount++;   
            } 
            continue;
        }
        
        // Check of incoming connections
        if (FD_ISSET(serverFD, &fds)) {
            if ((incomingSocketFD = accept(serverFD, (struct sockaddr*)&socketAddress, (socklen_t*)&addressLength)) < 0) {
                perror("accept error");
                exit(EXIT_FAILURE);
            }

            printf("New connection.\n");
        }
    }

    close(serverFD);

    return 0;
}
