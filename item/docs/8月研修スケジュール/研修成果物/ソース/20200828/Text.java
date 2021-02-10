package Text0329;

public class Text {
    public static void  main(String[] args) {
   
        for (int i=1;i<=9;i++)
        {
            for (int j=1;j<=i;j++)
            {
                System.out.print(j+"*"+i+"="+i*j+"\t");
            }
            System.out.println();
        }
        /*

         *****
         ****
         ***
         **
         *



        * */
        System.out.println("\n****************************\n");
        for (int i=1;i<=5;i++)
        {
            for (int j=5;j>=i;j--)
            {
                System.out.print("*");
            }
            System.out.println();
        }
        System.out.println("\n****************************\n");



        /*



         *
         **
         ***
         ****
         *****


        * */

        for (int i=1;i<=5;i++)
        {
            for (int j=1;j<=i;j++)
            {
                System.out.print("*");
            }
            System.out.println();
        }
        System.out.println("\n****************************\n");
        /*

             *
            **
           ***
          ****
         *****

        * */
        for (int i=0;i<5;i++)
        {
            for (int j=0;j < 5-1-i; j++)
            {
                System.out.print(" ");
            }
            for (int j = 0; j < i+1; j++) {

                System.out.print("*");

            }
            System.out.println();
        }
        System.out.println("\n****************************\n");

        /*

         *****
          ****
           ***
            **
             *

        * */


        for (int i=0;i<5;i++)
        {
            for (int j=0;j<i; j++) {
                System.out.print(" ");
            }
                for (int k=1;k<=5-i;k++)
                {
                    System.out.print("*");
                }
            System.out.println();
        }

        System.out.println("\n****************************\n");
        /*

             *
            * *
           * * *
          * * * *
         * * * * *

         * */


        for (int i=0;i<5;i++)
        {
            for (int j=0;j < 5-1-i; j++)
            {
                System.out.print(" ");
            }
            for (int j = 0; j < i+1; j++) {

                System.out.print("* ");

            }
            System.out.println();
        }
        System.out.println("\n****************************\n");




        System.out.println("\n****************************\n");
        /*


         *****
         *****
         *****
         *****
         *****


        * */
        for (int i=1;i<=5;i++)
        {
            for (int j=1;j<=5;j++)
            {
                System.out.print("*");
            }
            System.out.println();
        }


        System.out.println("\n****************************\n");
        System.out.println("\n****************************\n");
        System.out.println("\n****************************\n");
    }
}

