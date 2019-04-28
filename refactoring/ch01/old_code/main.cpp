#include <iostream>
#include <string>
#include "Movie.h"


using namespace std;



int main() {
    string name = "LOTR";
    Movie *m = new Movie(name, 0);

    cout << "Movie Name: " << m->getTitle() << endl;
    return 0;
}
