#include <iostream>
using namespace std;

int main() {
    // Declare variables to store the two numbers and a temporary variable
    int num1;
    int num2;
    int temp;

    // Prompt the user to enter two numbers
    cout << "Please enter two numbers: ";
    cin >> num1;  // Read the first number from the user
    cin >> num2;  // Read the second number from the user

    // Print the original numbers entered by the user
    cout << "Original numbers:" << endl;
    cout << num1 << endl;
    cout << num2 << endl << endl;

    // Swap the values of num1 and num2 using a temporary variable
    temp = num1;
    num1 = num2;
    num2 = temp;

    // Print the numbers after swapping
    cout << "Numbers after swapping:" << endl;
    cout << num1 << endl;
    cout << num2;

    return 0;
}
