/* Program: Macedonian_Flag.cpp 
 Author: Michael Campbell 
 Date: 10/5/10 
 Synopsis: Macedonian Flag
 Email: Camp.Mich@yahoo.com */

#include <iostream>
#include <cstdlib>
#include <cmath>
using namespace std;

int main()
{
	const int width = 300;            //number of columns of pixels
	const int height = width * 2 / 3; //number of rows of pixels
	
	const int xmax = width / 2;       // = 150
	const int ymax = height / 2;	  // = 100
	const int xmin = xmax - width;    // = -150
	const int ymin = ymax - height;   // = -100
	
	cout << "P3\n"                    //magic number of Netpbm .ppm file
	<< width << " " << height << "\n"
	<< 255 << "\n";           //maximum color value; 0 is minimum
	
//Create flag
	for (int y = ymax - 1; y >= ymin; --y) {		//top to bottom
		for (int x = xmin; x < xmax; ++x) {		//left to right

			if (x <= width && y <= height) {
	//Yellow BackSlash (Bottom Right)			
				if (y >= -x && y <= (-2 * x)/3 && x >= 0 && y <= 0) {
					cout << 253 << "\t" << 255 << "\t" << 3 << "\n"; // Yellow
				} 
	//*Yellow BackSlash (Top Left)			
				else if (y <= -x && y >= (-2 * x)/3 && x <= 0 && y >= 0) {
					cout << 253 << "\t" << 255 << "\t" << 3 << "\n"; // Yellow
				} 
	//*Yellow BackSlash (Bottom Left)			
				else if (y >= x && y <= (2 * x)/3 && x <= 0 && y <= 0) {
					cout << 253 << "\t" << 255 << "\t" << 3 << "\n"; // Yellow
				} 
	//Yellow ForwardSlash (Top Right)			
				else if (y <= x && y >= (2 * x)/3 && x >=0 && y>=0){
					cout << 253 << "\t" << 255 << "\t" << 3 << "\n"; // Yellow
				}
	//Yellow Oar Bar (Top Right)			
				else if ((y >= (50 * x)/9) && x >= 0 && y >= 0){//|| (y == (-50 * x)/9)){
					cout << 253 << "\t" << 255 << "\t" << 3 << "\n"; // Yellow
				}
	//Yellow Oar Bar (Bottom Right)			
				else if ((y <= (-50 * x)/9) && x >= 0 && y <= 0){//|| (y == (-50 * x)/9)){
					cout << 253 << "\t" << 255 << "\t" << 3 << "\n"; // Yellow
				}
	//Yellow Oar Bar (Top Left)			
				else if ((y >= (-50 * x)/9) && x <= 0 && y >= 0){//|| (y == (-50 * x)/9)){
					cout << 253 << "\t" << 255 << "\t" << 3 << "\n"; // Yellow
				}
	//Yellow Oar Bar (Bottom Left)			
				else if ((y <= (50 * x)/9) && x <= 0 && y <= 0){//|| (y == (-50 * x)/9)){
					cout << 253 << "\t" << 255 << "\t" << 3 << "\n"; // Yellow
				}
	//Yellow Dash (Top Right) 			
				else if ((y <= (9 * x)/50) && x >= 0 && y >= 0){
					cout << 253 << "\t" << 255 << "\t" << 3 << "\n"; // Yellow
				}
	//Yellow Dash (Bottom Right) 			
				else if ((y >= (-9 * x)/50) && x >= 0 && y <= 0){
					cout << 253 << "\t" << 255 << "\t" << 3 << "\n"; // Yellow
				}	
	//Yellow Dash (Top Left) 			
				else if ((y <= (-9 * x)/50) && x <= 0 && y >= 0){
					cout << 253 << "\t" << 255 << "\t" << 3 << "\n"; // Yellow
				}
	//Yellow Dash (Bottom Left) 			
				else if ((y >= (9 * x)/50) && x <= 0 && y <= 0){
					cout << 253 << "\t" << 255 << "\t" << 3 << "\n"; // Yellow
				}	
	//Red Outer Circle
				//else if (x * x + y * y >= 35 * 35 - 27 * 27){
				//	cout << 253 << "\t" << 1 << "\t" << 0 << "\n"; // Red
				//}
	//Inner Yellow Circle			
				else if (x * x + y * y <= (width / 11) * (width / 11)){
					cout << 253 << "\t" << 255 << "\t" << 3 << "\n"; // Yellow
				}
				else {
					cout << 253 << "\t" << 1 << "\t" << 0 << "\n"; // Red
				}
			}

			
		}
	}

	
	return EXIT_SUCCESS;
}