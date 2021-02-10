package Text0429;

import StudentALL.Student;

import java.io.*;
import java.util.ArrayList;
import java.util.List;

public class TextListPro {
    public static void main(String[]args){
        ListPro list=new ListPro();
        list.setArrlist();
        write();
//        read();
        readarr();


    }
    public static void write(){
        List<TextStudentPro> arrlist=new ArrayList<>();
        List<TextStudentPro> arrlist2=new ArrayList<>();
        List<TextStudentPro> arrlist3=new ArrayList<>();
        List<List<TextStudentPro>> classarr=new ArrayList<>();

        TextStudentPro stu=new TextStudentPro("",20,"","00001");
        TextStudentPro stu2=new TextStudentPro("",22,"","00002");

        TextStudentPro stu3=new TextStudentPro("",20,"""00001");
        TextStudentPro stu4=new TextStudentPro("",22,"","00002");

        TextStudentPro stu5=new TextStudentPro("",20,"","00001");
        TextStudentPro stu6=new TextStudentPro("",22,"","00002");

        arrlist.add(stu);
        arrlist2.add(stu2);
        arrlist2.add(stu3);
        arrlist2.add(stu4);
        arrlist3.add(stu5);
        arrlist3.add(stu6);

        classarr.add(arrlist);
        classarr.add(arrlist2);
        classarr.add(arrlist3);


        ObjectOutputStream ops=null;
        try {
            ops=new ObjectOutputStream(new FileOutputStream("G:\\filetext\\objs.object"));
            ops.writeObject(classarr);
            ops.flush();
        } catch (IOException e) {
            e.printStackTrace();
        }finally {
            try{
                if (ops!=null){
                    ops.close();
                }
            }catch (Exception e){
                e.printStackTrace();
            }
        }
    }

//    public static void read(){
////        ObjectInputStream ois=null;
////        try {
////            ois=new ObjectInputStream(new FileInputStream("G:\\filetext\\objs.object"));
////            List<TextStudentPro> list= (ArrayList) ois.readObject();
////            for (TextStudentPro obj1:list){
////                System.out.println(obj1.getName());
////                System.out.println(obj1.getAge());
////                System.out .println(obj1.getNum());
////                System.out.println(obj1.getSex());
////            }
////
////        } catch (Exception e) {
////            e.printStackTrace();
////        }finally {
////            try {
////                ois.close();
////            } catch (IOException e) {
////                e.printStackTrace();
////            }
////        }
////    }

    public static void readarr(){
        ObjectInputStream ois=null;
        try {
            ois=new ObjectInputStream(new FileInputStream("G:\\filetext\\objs.object"));
            List<List<TextStudentPro>> lists=(List<List<TextStudentPro>>)ois.readObject();

            for(List<TextStudentPro> list:lists){
                for(TextStudentPro pro: list){
                    System.out.print(pro.getName()+"  ");
                    System.out.print(pro.getAge()+"  ");
                    System.out.println(pro.getNum()+"   ");
                    System.out.println("");

                }
            }


        }catch (Exception ex){
            ex.printStackTrace();
        }finally {
            try {
                ois.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }



    }




}
