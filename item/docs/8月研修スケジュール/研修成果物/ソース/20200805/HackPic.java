package HackSystem;

public class HackPic {

    public void HTTPactPic(){
        String str="==== = =====  ====== ======\n"+
                   "=====  === =====   ==== ===\n"+
                   "  ==== ========== ===  ====\n"+
                   "===== === ========     ====\n"+
                   "=== =====  ======== =======\n"+
                   "==== =======  ========= ===\n"+
                   "==   ==== ====== ===== ====\n"+
                   "===== ===== =======    === \n"+
                   "=======   =======   =======\n"+
                   "=== === ======   =====  ===\n"+
                   "== ===== ===== ====== == ==\n"+
                   "== ====   ===== = ====   ==\n"+
                   "====== ===== ==== ====== ==\n";
        try {
            System.out.println("......");
            Thread.sleep(70);
            System.out.println("HTTPWebServer......");
            Thread.sleep(70);
            char[] charr= str.toCharArray();
            for (int i = 0; i < charr.length; i++) {
                Thread.sleep(50);
                System.out.print(charr[i]);
            }
            System.out.println("HTTP WebServer");
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }

    public void FTPactPic(){
        String str="010101010101010101011110000000101\n"+
                   "000011110100101010100101010100101\n"+
                   "101010101010000101010101010101010\n"+
                   "010110101010101010101010101010010\n"+
                   "010101010101010101010100101010100\n"+
                   "011010101010100101010101010100101\n"+
                   "111100000101010101010010101001010\n"+
                   "010101010101010101010010101010101\n"+
                   "010101010101010101010101010101010\n";
        try {
            System.out.println("......");
            Thread.sleep(70);
            System.out.println("FTPServer......");
            Thread.sleep(70);
            char[] charr=str.toCharArray();
            for (int i = 0; i <charr.length ; i++) {
                Thread.sleep(50);
                System.out.print(charr[i]);
            }
            System.out.println("FTP Server");
        } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }

    public void SSHactPic(){
        String str="1：>>>>>>>>>>>>>>>>>>>>>>>>>>\n"+
                "2：>>>>>>>>>>>>>>>>>>>>>>>>>>\n"+
                "3：>>>>>>>>>>>>>>>>>>>>>>>>>>\n"+
                "4：>>>>>>>>>>>>>>>>>>>>>>>>>>\n"+
                "5：>>>>>>>>>>>>>>>>>>>>>>>>>>\n"+
                "6：>>>>>>>>>>>>>>>>>>>>>>>>>>\n"+
                "7：>>>>>>>>>>>>>>>>>>>>>>>>>>\n"+
                "8：>>>>>>>>>>>>>>>>>>>>>>>>>>\n"+
                "9：>>>>>>>>>>>>>>>>>>>>>>>>>>\n";
        try {
            System.out.println("......");
            Thread.sleep(70);
            System.out.println(".....");
            Thread.sleep(70);
            char[] charr=str.toCharArray();
            for (int i = 0; i < charr.length; i++) {
                Thread.sleep(50);
                System.out.print(charr[i]);
            }
            System.out.println("");
        }catch (InterruptedException ex){
            ex.printStackTrace();
        }
    }

/
    public void definer(){
        String str="0%>>>>>>>>>>>>>50%>>>>>>>>>>>>>>100%";
        char[] charr=str.toCharArray();
        System.out.println("......");
        try {
        for (int i = 0; i < charr.length; i++) {
            Thread.sleep(50);
            System.out.print(charr[i]);
        }  } catch (InterruptedException e) {
        e.printStackTrace();
    }
        System.out.println("");
    }


    public void ProHackPic(){
        String str="hr pte .rogle..aacm c.ompk..\n"+
                " paoe .rogrh.mplet..ckam c..\n"+
                "hagom.pram cletck pe .ro....\n"+
                "...hagrlete .ackpro m comp..\n"+
                "hpm ce omo...graack ..pletr.\n"+
                "tehacr p co....mpleogramk ..\n"+
                "hack  coete .pamlprog...mr..\n"+
                "hack program p.le ..com.te..\n"+
                "hack program complete ......\n";
        char[] charr=str.toCharArray();
        System.out.println("IP......");
        try {
            for (int i = 0; i < charr.length; i++) {
                Thread.sleep(50);
                System.out.print(charr[i]);
            }  } catch (InterruptedException e) {
            e.printStackTrace();
        }
    }




    }







