package Text0429;

import java.io.Serializable;
import java.util.ArrayList;

public class ListPro implements Serializable {
    public ArrayList arrlist=new ArrayList();
    TextStudentPro stu=new TextStudentPro("",20,"男","00001");
    TextStudentPro stu2=new TextStudentPro("",22,"男","00002");

    public void setArrlist(){
        arrlist.add(stu);
        arrlist.add(stu2);
    }

    public void show(){
        for (Object obj:arrlist){
            System.out.println(obj);
        }
    }


}
