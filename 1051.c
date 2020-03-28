#include <stdio.h>
 
int main() {
    float total;
    scanf("%f", &total);
    if(total <= 2000.00){
        printf("Isento\n");
    }else{
        if(total <= 3000.0){
            total = ((total - 2000.0) * 0.08);
        }else if(total <= 4500.0){
            total = (total - 3000.0) * 0.18 + (1000.0 * 0.08);
        }else{
            total = (total - 4500.0) * 0.28 + (1500.0 * 0.18) + (1000.0 * 0.08);
        }
            printf("R$ %.2f\n", total);
    }
    return 0;
}
