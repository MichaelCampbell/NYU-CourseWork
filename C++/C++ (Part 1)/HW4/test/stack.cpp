#include <iostream>
#include <cstdlib>
#include "stack.h"
using namespace std;

stack::~stack()   //destructor
{
	//cout << "destructor for stack\n";
	
	if (n != 0) {
		cerr << "Warning: stack still contains " << n << " value(s).\n";
	}
}

//Push a value onto the stack.

void stack::push(int i)
{
	if (n == stack_max_size) {   //overflow
		cerr << "Can't push when size " << n << " == capacity "
		<< stack_max_size << ".\n";
		exit(EXIT_FAILURE);
	}
	
	a[n++] = i;
}

//Pop a value off the stack.

int stack::pop()
{
	if (n == 0) {                //underflow
		cerr << "Can't pop when size " << n << " == 0.\n";
		exit(EXIT_FAILURE);
	}
	
	return a[--n];
}