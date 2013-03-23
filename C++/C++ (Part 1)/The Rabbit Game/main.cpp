#include <cstdlib>   //for the srand function and EXIT_SUCCESS
#include <ctime>     //for the time function

#include "terminal.h"
#include "wolf.h"
#include "rabbit.h"

using namespace std;

int main()
{
	srand(static_cast<unsigned>(time(0)));
	const terminal term('.');
	
	const unsigned xmax = term.xmax();
	const unsigned ymax = term.ymax();
	
	wolf   w(term, xmax * 1 / 3, ymax / 2);
	rabbit r(term, xmax * 2 / 3, ymax / 2);
	
	for (;; term.wait(250)) {   //250 milliseconds equals .25 seconds
		if (!w.move()) {
			break;
		}
		if (!r.move()) {
			break;
		}
	}
	
	term.put(0, 0, "You killed the rabbit!");
	term.wait(3000);     //Give user three seconds to read the message.
	return EXIT_SUCCESS; //Destruct rabbit, wolf, & terminal, in that order.
}
