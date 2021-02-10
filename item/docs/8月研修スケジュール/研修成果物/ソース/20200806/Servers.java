package HackSystem;

import java.io.Serializable;

public class Servers  implements Serializable {
    private String IP;
    private String name;
    private String admin;
    private String password;
    private String Debuff="受保护";
    private boolean HTTP = false;
    private boolean FTP = false;
    private boolean SSH = false;
    private boolean isOver = false;




    public Servers() {}

    public Servers(String admin, String password) {
        this.admin = admin;
        this.password = password;
    }

    public Servers(String name,String IP, String admin, String password, String debuff, boolean HTTP, boolean FTP, boolean SSH, boolean isOver) {
        setAdmin(admin);
        setName(name);
        setIP(IP);
        setPassword(password);
        setDebuff(debuff);
        setHTTP(HTTP);
        setFTP(FTP);
        setSSH(SSH);
        setOver(isOver);
    }
    public Servers( String name,String IP, String admin, String password, boolean HTTP, boolean FTP, boolean SSH, boolean isOver) {
        setAdmin(admin);
        setName(name);
        setIP(IP);
        setPassword(password);
        setHTTP(HTTP);
        setFTP(FTP);
        setSSH(SSH);
        setOver(isOver);
    }


    //setter and getter
    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }
    public String getAdmin() {
        return admin;
    }

    public void setAdmin(String admin) {
        this.admin = admin;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public boolean getHTTP() {
        return HTTP;
    }

    public void setHTTP(boolean HTTP) {
        this.HTTP = HTTP;
    }

    public boolean getFTP() {
        return FTP;
    }

    public void setFTP(boolean FTP) {
        this.FTP = FTP;
    }

    public boolean getSSH() {
        return SSH;
    }

    public void setSSH(boolean SSH) {
        this.SSH = SSH;
    }

    public String getIP() {
        return IP;
    }

    public void setIP(String IP) {
        this.IP = IP;
    }

    public String getDebuff() {
        return Debuff;
    }

    public void setDebuff(String debuff) {
        Debuff = debuff;
    }

    public boolean isOver() {
        return isOver;
    }

    public void setOver(boolean over) {
        isOver = over;
    }


    public void showserverIP(){
        System.out.println();
        System.out.println("IP : "+getIP());
        System.out.println();
    }
    public void showserverAttatc(){
        System.out.println("HTTP WebServer protected : "+getHTTP());
        System.out.println("FTP Server protected : "+getFTP());
        System.out.println("SSH protected : "+getSSH());
    }

    public void showserverinfo(){
        System.out.println(getName()+"  "+getIP()+"  "+getDebuff());
    }

}
