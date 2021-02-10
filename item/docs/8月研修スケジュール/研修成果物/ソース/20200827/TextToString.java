package Text0424;

import java.util.List;
import java.util.ArrayList;
import java.util.Iterator;


public class TextToString<E> {
//   private List<E> list=new ArrayList<>();
//    @Override
//    public String toString() {
//        return list.toString();
//    }
//
//    public List<E> getList() {
//        return list;
//    }
//
//    public void setList(List<E> list) {
//        this.list = list;
//    }

    private String name;
    private int age;

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public int getAge() {
        return age;
    }

    public void setAge(int age) {
        this.age = age;
    }


    @Override
    public String toString() {
        return "姓名："+name+"年龄："+age;
    }
}
