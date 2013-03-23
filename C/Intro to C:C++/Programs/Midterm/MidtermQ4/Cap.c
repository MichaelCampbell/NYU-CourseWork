/* Program; FibSum.c
 Author: Michael Campbell
 Date; 7/6/10
 Synopsis: Program that contains a function that will convert the first character of each word to a upper case letter
 */

#include <stdio.h>
#include <ctype.h>
#include <stdbool.h>
 
bool alphabetic (const char c)
 {
 if ( (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
 return true;
 else 
 return false;
 
 }
 
 //Function to capitalize the first letter of each word in a string 

char Cap (const char string[])
{
	int i;
	bool alphabetic (const char c);
	
	if (islower(string[0]))
		string[0] = toupper(string[0]);
	
	while (string[i] != '\0')
		if (alphabetic(string[i])){
			if (string[i] == " "){
				string[i + 1] = toupper(string[i+1]);
			}
		}	
	
	return string;
}

int main (void)
{
	const char prose[] = "to be or not to be that is the question";
	
	char Cap (const char string[]);
	
	printf ("%s - words = %i\n", prose, Cap(prose));


	
	
	return 0;
}

