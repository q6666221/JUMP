package Text0424;

import java.util.ArrayList;
import java.util.List;

public class Text2<E> {
    private List<E> olist=new ArrayList<>();

    public List<E> getOlist() {
        return olist;
    }
    public void addall(List<E> olist){
        this.olist.addAll(olist);
    }

    public void setOlist(List<E> olist) {
        this.olist = olist;
    }

    public void ADD(E value){
        olist.add(value);
    }

    public void show(List<String> list){
        for (String str:list){
            System.out.println(str);
        }
    }
}
