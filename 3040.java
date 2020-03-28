import java.util.Scanner;

public class Main {
     public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);      
        int times = input.nextInt();
        int i = 0;
        while(i < times){
            int altura = input.nextInt();
            int diam = input.nextInt();
            int galhos = input.nextInt();
            
            if(altura >= 200 && altura <= 300){
                if(diam >=  50){
                    if(galhos >=150){
                        System.out.println("Sim");
                    }else{
                        System.out.println("Nao");
                    }
                }else{
                    System.out.println("Nao");
                }
            }else{
                System.out.println("Nao");
            }
            i++;
        }
        
    }
}
