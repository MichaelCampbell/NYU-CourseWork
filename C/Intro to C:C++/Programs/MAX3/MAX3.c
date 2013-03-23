#include <stdio.h>

#define MAX3(a,b,c) (a > b) ? ((a > c) ? a : c) : ((b > c) ? b : c);

int main (void) 
{

	int x = 7;
	int y = 101;
	int z = 44;
	int maximum;
	
	maximum = MAX3(x,y,z);
	
    printf("Max = %i\n", maximum);
	
    return 0;
}
