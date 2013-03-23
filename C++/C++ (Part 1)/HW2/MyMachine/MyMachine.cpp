/* Program: MyMachine.cpp 
 Author: Michael Campbell 
 Date: 10/18/10 
 Synopsis: C++ values on my platform
 Email: Camp.Mich@yahoo.com */

#include <iostream>
#include <cstdlib>
#include <climits>
using namespace std;

int main () {
	int randint;
	int five = 5;
	cout << "\n";
	
//1. the minimum and maximum value you can put in an int
	cout << "On my machine, an int can hold values in the range of\n"
	<< INT_MIN << " to " << INT_MAX << " inclusive.\n\n";;
//2. what happens when you add 1 to an int that already holds the maximum value
	cout << "On my machine, when you add 1 to an int that already holds the maximum value, you get \"" << INT_MAX + 1 << "\"\n\n";
//3. the number of bytes occupied by an int
	cout << "On my machine, an int occupies " << sizeof (int) << " bytes.\n\n";
//4. what value is in an int when you have never put any value into it
	cout << "On my machine, the value of an int when you have not put a value into it is \"" << randint << "\"\n\n"; 
//5. what happens when you divide an int by zero
	cout << "On my machine, when you divide an int, such as " << five << "by zero, you get: \"Floating point exception\"\n\n";
//6. the value of the expressions -38 / 5 -38 % 5
	cout << "On my machine, the value of the expression -38 / 5, is " << -38 / 5 << ", and the value of -38 % 5, is " << -38 % 5 << "\n\n";
	
	return EXIT_SUCCESS;
}
