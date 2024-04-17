#include <iostream>
using namespace std;
int main()
{
    int x = 5, y = 3;
    cout<<x<<y<<endl;
    swap(x,y);
    cout<<x<<y<<endl;
    return 0;
}
void swap(int num1,int num2)
{
    int temp = num1;
    num1 = num2;
    num2 = temp;
}