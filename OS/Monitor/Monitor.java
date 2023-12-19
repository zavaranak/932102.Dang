class Monitor {
    private boolean ready = false;

    private int[] buffer;

    private int in = 0, out = 0;

    Monitor(int size)
    {
        buffer = new int[size];
    }

    public synchronized void produce(int c) {
        if (ready) {
            return;
        }

        System.out.println("Сообщение из поставщика " + c);

        buffer[in] = c;
        //in = (in + 1) % buffer.length;
        in = (in +1);

        ready = true;

        notify();

        try {
            Thread.sleep(1000);
        } catch (InterruptedException e) {
            Thread.currentThread().interrupt();
        }
    }
    public synchronized void consume() {
        while (!ready) {
            try {
                wait();
            } catch (InterruptedException e) {
            }
        }

        int c = buffer[out];
        out = (out + 1);
        //out = (out + 1) % buffer.length;

        System.out.println("Сообщение к потребителю " + c);

        ready = false;
    }
}