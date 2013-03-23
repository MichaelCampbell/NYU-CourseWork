#include <stdio.h>


long int arraySum (int array[], int num)
{
	
	int i;
	int result;
	
	result = 0;
	
	for (i = 0; i < num; i++) 
		result += array[i];
	
	return result;
	
}
int main (void)
{
	int x[11] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

	long int arraySum (int array[], int num);
    
	printf("\nSum = %li\n\n", arraySum(x, 11));
    
	return 0;
}
