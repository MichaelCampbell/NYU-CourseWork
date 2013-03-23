#include <iostream>
#include <string>
using namespace std;

int main () {

	string user[10];
	
	const size_t n = sizeof user / sizeof user[0];
	
	cout << "\nPlease type in 10 words.\n";
	for (size_t i = 0; i < n; ++i) {
				cin >> user[i];			
	}
		cout << "\nYou Typed: \"";
	for (size_t j = 0; j < n; ++j) {
		cout << user[j] << " ";
	}

	cout << "\"\n\n";	
	
	cout << "Here's what you said backwards: \"";
	for (size_t j = n - 1;; --j) {
		cout << user[j] << " ";
		if (j == 0) {
			break;
		}
	}
	
	cout << "\"\n\n";	

	cout << "Here's the last 5 words first, then the first 5 words: \n\"";
	for (size_t j = n / 2; j < n; ++j) {
		cout << user[j] << " ";
	}
	
	cout << ", ";
	
	for (size_t j = 0; j < n / 2; ++j) {
		cout << user[j] << " ";
	}
	cout << "\"\n\n";	
	
	cout << "Here's what you said, forwards then backwards: \n\"";
	for (size_t j = 0; j < n; ++j) {
		cout << user[j] << " ";
	}
	
	for (size_t j = n - 2;; --j) {
		cout << user[j] << " ";
		if (j == 0) {
			break;
		}
	}
	cout << "\"\n\n";	
	
    return EXIT_SUCCESS;
}
