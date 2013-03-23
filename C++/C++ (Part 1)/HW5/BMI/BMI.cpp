#include <iostream>
#include <math.h>
#include <string>
#include <iomanip>
#include <cstddef>
#include "BMI.h"
using namespace std;

const string descrip[] = {
	"You are Anorexic.\n",
	"You are Underweight.\n",
	"You are in the Normal Range.\n",
	"You are Marginally Overweight.\n",
	"You are Overweight.\n",
	"You are Severely Obese.\n",
	"You are Morbidly Obese.\n",
	"You are Super Obese.\n"
};

BMI::BMI(float initial_weight, float initial_height, bool initial_sex) {
	if (initial_weight < 0 || initial_height < 0) {
		cerr << "\nInvalid Entry.\n\n";
		exit(EXIT_FAILURE);
	}	
	
	weight = initial_weight;
	height = initial_height;
	sex = initial_sex;
	
}

void BMI::BMICalc(float weight, float height, bool sex) {
	float BMIresult = 0;
	BMIresult = (weight * 703 / (height * height));
	
	cout << "\nYour BMI is "<< setprecision (3) << BMIresult << "\n";
	BMI::print (BMIresult, sex);
}

void BMI::print(float BMIresult, bool sex){
	if (BMIresult <= 17.5) {
		cout << descrip[0];
	}
	else if (BMIresult <= 19.1 && sex == 0 || 
		BMIresult <= 20.7 && sex == 1){
		cout << descrip[1];
	}
	else if (BMIresult <= 25.8 && sex == 0 || 
		BMIresult <= 26.4 && sex == 1){
		cout << descrip[2];
	}
	else if (BMIresult <= 27.3 && sex == 0 || 
		BMIresult <= 27.8 && sex == 1){
		cout << descrip[3];
	}
	else if (BMIresult <= 32.3 && sex == 0 || 
		BMIresult <= 31.1 && sex == 1){
		cout << descrip[4];
	}
	else if (BMIresult <= 40.0){
		cout << descrip[5];
	}	
	else if (BMIresult <= 50.0){
		cout << descrip[6];
	}	
	else {
		cout << descrip[7];
	}	
}