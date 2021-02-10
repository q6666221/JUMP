package HackSystem;

public class Viruses {

    HackPic hackPic=new HackPic();

    public void  HTTPatc(Servers servers){
        hackPic.HTTPactPic();
        servers.setHTTP(false);
        System.out.println("HTTP WebServer ......");
        if (servers.getSSH()==false && servers.getFTP()==false){
            servers.setDebuff("未保护");
        }
    }

    public void FTPatc(Servers servers){
        hackPic.FTPactPic();
        servers.setFTP(false);
        System.out.println("FTP Server ......");
        if (servers.getSSH()==false && servers.getHTTP()==false){
            servers.setDebuff("未保护");
        }
    }

       public void SSHatc(Servers servers){
        hackPic.SSHactPic();
        servers.setSSH(false);
        System.out.println("SSH .......");
        if (servers.getHTTP()==false && servers.getFTP()==false){
            servers.setDebuff("未保护");
        }
    }


    public void ProHacked(Servers servers){
        System.out.println("目标主机状态："+servers.getDebuff());
        if (servers.getDebuff().equals("受保护")){
            System.out.println("......");
        }else if (servers.getDebuff().equals("")){
            hackPic.ProHackPic();
            System.out.println("");
        }
    }


}
