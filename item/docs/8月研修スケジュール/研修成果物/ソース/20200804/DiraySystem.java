package HackSystem;

import java.util.Scanner;

public class DiraySystem {

    HomePage home=new HomePage();

    public DiraySystem(){}

    public void stMenu(){
        do {
            Scanner scan=new Scanner(System.in);
            home.st();
            System.out.println("：");
            //String index=scan.next();
            
            int index=scan.nextInt();
			switch (index){
                case 1:
                    Login();
                    break;
                case 2:
                    sysInfo();
                    break;
                case 3:
                    return;
//                    System.exit(0);
//                    break;

                default:
                    
                    System.out.println("！！！");
                    stMenu();
            }
        }while (true);

    }

    public void Login(){
        Scanner scan =new Scanner(System.in);
        User user= FileTools.Load();
        System.out.println("：");
        String username=scan.next();
        System.out.println("：");
        String password=scan.next();
        if (user.getUsername().equals(username) && user.getPassword().equals(password)){
            home.edMune();

        }else{
            System.out.println("！");
            return;
        }
    }



    public void sysInfo(){
               char[] charr=str.toCharArray();
        try {
        System.out.println("==========================================================");
            for (int i = 0; i < charr.length; i++) {
                Thread.sleep(100);
                System.out.print(charr[i]);
            }
        System.out.println("==========================================================");
            return;
    } catch (InterruptedException e) {
        e.printStackTrace();
    }
    }


    public void star(){
        User user= FileTools.Load();
        home.HomeIndex();
        stMenu();

    }


}
