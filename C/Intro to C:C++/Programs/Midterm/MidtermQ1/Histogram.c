/* Program; Histogram.c
 Author: Michael Campbell
 Date; 7/6/10
 Synopsis: Using a character array of 32 grades, compute a histogram for each of the six possible grades (held in histogram array) 
 using switch statement structure
 */

#include <stdio.h>
#include <ctype.h>

int main (void) 
{
//Initialize Variables
	int i;
	char grade[32] = { 'A', 'B', 'C', 'D', 'f', 'I', \
					   'b', 'C', 'd', 'F', 'I', 'a', \
					   'C', 'D', 'F', 'I', 'A', 'B', \
					   'D', 'F', 'I', 'A', 'B', 'c', \
					   'I' , 'D', 'F', 'F', 'A', 'B',\
					   'a', 'b'};
	int hist_grade[6] = {0};
    
//For Loop To walk Through the grade array
	for (i = 0; i < 32; ++i) {
//If statement to convert lowercase to uppercase
		if (islower(grade[i])) 
			grade[i]=toupper(grade[i]);


	

//Switch Statements		
		switch (grade[i]) {
			case 'A':
				++hist_grade[0];
				break;
			case 'B':
				++hist_grade[1];
				break;
			case 'C':
				++hist_grade[2];
				break;			
			case 'D':
				++hist_grade[3];
				break;			
			case 'F':
				++hist_grade[4];
				break;			
			case 'I':
				++hist_grade[5];
				break;			
		}
	}
	
//Print Histogram
printf("A\tB\tC\tD\tF\tI\t\n");
	for (i = 0; i < 6; i++){
		hist_grade[i];
		printf("%i\t", hist_grade[i]);
	}	
	return 0;
}
