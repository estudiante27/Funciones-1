
Meet
Iniciar una reunión
Unirte a una reunión
Chat

11 de 199
6C-CERVELLINI-LABPROGRA
Recibidos
x

Ignacio Agustín Cervellini <aicervellini@gmail.com>
Adjuntos
30 abr. 2020 23:42
para profe.leila.coronel, horaciov714



--
Agustin Cervellini 
2 archivos adjuntos

Horacio Villa
1 may. 2020 09:15
Que tal: Recorda que se deben cambiar los nombres de los "archivos" por el formato que yo pedí (apellido+nºtp+nºejercicio) El jue., 30 abr. 2020 a las 23:42, Ig

Leila Coronel <profe.leila.coronel@gmail.com>
1 may. 2020 12:10
para mí

Recibido! Muchas gracias!


#include <stdio.h>
#include <stdlib.h>

int main()
{
    int num1[6],num2[6],Rsuma[6],Rresta[6],Rmultiplicar[6],Rdividir[6];
    int i=0,r=0,x=0,opcion,num=0,k=0;

    for(i=0;i<6;i++){
        printf("ingresar primer numero\n");
        scanf("%d",&num1[i]);
        printf("ingresar segundo numero\n");
        scanf("%d",&num2[i]);
        Rsuma[i]=suma(num1[i],num2[i],Rsuma[i]);
        Rresta[i]=resta(num1[i],num2[i],Rresta[i]);
        Rmultiplicar[i]=multiplicar(num1[i],num2[i],Rmultiplicar[i]);
        Rdividir[i]=dividir(num1[i],num2[i],Rdividir[i]);
    }
    while(x!=1){
        printf("1.suma\n2.resta\n3.multiplicacion\n4.division\n5.no deseo ver niguna operacion mas\n");
        scanf("%d",&opcion);
        if(opcion==1){
            for(i=0;i<6;i++){
                printf("%d+%d=%d\n",num1[i],num2[i],Rsuma[i]);
            }
        }
        if(opcion==2){
            for(i=0;i<6;i++){
            printf("%d-%d=%d\n",num1[i],num2[i],Rresta[i]);
            }
        }
        if(opcion==3){
            for(i=0;i<6;i++){
            printf("%d*%d=%d\n",num1[i],num2[i],Rmultiplicar[i]);
            }
        }
        if(opcion==4){
            for(i=0;i<6;i++){
            printf("%d/%d=%d\n",num1[i],num2[i],Rdividir[i]);
            }
        }
        if(opcion==5){
            x=1;
        }
    }

    printf("ingrese numero a buscar\n");
    scanf("%d",&num);

    while(k!=1){
        k=0;
        i=0;
        while(k==0 && i<6){
            if(num==num1[i]){
                k=1;
            }
            else{
            i++;
            }
        }
        if(k==0){
            while(k==0 && i<6){
                if(num==num2[i]){
                    k=1;
                }
                else{
                    i++;
                }
            }
        }

    }
    if(k==1){
        printf("el numero %d se encuentra en a posicion %d\n",num,i);
    }
    else{
        printf("numero inexistente\n");
    }

    return 0;
}
