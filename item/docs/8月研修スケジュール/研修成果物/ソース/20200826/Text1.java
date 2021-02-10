package Text0424;

import java.util.List;

public class Text1 {
    public static void main(String[]args){
        Text0124_01<String> list=new Text0124_01<>();
        list.ADD("list.olist.add");
        list.ADD("list.add");
        list.show(list.getOlist());
        System.out.println("-----------");
        print(list.getOlist());
    }
    public static void print(List<String> list){
        for (String str:list){
            System.out.println(str);
        }
    }
    
}
