#include <stdio.h>


long int x_to_the_n (int x, int n)
{

	int i;
	int result;
	
	result = 1;
	
	for (i = 1; i <= n && n > 0; i++) 
		result *= x;
		
	return result;
	
}
int main (void)
{
	int x = 4;
	int n = 3;
	long int x_to_the_n (int x, int n);
    
	printf("\nResult = %li\n\n", x_to_the_n(x, n));
    
	return 0;
}
