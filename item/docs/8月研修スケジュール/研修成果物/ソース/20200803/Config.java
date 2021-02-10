//package HackSystem;
//
//
//import com.sun.management.OperatingSystemMXBean;
//import java.io.File;
//import java.lang.management.ManagementFactory;
//import java.text.SimpleDateFormat;
//import java.util.Date;
//import java.util.Scanner;
//
//import Diray.*;
//
//
//public class Config {
//

//    public Config(){}
//

//    HackPic hackPic=new HackPic();
//    Scanner scan=new Scanner(System.in);
//    OperatingSystemMXBean mem=(OperatingSystemMXBean) ManagementFactory.getOperatingSystemMXBean();
//    Viruses viruses=new Viruses();
//    Servers servers=new Servers();
//
//
//
//    public void SetConfig(String str){

//        if (str.equals("ver")){

//            System.out.println("：HackSystem OS 1.0 Beat: HackCore 9970K");
//        }else if(str.equals("time")){

//            SimpleDateFormat df = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
//            System.out.println(df.format(new Date()));
//        }else if (str.equals("connect")){
//          //            System.out.println("");
//        }else if (str.equals("scan")){
//            //            System.out.println("：");
//        }else if (str.equals("EXIT")){
//           //            System.out.println("......");
//            System.exit(0);
//        }else if (str.equals("disklist")){
//           
//            File[] roots = File.listRoots();
//            System.out.println("================================================================================");
//            for (File _file : roots) {
//                System.out.println(_file.getPath());
//                System.out.println(" : " + _file.getFreeSpace()/1024/1024+"M"+"   : " + _file.getUsableSpace()/1024/1024+"M"+"   : " + _file.getTotalSpace()/1024/1024+"M");
//            }
//            System.out.println("================================================================================");
//        }else if (str.equals("raminfo")){
//           
//            System.out.println("： "+mem.getTotalPhysicalMemorySize()/1024/1024+"M");
//            System.out.println(" ： "+mem.getFreePhysicalMemorySize()/1024/1024+"M");
//        }else if(str.equals("defender")){
//          
//            hackPic.definer();
//
//        }else if(str.equals("gameinfo")){
//            //            //        }else if(str.equals("diray")){
//           System.out.println("未完成......");
//
//
//        }else if (str.equals("submit")){
//
//            //
//            System.out.println(") ：");
//            if (scan.next().equals("")){
//                System.out.println("");
//            }
//
//
//        }else if (str.equals("save")){
//
//        }else if (str.equals("listener")) {
//           //
//        }else if (str.equals("prohack")){
//
//        }
//       //     //
//    }
//
//
//
//
//
//}
