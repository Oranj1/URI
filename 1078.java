import java.io.IOException;
import java.util.Scanner;

public class Main {
    
    public static void main(String[] args) throws IOException {
 
        Scanner keyboard = new Scanner(System.in);
        int val = keyboard.nextInt();
        int num = 1;
        while(num <= 10){
        System.out.println(num + " x " + val + " = "+ num*val);
        num++;
        }
    }
        
}
