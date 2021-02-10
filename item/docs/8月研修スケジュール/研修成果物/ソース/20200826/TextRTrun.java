package Text0424;

public class TextRTrun {
    public static void main(String[]args){
        Rabbit r=new Rabbit();
        Tortoise t=new Tortoise();

        Thread th=new Thread(t);

        r.start();
        th.start();
//        new Thread(){
//            @Override
//            public void run() {
//                for (int i = 0; i < 100; i++) {
//                    System.out.println("："+i+"米");
//                }
//            }
//        }.start();
    }
}
