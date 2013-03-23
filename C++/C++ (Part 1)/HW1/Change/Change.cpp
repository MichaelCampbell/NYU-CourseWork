/* Program; Change.cpp
 Author: Michael Campbell
 Date; 10/4/10
 Synopsis: Convert loose change to dollar format 
 */

#include <iostream>
#include <cstdlib>
#include <string>

int main () {
    
	float total = 0;
//Quarters
	std::cout << "\nLet's figure out how much change you have in your pocket...\n\n";
    std::cout << "How many quarters do you have?\n";
	int quarters;
	std::cin >> quarters;
	//Check to see if valid amount
		while (quarters < 0 || !quarters) {
			std::cerr << "\nSorry, please try again\n";
		
			std::cin.clear();
			std::cin.ignore();
			std::cin >> quarters;
		}
	total = total + (quarters * .25);

//Dimes
    std::cout << "How many dimes do you have?\n";
	int dimes;
	std::cin >> dimes;
	//Check to see if valid amount
	while (dimes < 0 || !dimes) {
		std::cerr << "\nSorry, please try again\n";
		
		std::cin.clear();
		std::cin.ignore();
		std::cin >> dimes;
	}
	total = total + (dimes * .10);
	
//Nickels
    std::cout << "How many nickels do you have?\n";
	int nickels;
	std::cin >> nickels;
	//Check to see if valid amount
	while (nickels < 0 || !nickels) {
		std::cerr << "\nSorry, please try again\n";
		
		std::cin.clear();
		std::cin.ignore();
		std::cin >> nickels;
	}
	total = total + (nickels * .05);
	
//Pennies
    std::cout << "How many pennies do you have?\n";
	int pennies;
	std::cin >> pennies;
	//Check to see if valid amount
	while (pennies < 0 || !pennies) {
		std::cerr << "\nSorry, please try again\n";
		
		std::cin.clear();
		std::cin.ignore();
		std::cin >> pennies;
	}
	total = total + (pennies * .01);	
	
//Print Total	
	std::cout << "\nYou have $" << total << "!\n"; 
	
    return EXIT_SUCCESS;
}
