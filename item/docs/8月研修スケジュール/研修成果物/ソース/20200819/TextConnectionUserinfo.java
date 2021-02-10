package maintext;

import java.util.Scanner;

public class TextConnectionUserinfo {
	public static void main(String[] args) {

		start();
		
		
	}
	
	public static void start(){
		
		UserConnection ucon=new UserConnection();
		while(true){
			Scanner scan=new  Scanner(System.in);
		switch (scan.nextInt()) {
		case 1:
			
			System.out.println("：");
			String admin=scan.next();
			System.out.println("：");
			String pass=scan.next();
			System.out.println("：");
			String name=scan.next();
			System.out.println("：");
			int age=scan.nextInt();
			System.out.println("：");
			String sex=scan.next();
			System.out.println("：");
			String phone=scan.next();
			Userinfo user=new Userinfo(admin,pass,name,sex,age,phone);
			ucon.getConnection(0, user);
			break;
		case 2:
			System.out.println("：");
			String changeadmin=scan.next();
			System.out.println(":");
			String changepass=scan.next();
			Userinfo chuser=new Userinfo(changeadmin,changepass);
			ucon.getConnection(1, chuser);
			break;
			
		case 3:
			System.out.println("");
			String deladmin=scan.next();
			Userinfo deluser=new Userinfo(deladmin);
			ucon.getConnection(2, deluser);
			break;
		case 4:
			Userinfo showuser=new Userinfo();
			ucon.getConnection(3,showuser);
			break;
		case 5:
			System.exit(0);
		default:
			System.out.println("");
			break;
		}
		}
		
	}
	

}
