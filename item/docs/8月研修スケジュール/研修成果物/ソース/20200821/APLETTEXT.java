
import java.awt.*;
public class APLETTEXT extends Frame{
    public static void main(String[]args){
        APLETTEXT fr=new APLETTEXT("First Contianer!");
        fr.setSize(600,600);
        fr.setBackground(Color.yellow);
        fr.setVisible(true);
        System.exit(0);

    }
    public APLETTEXT(String str) {
        super(str); 
    }
}
