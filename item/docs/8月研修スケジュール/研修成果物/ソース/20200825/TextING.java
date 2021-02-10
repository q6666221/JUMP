package Text0426;

public class TextING {
    public static void main(String[]args){
        char[] charr=new char[]{'(','╯','‵','□','′',')','╯','炸','弹','！','•','•','•','*','～','●'};
        new Thread(){
            @Override
            public void run() {
                try {
                    for(int i=0;i<charr.length;i++){
                        if (i>=7){
                            sleep(500);
                            System.out.print(charr[i]);
                            continue;
                        }
                        sleep(100);
                        System.out.print(charr[i]);
                    }
                } catch (Exception e) {
                    e.printStackTrace();
                }
            }
        }.start();
        System.out.println("\n");
        
    }
}
