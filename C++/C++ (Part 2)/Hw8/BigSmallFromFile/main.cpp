/*
 Program: BigSmallFromFile
 Author: Michael Campbell
 Date: 5/4/11
 Synopsis: Chapter 12 Project 1
 HW 8
*/

#include <iostream>
#include <fstream>
#include <cstdlib>
#include <iomanip>
using namespace std;

int main ()
{

    ifstream fin;
    ofstream fout;
    int count = 0, big = 0, small = 0, next = 0;
    
    fin.open("C:\Users\NYUScps\Desktop\Numbers.txt");
    if (fin.fail()) {
        cerr << "Input file opening failed.\n";
        EXIT_FAILURE;
    }
    
        while (fin >> next) {
              if (next > big){
                       big = next;
              } else if (next < small)
                     small = next;
              }
              
              
        }
  //  fin.close();
    cout << "The largest number is " << big << endl;
    cout << "The smallest number is " << small << endl;
    
    system("PAUSE");
    return EXIT_SUCCESS;
}
