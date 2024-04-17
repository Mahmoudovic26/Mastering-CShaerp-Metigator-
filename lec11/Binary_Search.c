#include <stdio.h>
int Binary_Search(int list[],int length,int item);
void Selective_Sort(int list2[], int length2);
int Fact(int number);
int main()
{
    int list[] = {1,2,3,4,5,6,7,8,9,10};
    int length = sizeof(list)/sizeof(list[0]);
    int list2[] = {55,12,66,99,12,48,1,0,8,122};
    int length2 = sizeof(list2)/sizeof(list2[0]);
    printf("%i\n",Fact(5));
    Selective_Sort(list2,length2);
    for(int i=0;i<length2;i++)
    {
        printf("%i\t",list2[i]);
    }
    printf("\n\a\a\a\a\a\a\a\a\a\a");
    //printf("%i\n",Binary_Search(list,length,122));

    return 0;
}
int Binary_Search(int list[],int length,int item)
{
    int low = 0;
    int high = length-1;
    while(low <= high)
    {
        int mid = (low + high)/2;
        int guess = list[mid];
        if(guess == item)
        {
            return mid;
        }
        else if(guess > item)
        {
            high = mid -1;
        }
        else
        {
            low = mid +1;

        }
    }
    return -1;
}
void Selective_Sort(int list2[], int length2)
{
    for(int i =0;i< length2-1;i++)
    {
        int midIndex = i;
        for(int j = i+1; j<length2 ;j++)
        {
            if(list2[j]<list2[midIndex])
            {
                midIndex = j;
            }
        }
        int temp = list2[midIndex];
        list2[midIndex] = list2[i];
        list2[i] = temp;
    }
}
int Fact(int number)
{
    if (number ==1)
    {
        return 1;
    }
    else{return number*Fact(number-1);}
    return -1;
}