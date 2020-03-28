#include <stdio.h>
 
int main() {
    int totalD;
    scanf("%i", &totalD);
    int ano = totalD/365;
    int mes = (totalD%365)/30;
    int dia = (totalD%365)%30;
    printf("%d ano(s)\n%d mes(es)\n%d dia(s)\n", ano,mes,dia);
    return 0;
}
