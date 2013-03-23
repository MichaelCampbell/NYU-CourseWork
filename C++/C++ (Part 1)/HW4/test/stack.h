#ifndef STACKH       //C++ example
#define STACKH
#include <cstddef>   //for size_t

const size_t stack_max_size = 100;

class stack {
	int a[stack_max_size];
	size_t n;          //number of values currently in the stack
public:
	stack() {n = 0;}   //constructor: start with the stack empty
	~stack();          //destructor
	
	void push(int i);
	int pop();         //C++ doesn't need the keyword void
};
#endif