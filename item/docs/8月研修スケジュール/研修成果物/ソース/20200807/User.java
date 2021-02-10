package HackSystem;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

public class User implements Serializable {
    private String name;
    private String username;
    private String password;
    private List<Diray> userdiray=new ArrayList<Diray>();


    public User(){}

    public User(String name, String username, String password) {
        this.name = name;
        this.username = username;
        this.password = password;
    }


    public List<Diray> getUserdiray() {
        return userdiray;
    }

    public void setUserdiray(Diray diray) {
        this.userdiray.add(diray);
    }


    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }


    public void showUserDirayTitle(List<Diray> list){
        if (list.size()==0){
            System.out.println("");
            return;
        }
        System.out.println("=========================================================");
        for (Diray diray:list){
            System.out.println(diray.getTitle()+"      "+diray.getTime());
        }
        System.out.println("=========================================================");
    }
}
