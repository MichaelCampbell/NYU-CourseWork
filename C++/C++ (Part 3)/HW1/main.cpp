#include <iostream>
#include <cstdlib>
extern "C" {
#include "term.h"
}
using namespace std;

int main()
{
	term_construct();
	const unsigned xmax = term_xmax();
	const unsigned ymax = term_ymax();

	unsigned x = xmax / 2;   //center of screen
	unsigned y = ymax / 2;

	term_put(x, y, 'X');     //Draw XX at center of screen.
	char c = term_get(x, y);
	term_put(x + 1, y, c);

	term_puts(0, 0, "Please type printable characters ending with a q.");

	for (y = 1; y < ymax; ++y) {
		for (x = 0; x < xmax; ++x) {
			while ((c = term_key()) == '\0') {
			}

			if (c == 'q') {   //quit
				goto done;
			}

			term_put(x, y, c);  //Echo the character the user typed.
		}
	}

	done:;
	term_wait(1000);    //one full second
	term_beep();
	term_destruct();
	return EXIT_SUCCESS;
}
