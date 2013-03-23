//Function to determine if a character is alphabetic

#include <stdio.h>
int main (void)
{
	const char text1[] = "Well, here goes.";
	const char text2[] = "And here we go... again.";
	const char text3[] = "We're already done...";
	const char number1[] = "123,456";
	const char number2[] = "-12,345";

	int countWords (const char string[]);
	
	printf ("%s - words = %i\n", text1, countWords (text1));
	printf ("%s - words = %i\n", text2, countWords (text2));
	printf ("%s - words = %i\n", text3, countWords (text3));
	printf ("%s - words = %i\n", number1, countWords (number1));
	printf ("%s - words = %i\n", number2, countWords (number2));	

	
	return 0;
}
