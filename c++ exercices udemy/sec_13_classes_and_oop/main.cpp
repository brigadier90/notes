#include <iostream>
#include <string>
#include "Movie.h"
#include "Movies.h"

using namespace std;

int main() {

    Movies movies;

    movies.addMovie("LOTR", 12, "PG-13");
    movies.display();

    movies.incrementWatched("LOTR");
    movies.display();

    return 0;
}
