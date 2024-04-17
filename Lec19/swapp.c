#include <stdio.h>
void swap(int *num1,int *num2);
int main()
{
    int x,y;
    scanf("%d %d",&x,&y);
    printf("\n");
    printf("%i %i\n",x,y);
    swap(&x,&y);
    printf("%i %i\n",x,y);
    return 0;
}
void swap(int *num1,int *num2)
{ 
    int temp = *num1;
    *num1 = *num2;
    *num2 = temp; 
}