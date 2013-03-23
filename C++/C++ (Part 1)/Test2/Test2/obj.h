#ifndef OBJH
#define OBJH
#include <iostream>   //for <<, >>, ostream, istream
using namespace std;

class obj {
	int i;
public:
	obj(int initial_i)      {i = initial_i; cout << "construct " << i << "\n";}
	obj(const obj& another) {i = another.i; cout << "copy construct " << i << "\n";}
	obj()                   {i = 0; cout << "default construct " << i << "\n";}
	
	~obj() {cout << "destruct " << i << "\n";}
	void print() const {cout << i;}
	
	obj& operator++() {++i; return *this;}   //prefix
	operator int() const {return i;}
	friend ostream& operator<<(ostream& ostr, const obj& ob) {return ostr << ob.i;}
	friend istream& operator>>(istream& istr,       obj& ob) {return istr >> ob.i;}
};

inline const obj operator++(obj& ob, int) {      //postfix
	const obj old = ob;
	++ob;   //ob.operator();
	return old;
}
#endif