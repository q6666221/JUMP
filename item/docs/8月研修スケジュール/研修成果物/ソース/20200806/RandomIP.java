package HackSystem;

public class RandomIP {
    public  String getRandomIP(){
        String str1=((int)(Math.random()*255)+1)+"";
        String str2=((int)(Math.random()*255)+1)+"";
        String str3=((int)(Math.random()*255)+1)+"";
        String str4=((int)(Math.random()*255)+1)+"";
        String str=str1+"."+str2+"."+str3+"."+str4;
        return str;
        
    }
}
