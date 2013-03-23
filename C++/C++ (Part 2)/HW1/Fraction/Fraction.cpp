/*
 Program: Fraction.cpp
 Author: Michael Campbell
 Date: 3/9/2011
 Synopsis: Chapter 6 Project 5
 */

#include <iostream>
using namespace std;


class Fraction {
	int num;
	int den;
	int GCD(int numer, int denom);
public:
	void set(int numer, int denom);
	double to_dec(int numer, int denom);
	void simplify(int numer, int denom);
	void input();
};



#include <iostream>

int main () {

	Fraction myFrac, yourFrac;
	myFrac.input();
	cout << endl;
	
	yourFrac.set(33, 55);
	yourFrac.simplify(33, 55);
    
	return EXIT_SUCCESS;
}

void Fraction::set(int numer, int denom){
	num = numer;
	den = denom;
	
	cout << "You Entered: (" << num << "/" << den << ")" << " which simplifies to ";

}

double Fraction::to_dec(int numer, int denom){
	double dec = 0;
	num = numer;
	den = denom;
	
	dec = num/dec;
	return dec;
}

void Fraction::input(){
	cout << "Enter numerator: ";	
	cin >> num;
	cout << "Enter denominator: ";
	cin >> den;
	cout << "You Entered: (" << num << "/" << den << ")" << " which simplifies to ";

	
	simplify(num, den);
}

int Fraction::GCD(int numer, int denom){
	if(denom == 0)  // base case, the programs stops if y reaches 0.
		return numer;
	else 
        return GCD(denom, numer % denom); //if y doesn't reach 0 then recursion continues
}

void Fraction::simplify(int numer, int denom){
	num = numer;
	den = denom;
	GCD(num, den);

	cout << "(" << numer/GCD(num, den) << "/" << denom/GCD(num, den) << ")" << endl;
}