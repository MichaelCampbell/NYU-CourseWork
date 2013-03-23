/* Program: concatenate.c
   Author: Michael Campbell
   Date: 7/20/10
   Synopsis: concatenate function that appends string2 to string1.
				-	it checks that the sum of the lengths of both strings
					is less than 80 characters before appending
				-	prints the sum of the total length of the final 
					concatenated string
				-	strings are collected sequentially from keyboard -->
					continue gathering strings until user says no
				
 */

#include <stdio.h>
#include <string.h>

#define No	0


int main (void) {


	char s1[80];
	char s2[40] = "";
	char loop [4];
	int len1 = 80;
	int len2 = 40;
	fflush(stdin);
start:

	//first string gathered from keyboard
	printf("\nInput First String\n");
	*s1 = fgets(&s1[0] + 1, len1, stdin);
	
	//second string gathered from keyboard	
	printf("\nInput Second String\n");
	*s2 = fgets(&s2[0] + 1, len2, stdin);

	
	printf("\nstring 1 = %s\n", s1);
	printf("string 2 = %s\n", s2);
	char string_cat(char * s1, char * s2);	

	string_cat(s1, s2); 
	printf("New String = %s\n", s1);

	fflush(stdin);
//starts loop again	
	printf("Start loop again?\n");
	scanf("%s",loop);
		if (strlen(loop) == 3 && loop == "yes")
			goto start;
		else if (strlen(loop) == 2 && loop == "no")
			return 0;	
	
//			printf("string length = %i", strlen(loop));
//			printf("%s", loop);
	
		return 0;

}
//Concatenatation function
char string_cat(char * s1, char * s2)
{
	int i;
	int s1length = 0;
	int s2length = 0;
	for (s1length = 0; s1[s1length]; ++s1length);
	for (s2length = 0; s2[s2length]; ++s2length);
	
	
//if statements to determine if strings can be joined 	
	if ((s1length + s2length) < 80)
		for (i = 0; i < s2length; i++){
			s1[s1length - 1] = ' ';
			s2[0] = ' ';
			s1[(s1length - 1) + i] = s2[i];
		}
	else if ((s1length + s2length) > 80)
			 	;
	else
		return &s1[0];

		s1[(s1length + i) - 1] = '\0';
//prints the sum of the total length of the final concatenated string
	printf("Final String Length = %i\n", ((s1length + i) - 2));
}
	
