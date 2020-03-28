import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        
        Scanner input = new Scanner(System.in);
        int numMov = input.nextInt();
        String copo = input.next();
        int i = 0;
        
        while(i < numMov){
            int movimento = input.nextInt();
            
            if(movimento == 1){
                if(!copo.equals("C")){
                    
                    if(copo.equals("A")){
                        copo = "B";
                    }else{
                        copo = "A";
                    }
                }                           
            }if(movimento == 2){
                if(!copo.equals("A")){
                    
                    if(copo.equals("B")){
                        copo = "C";
                    }else{
                        copo = "B";
                    }
                }            
            }if(movimento == 3){
                if(!copo.equals("B")){
                    
                    if(copo.equals("C")){
                        copo = "A";
                    }else{
                        copo = "C";
                    }
                }              
            }
            i++;
        }
        System.out.println(copo);
    }
}
