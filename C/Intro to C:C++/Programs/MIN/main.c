#include <stdio.h>

#define MIN(a,b) (((a) < (b)) ? (a) : (b))

int main (void) 
{
	
	int x = 733;
	int y = 101;

	
    printf("Min = %i\n", MIN(x,y));
	
    return 0;
}
