#include <iostream>
#include <cstdlib>
#include <ctime>   //for time_t, time, tm, localtime
#include <climits> //for INT_MAX
using namespace std;

int main()
{
	const int length[] = {
		0,   //dummy element so that January will have subscript 1
		31,   //January
		28,   //February
		31,   //March
		30,   //April
		31,   //May
		30,   //June
		31,   //July
		31,   //August
		30,   //September
		31,   //October
		30,   //November
		31    //December
	};
	
	const time_t t = time(0);	//Get the current date.
	if (t == -1) {
		cerr << "time failed\n";
		return EXIT_FAILURE;
	}
	const tm *const p = localtime(&t);
	
	int year = p->tm_year + 1900;
	int month = p->tm_mon + 1;
	int day = p->tm_mday;
	
	cout << "How many days back or forward do you want to go from today? "
	<< month << "/" << day << "/" << year << "? ";
	int distance;	//uninitialized variable
	cin >> distance;

//Break distance into years and days (part 1)
	int years = distance / 365;
	int days = distance % 365;
	
		//cout << days;
	
//if distance is negative (part 2)
	if (days < 0) {
		days += 365;
		--years;
	}
	year += years;
	day += days;
				
	/*
	 Walk distance days into the future.
	 "continue" means to abandon this iteration of the loop,
	 and go straight back up to the ++i and i < distance
	 to begin the next iteration of the loop.
	 */
	//for (int i = 0; i < days; ++i) {
	//	if (day < length[month]) {
	//		++day;
	//		continue;
	//	}
		
		//day = 1;
	
//go through rest of loop one month at a time (part 3)	
	while (day > length[month]){
		day -= length[month];
	//	if (day == 0) {
	//		day = 1;
	//	}
		if (month < 12) {
			++month;
			continue;
		}
		
		month = 1;
		if (year < INT_MAX) {
			++year;
			continue;
		}
		
		cerr << "Can't go beyond year " << INT_MAX << "\n";
		return EXIT_FAILURE;
	}
	
	cout << "The new date is "
	<< month << "/" << day << "/" << year << ".\n";
	
	return EXIT_SUCCESS;
}