import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        int num = input.nextInt();
                                         
        String[] romanos = new String[]{"I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"};
        int[] arabicos = new int[]{1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000};
        String res = "";
        int j = 12;
        for(int i = 0; i <= 12;i++){
            while(num >= arabicos[j]){
                num -= arabicos[j];
                res += romanos[j];
            }if(j != 0){
                j--;
            }
        }
        System.out.println(res);
    }  
}
