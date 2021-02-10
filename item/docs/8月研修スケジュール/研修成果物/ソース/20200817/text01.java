
import java.util.Scanner;
public class text01 {
        public static void main(String[ ] args) {
        Scanner scan=new Scanner(System.in);
        double[ ] scores = new double[5];
        double  max=scores[0];
        double  min=scores[0];
        for (int i=0;i<scores.length;i++)
        {
            System.out.println(""+(i+1)+"");
            scores[i]=scan.nextDouble();
            if (max<scores[i])
            {
                max=scores[i];
            }
            if (min>scores[i])
            {
                min=scores[i];
            }
        }
        double  sum=0;
        for (int i=0;i<scores.length;i++)
        {
            System.out.println(""+(i+1)+":"+scores[i]);
            sum=sum+scores[i];
        }
        double avg=sum/scores.length;
        System.out.println(""+max);
        System.out.println(""+min);
        System.out.println(""+avg);
        
    }
}