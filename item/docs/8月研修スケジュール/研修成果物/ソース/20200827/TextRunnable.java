package Text0424;


public class TextRunnable {
    public static void main(String[]args){
//        MyRunnalbe runnalbe=new MyRunnalbe();
//        Thread th=new Thread(runnalbe);
//        th.start();
//        Thread th2=new Thread(runnalbe);
//        th2.start();
        new Thread("线程1"){
            @Override
            public void run() {
                for (char i ='a' ; i <='z' ; i++) {
                    try {
                        sleep(1500);
                    }catch (InterruptedException e){
                        e.printStackTrace();
                    }
                    System.out.println(currentThread().getName()+i);
                }
            }
        }.start();

        new Thread(){
            @Override
            public void run() {
                for (int i = 0; i < 10; i++) {
                    try {
                        Thread.sleep(1500);
                    }catch (InterruptedException e){
                        e.printStackTrace();
                    }

                    System.out.println(i);
                }
            }
        }.start();



    }


}