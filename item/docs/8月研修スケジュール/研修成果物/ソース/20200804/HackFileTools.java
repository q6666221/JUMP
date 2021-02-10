package HackSystem;

import java.io.*;
import java.util.List;

public class HackFileTools {

    File filepath=new File("..//HackSystem");


    public File CreatFile() throws IOException {
        if (!filepath.exists()){
            filepath.mkdirs();
        }
        File file=new File(filepath,"hack.object");
        file.createNewFile();
        System.out.println(file.getAbsolutePath());
        return file;
    }

    public void Save(List<Servers> serversList){
        try {
            File file=CreatFile();
            ObjectOutputStream oos=new ObjectOutputStream(new FileOutputStream(file));
            oos.writeObject(serversList);
            oos.flush();
            oos.close();
        } catch (IOException e) {
            System.out.println("：");
            e.printStackTrace();
        }
    }


    public List<Servers> Load(){
        List<Servers> serversList=null;
        try {
            File infile=new File("..//HackSystem//hack.object");
            if (infile.exists()){
                
            }
            File file=CreatFile();
            ObjectInputStream ois=new ObjectInputStream(new FileInputStream(file));
            serversList=(List<Servers>) ois.readObject();
            return serversList;
        } catch (Exception e) {
            System.out.println("：");
            e.printStackTrace();
        }
        return serversList;
    }

}
