#include <stdio.h>

int main (void) 
{
	char removeString (char text[], int start, int length);
	char text[] = "the wrong song";
    printf("%c\n", removeString(text, 4, 6));
    return 0;
}

char removeString (char text[], int start, int length)
{
	int i = 0, j = 0;
	int total = start + length;
	char result[100];
	
	for (i = 0; i < start; i++)
		result[i] = text[i];

	for (j = 0; text[j] != '\0'; ++j)
		result[i + j] = text[j + total];

	result[i + j] = '\0';
	
	printf("\n%s", result);

}