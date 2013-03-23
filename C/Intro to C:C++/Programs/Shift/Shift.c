#include <stdio.h>
#define SHIFT(x, y) (((y) > 0) ? (x <<= y) : (x >>= -y))
 

int main (void)
{
	unsigned int w1 = 0177777u, w2 = 0444u;
	
	printf("%o\t%o\n", SHIFT(w1, 5), w1 << 5);
	printf("%o\t%o\n", SHIFT(w1, -6), w1 >> 6);
	printf("%o\t%o\n", SHIFT(w2, 0), w2 >> 0);
    return 0;
}
