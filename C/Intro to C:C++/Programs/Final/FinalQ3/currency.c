/* Program: currency.c
 Author: Michael Campbell
 Date: 7/20/10
 Synopsis: program accepts arguments from the command line and
 converts foreign currency into US dollars.
 */

#include <stdlib.h>
#include <stdio.h>
#include <string.h>

int main (int argc, const char * argv[]) 
{
	
	int result = 0;
	int value = 0;
//	char c[2];


	value = atoi(argv[2]);
	printf("value = %i\n", value);	
	
	if (argc != 3){
		fprintf(stderr, "Need country code and amount\n");
		return 1;
	}
/*	
	if (argv[1] == "EU")
		c[0] = 'E';
	else if (argv[1] == "BP")
		c[0] = 'B';
	else if (argv[1] == "CD")
		c[0] = 'D';
	else if (argv[1] == "CY")
		c[0] = 'Y';	
*/	
//	printf("c[0] = %s", c[0]);
	printf("argv[1] = %s", argv[1]);
	
	 switch (*argv[1]) {
	 case 'E':
	 result = value * 1.4;
	 break;
	 case 'B':
	 result = value * 1.5;
	 break;
     case 'D':
	 result = value * 0.99;
	 break;
	 case 'Y':
	 result = value * 8;
	 default:
	 break;
	 }

	printf("argv = %s\n", argv[2]);	
	
	
	printf("\nResult = %i\n", result);
	
	return 0;
}


