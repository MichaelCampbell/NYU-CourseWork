/*
 Program: Test.cpp
 Author:Michael Campbell
 Date: 11/1/10
 Synopsis: Sets precision after fraction division
 Email: Camp.Mich@yahoo.com
 */
 
#include <iostream>
#include <iomanip>
#include <cstdlib>

using namespace std;

int main()
{   float Num, Den; // Numerator, Denominator
    
    int prec;  // precision
    cout << "Enter a Numerator: ";
    cin >> Num;
    cout << "Enter a Denominator: ";
    cin >> Den;
    cout << "Enter a Decimal Precision: ";
    cin >> prec;	

          // Check for exception return den = num
			if (Den == Num && Den != 0 && Num != 0){
				cout<< 1 << "\n";
				return EXIT_SUCCESS;
			}
			//indeterminate form
			if (Num == 0 && Den == 0) {
				cout << "This result is undefined.\n";
				return EXIT_FAILURE;
			}
			// Check for exception /0 denominator
			if (Den == 0){
				cout<<"Exception, divided by 0 will produce unknown results.\n";
				return EXIT_FAILURE;
			}
	cout << fixed << setprecision(prec) << Num / Den << "\n";
	
	return EXIT_SUCCESS;
}
