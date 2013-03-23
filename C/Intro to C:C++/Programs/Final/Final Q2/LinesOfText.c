/* 
 Program: linesOfText.c
 Author: Michael Campbell
 Date: 7/20/10
 Synopsis: this program sequentially collects lines of text from the keyboard using the fgets function, asking the
 user for a new text line.
 -              the query can be exited through the input of the # character or after exceeding 40 lines of text
 -              lines of text are stored in the heap through malloc
 -              the number of bytes needed for each line should be obtained through the string length function
 -              the pointer returned from malloc should be stored in a character pointer array
 -              after collecting all the lines, the program should print them all
 -              delete the 5th and 6th lines of text and move them to the end of the document, 
 after moving the 5th and 6th lines all lines of text should be printed again.
 -              the lines of text should be sorted alphabetically and printed again.
 
 */
#include <stdlib.h>
#include <stdio.h>
#include <string.h>

int main (void) {
	
	char buffer[80];
	int len = 80;
	int i;
	int *line_array[80];
	char strings[80];
	int stringlength = 0;
//	int strlencount = 0; 
	stringlength = strlen(&strings[i]);

//	do {
//		printf ("\nPlease enter the next line of text\n");
//		fgets(&buffer[0] + 1, len, stdin);
//	}
//	while (i < 40 && buffer[i] != '#'); {
//		i++;
//	}

	for (i = 0; i < 40 || buffer[i] == '#'; i++){
			printf ("\nPlease enter the next line of text\n");
			strings[i] = fgets(&buffer[0] + stringlength +i, len, stdin);
//			printf("string was: %s", &buffer[i]);	
			line_array[i] = (int *)malloc (stringlength * sizeof(strings[i]));
			if (buffer[i] == '#')
//				for (i; i = 0; i--) {
//					strlencount++;
					goto exit_loop;
				}
//	}
exit_loop:	
	line_array[i] = (int *)malloc (stringlength * sizeof(char));

	
//print all lines of text
	printf("The strings were: %s\n\n", &buffer[0]);
	
// move 5th and 6th lines of text to the end of document	
	line_array[4] = line_array[i + 1];
	line_array[4] = '\0';
	line_array[5] = line_array[i + 1];
	line_array[5] = '\0';

	printf("The new order is: %s\n\n", &buffer[0]);
	
	return 0;
}