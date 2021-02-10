package HackSystem;

import java.io.Serializable;

public class Diray implements Serializable {
    private String title;
    private StringBuffer pageinfo=new StringBuffer();
    private String time;



    public Diray() {}

    public Diray(String title, StringBuffer pageinfo,String time) {
        setTitle(title);
        setPageinfo(pageinfo);
        setTime(time);
    }

    public String getTime() {
        return time;
    }

    public void setTime(String time) {
        this.time = time;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public StringBuffer getPageinfo() {
        return pageinfo;
    }

    public void setPageinfo(StringBuffer pageinfo) {
        this.pageinfo = pageinfo;
    }


    public void showDiary(Diray diray){
        System.out.println("=====================================================");
        System.out.println(diray.getTitle());
        System.out.println(diray.getTime());
        System.out.println(diray.getPageinfo());
    }



}
