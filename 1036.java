import java.io.IOException;
import java.util.Scanner;
public class Main {
	public static void main (String[] args) {
		Scanner keyboard = new Scanner(System.in);
		double a = keyboard.nextDouble();
		double b = keyboard.nextDouble();
		double c = keyboard.nextDouble();
		double delta = (b * b) -4 * a * c;
		if(delta >= 0) {
			double raizDelta = Math.sqrt(delta);
			double raizUmSeZero = -b + raizDelta;
			double raizDoisSeZero = -b - raizDelta;
			if(raizUmSeZero  == 0 || raizDoisSeZero == 0) {
				System.out.println("Impossivel calcular");
			}else {	
				double raizUm = raizUmSeZero / (2 * a);
				double raizDois = raizDoisSeZero / (2 * a);				
				System.out.printf("R1 = %.5f\n", raizUm);
				System.out.printf("R2 = %.5f\n", raizDois);			
			}
		}else {
			System.out.println("Impossivel calcular");
		}		
	}
}
