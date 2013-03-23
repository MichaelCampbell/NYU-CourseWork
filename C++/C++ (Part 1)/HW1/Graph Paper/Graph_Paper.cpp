/* Program: Graph_Paper.cpp 
 Author: Michael Campbell 
 Date: 10/4/10 
 Synopsis: Create user defined Graph Paper 
 */

#include <iostream>
#include <cstdlib>

int main () {
		
	//Get Size info
	std::cout << "\nHow many rows (e.g., 10)? \n";
	int nrows;	//uninitialized variable
	std::cin >> nrows;
	
	std::cout << "How many columns (e.g., 10)? \n";
	int ncols;	//uninitialized variable
	std::cin >> ncols;
	
	std::cout << "Column Width (e.g., 10)? \n";
	int colwidth;	//uninitialized variable
	std::cin >> colwidth;
	
	std::cout << "Row Height (e.g., 10)? \n";
	int rowheight;	//uninitialized variable
	std::cin >> rowheight;
	
	//Loops
	for (int r = 0; r < nrows; ++r) {
//Prints top line for row
			for (int c = 0; c < ncols; ++c) {
				std::cout << "+";
				for(int i = 0; i < colwidth; ++i) {
					std::cout << "-";
				}
			
			}
		std::cout << "\n";
//Prints column dividers
		for (int rh = 0; rh < rowheight; ++rh) {
			for (int c = 0; c < ncols; ++c) {
				std::cout << "|";
				for (int j = 0; j < colwidth; ++j) {
					std::cout << " ";
				}
			}
			std::cout << "\n";
		}
	}
	
	std::cout << "\n";
	return EXIT_SUCCESS;
}