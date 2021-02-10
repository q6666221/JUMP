package Text0426;

import java.io.*;

public class TextFile {
    public static void main(String[]args){
        reader("G:\\01.mp4","G:\\filetext\\01.mp4");

    }

    public static void reader(String fromName,String tofile){
        try {
            FileInputStream fi=new FileInputStream(fromName);
            BufferedInputStream bi=new BufferedInputStream(fi);
            FileOutputStream fo=new FileOutputStream(tofile);
            BufferedOutputStream bo=new BufferedOutputStream(fo);
            byte[] by=new byte[999999];
            int len=0;
            while((len=bi.read(by))!=-1){
                bo.write(by,0,len);
                bo.flush();
            }
            fi.close();
            bi.close();
            fo.close();
            bo.close();
        } catch (Exception e) {
            e.printStackTrace();
        }


    }


}
