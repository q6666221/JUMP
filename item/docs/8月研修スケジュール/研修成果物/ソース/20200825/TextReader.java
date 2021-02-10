package Text0426;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

public class TextReader {
    public static void main(String[]args){
//        String name="222";
//        read();
        copy("G:\\TextReader.txt","G:\\TextCopy.txt");

    }

    public static void write(String name){
        try {
            FileWriter f=new FileWriter("G:\\TextReader.txt",true);
            f.write(name);
            f.flush();
            f.close();
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    public static void read(){
        try {
            FileReader fr=new FileReader("");
            char ch[]=new char[1024];
            while(fr.read(ch)!=-1){
                String s=new String(ch,0,ch.length);
                System.out.println(s);
            }
        } catch (Exception e) {
            e.printStackTrace();
        }

    }


    public static void copy(String fromeFileName,String toFileName){
        FileWriter fw=null;
        FileReader fr=null;
        try {
            fw=new FileWriter(toFileName);
            fr=new FileReader(fromeFileName);
            char[] ch=new char[1024];
            int len=0;
            while ((len=fr.read(ch))!=-1){
                fw.write(ch,0,len);
                fw.flush();
            }
        } catch (IOException e) {
            e.printStackTrace();
        }finally {
            try{
                if (fw!=null){
                    fw.close();
                }
                if (fr!=null){
                    fr.close()
                }
            }catch (Exception ex){
                ex.printStackTrace();
            }
        }
    }
}
