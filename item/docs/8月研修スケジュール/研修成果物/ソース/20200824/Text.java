package Text0429;

import java.io.*;

public class Text {
    public static void main(String[]args){
        write();
        read();

    }

    public static void write(){
        TextStudentPro stu=new TextStudentPro("",20,"","00001");
        ObjectOutputStream ops=null;
        try {
            ops=new ObjectOutputStream(new FileOutputStream("G:\\filetext\\obj.object"));
            ops.writeObject(stu);
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

    public static void read(){
        ObjectInputStream ois=null;
        try {
            ois=new ObjectInputStream(new FileInputStream("G:\\filetext\\obj.object"));
            Object obj=ois.readObject();
            TextStudentPro stu=(TextStudentPro) obj;
            System.out.println(stu.getName());
            System.out.println(stu.getAge());
            System.out.println(stu.getSex());
            System.out.println(stu.getNum());

        } catch (Exception e) {
            e.printStackTrace();
        }finally {
            try {
                ois.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }

    }


}
