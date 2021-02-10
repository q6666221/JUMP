package HackSystem;

import java.io.*;
import java.util.List;

public class FileTools {

    public static void Save(User user){
        try {
            File file=CreatFile();
            ObjectOutputStream oos=new ObjectOutputStream(new FileOutputStream(file));
            oos.writeObject(user);
            oos.flush();
            oos.close();
        } catch (IOException e) {
            System.out.println("！！！");
            e.printStackTrace();
        }
    }

    public static User Load(){
        User user=null;
        try {
            File isinfile=new File("..//DirayFiles//diray.object");
            if (!isinfile.exists()){
                System.out.println("");
                HomePage homePage=new HomePage();
                homePage.firstin();
            }
            File file=CreatFile();
            ObjectInputStream ois=new ObjectInputStream(new FileInputStream(file));
            user= (User) ois.readObject();
            return user;
        } catch (Exception e) {
            e.printStackTrace();
        }
        return user;
    }

    public static File CreatFile() throws IOException {
        File path=new File("..//DirayFiles");
        if (!path.exists()){
            path.mkdirs();
        }
        File file=new File(path,"diray.object");
        file.createNewFile();
        System.out.println(file.getAbsolutePath());
        return file;
    }


    public static void PutOut(Diray diray){
        BufferedWriter writer=null;
        try {
            String title= diray.getTitle();
            File file=new File("..//DirayFiles//"+title+".txt");
            StringBuffer info= diray.getPageinfo();
            file.createNewFile();
            writer=new BufferedWriter(new FileWriter(file));
            writer.write(title);
            writer.newLine();
            writer.write(diray.getTime());
            writer.newLine();
            writer.write(info.toString());
            System.out.println("，"+"："+file.getAbsolutePath());
            writer.flush();
            writer.close();
            return;
        } catch (Exception e) {
            e.printStackTrace();
        }
    }


    public static void DeleteDiary(User user, Diray diray){
       List<Diray> list= user.getUserdiray();
       for (Diray dir:list){
           if (dir.getTitle().equals(diray.getTitle())){
               list.remove(dir);
           }
       }
       Save(user);
    }


}
