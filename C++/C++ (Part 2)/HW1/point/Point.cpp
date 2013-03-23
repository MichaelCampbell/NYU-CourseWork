/*
 Program: Point.cpp
 Author: Michael Campbell
 Date: 3/9/2011
 Synopsis: Chapter 6 Project 3
 */


#include <iostream>
#include <cmath>
using namespace std;

const double Pi = 4.0 * atan(1.0);


class Point {
	int x;
	int y;
public:
	void set(int new_x, int new_y);
	void move(int move_x, int move_y);
	void rotate_90();
	void input();
	int get_xpoint();
	int get_ypoint();
};

int main () {

	Point Point1, Point2;
	cout << "\nChoose a point\n\n";
	Point1.input();
	Point1.move(1, 33);
	Point1.rotate_90();
	cout << endl;
    
	Point2.set(4, 6);
	Point2.move(11, 7);
	Point2.rotate_90();
	
	
	return EXIT_SUCCESS;
}

void Point::input(){
	cout << "Enter x coordinate value: ";	
	cin >> x;
	cout << "Enter y coordinate value: ";
	cin >> y;
}
void Point::set(int new_x, int new_y){
	x = new_x;
	y = new_y;
	
}

void Point::move(int move_x, int move_y){
	x = get_xpoint();
	y = get_ypoint();
	x += move_x;
	y += move_y;
	
	cout << "Your moved to: (" << x << "," << y << ")" << endl;
}

void Point::rotate_90(){

	double rotate_x, rotate_y;
	x = get_xpoint();
	y = get_ypoint();
	
	rotate_x = x*cos(Pi/90) - x*sin(Pi/90);
	rotate_y = y*sin(Pi/90) - y*cos(Pi/90);
	cout << "Your rotated point is: (" << rotate_x << "," << rotate_y << ")" << endl;
	
}

int Point::get_xpoint(){

	return x;
}

int Point:: get_ypoint(){

	return y;
}