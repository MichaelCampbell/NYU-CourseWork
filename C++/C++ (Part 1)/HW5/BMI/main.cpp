#include <iostream>
using namespace std;
#include "BMI.h"

int main () {
	
	cout << "\nLet's check your BMI\n"
	<< "Please input your weight (in pounds).\n";
	int weight = 0;
	cin >> weight;
	
	cout << "Please input your height (in inches).\n";
	int height = 0;
	cin >> height;
	
	cout << "Please input your sex. (Use 0 for female and 1 for male).\n";
	bool sex = 0;
	cin >> sex;

	BMI user(weight, height, sex);
	
	user.BMICalc(weight, height, sex);
		
    return EXIT_SUCCESS;
}
