public class Main {
    public static void main(String[] args) {
        Monitor monitor = new Monitor(10);

        Thread producerThread = new Thread(new Producer(monitor));
        Thread consumerThread = new Thread(new Consumer(monitor));

        producerThread.start();
        consumerThread.start();
    }
}