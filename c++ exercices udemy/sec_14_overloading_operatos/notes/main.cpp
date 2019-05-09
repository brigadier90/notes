#include <iostream>
#include "MyString.h"

using namespace std;

int main () {
    
    // //code that will call copy ctor if move does not exist
    // //if move exists gores straight to move since rhs is r-value ref
    // //also is = operator overloaded will just call that - move before copy since we have r-value here
    // MyString s = MyString("Hello");



    // //code that will call = operator (copy version if no move version implemented)
    // MyString s = MyString("Hello, world");
    // MyString x {"Hi, there"};

    // //here copy will be called even if move id defined since we do not have an r-value on the rhs
    // s = x;

    
    
    // cout << "s: value is \""<< s.getStr() << "\"" << endl; 

    // //overloaded operators as member methods: +, ==, and -
    // MyString larry{"LARRY"};
    // MyString larryLower = -larry;

    // larryLower.display();

    // MyString moe{"Moe"};
    // MyString conc = larryLower + moe;

    // conc.display();

    // MyString conc2 = moe + "Larry"; //doable since we have an overloaded ctor which takes a c string
    
    // //error since lhs must be mystring. no such thing as "Larry".operator+(moe)
    // //MyString conc3 = "Larry" + moe; 

    //overloading operators as global functions - stream insertion operators only
    MyString larry {"Larry"};
    MyString moe {"Moe"};
    MyString curly;

    cout << "Enter the third stooge's first name: ";
    cin >> curly;

    cout << "the 3 stooges are " << larry << ", " << moe << " and" << curly << endl;
    cout << "Enter the 3 stooges' names seperated by string: ";

    cin >> larry >> moe >> curly;

    cout << "the 3 stooges are " << larry << ", " << moe << " and" << curly << endl;

    return 0;

}