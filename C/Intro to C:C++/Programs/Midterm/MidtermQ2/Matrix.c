/* Program; Matrix.c
 Author: Michael Campbell
 Date; 7/6/10
 Synopsis: Initializes each row of a 10 x 8 matrix with the value of the row,  
			prints the matrix,
			transpose the matrix into a second matrix (8 x 10), B[8][10], then prints out the new transposed matrix.
 */

#include <stdio.h>

int main (void)
{
	
//Initialize Variables
	int row;
	int column;
	int A[10][8] = {0};
	int B[8][10] = {0};

//Initialize array A	
	for (row = 0; row < 10; ++row)
		for (column = 0; column < 8; ++column)
			A[row][column] = row;
		
//Print Two dimensional Array 'A'	
	printf("\n");
	printf("Array A\n");
	printf("\n");

	for (row = 0; row < 10; ++row)
		for (column = 0; column < 8; ++column)
			printf("%5i", A[row][column]);
				printf("\n");
	printf("\n");
// Transpose Array 'A' to Array 'B' 
 	for (row = 0; row < 10; ++row)
		for (column = 0; column < 8; ++column)
			B[column][row] = A[row][column];
	
// Print Two dimenstional Array 'B'
	printf("\n");
	printf("Array B\n");
	printf("\n");
	
	for (row = 0; row < 8; ++row)
		for (column = 0; column < 10; ++column)
			printf("%5i", B[row][column]);
	printf("\n");
	
	return 0;
}
