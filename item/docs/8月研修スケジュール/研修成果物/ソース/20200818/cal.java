package Text;

import java.util.Scanner;
public class cal {
    Scanner scan=new Scanner(System.in);


    public void welcome(){
        System.out.println("**************************");
        System.out.println("");
        System.out.println("**************************");
        System.out.println("1.����\n2.����\n3.����\n4.����\n5.����");
        System.out.println("**************************");
    }
    public void sum(){
        double num1;
        double num2;
        System.out.println("��һ");
        num1=scan.nextDouble();
        System.out.println("�ڶ�");
        num2=scan.nextDouble();
        double num3=num1+num2;
        System.out.println("*****"+num3+"*****");
    }
    public void jianfa(){
        double num1;
        double num2;
        System.out.println("��һ");
        num1=scan.nextDouble();
        System.out.println("�ڶ�");
        num2=scan.nextDouble();
        double num3=num1-num2;
        System.out.println("*****"+num3+"*****");
    }
    public void chengfa(){
        double num1;
        double num2;
        System.out.println("��һ");
        num1=scan.nextDouble();
        System.out.println("�ڶ�");
        num2=scan.nextDouble();
        double num3=num1*num2;
        System.out.println("*****"+num3+"*****");
    }
    public double avg(double num1,double num2){
        double num3=num1/num2;
        System.out.println("*****"+num3+"*****");
        return num3;
    }
    public double quyu(double num1,double num2){
        double num3=num1%num2;
        System.out.println("*****"+num3+"*****");
        return num3;
    }
}
