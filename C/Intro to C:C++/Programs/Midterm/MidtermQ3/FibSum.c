/* Program; FibSum.c
 Author: Michael Campbell
 Date; 7/6/10
 Synopsis: Program that calculates the sum of the first 20 Fibonacci numbers.
			Fibonacci numbers are stored in integer array.
			Program calls a Fibonacci function and a sum function
 */

#include <stdio.h>

int main (void) {

	int fib[20];
	int size = 20;
	int result = 0;
	
	long int sum(int array[], int num);
	
	result = sum(fib[20], size);
	
	printf ("%i\n", result);
			
			
	return 0;
}

int Fibonacci(int array[], int num)
{
	int i;
	int fibo[100] = {0};
	
	for (i = 0; i < 2; i++)
		fibo[i] = i;
	
	for (i = 2; i < 100; i++)
		fibo[i] = fibo[i-2] + fibo[i-1];
	
	for (i = 0; i < num; i++)
		array[i] = fibo[i];
	
	return array;
	
}

long int sum(int array[], int num)
{
	int i;
	int arraySum = 0;

	int Fibonacci(int array[], int num);
	
	Fibonacci(&array[num], num);
	
	for (i = 0; i < num; i++)
		arraySum += array[i];

	return arraySum;
}