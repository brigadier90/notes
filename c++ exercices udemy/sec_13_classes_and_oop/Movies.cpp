#include "Movies.h"

#include <iostream>

Movies::Movies() {

}

Movies::~Movies() {
    
}

bool Movies::addMovie(std::string name, int watched, std::string rating) {

    for (int i = 0; i < this->movies.size(); i++) {
        if (movies.at(i).getName() == name) {
            return false;
        }
    }
    
    movies.push_back(Movie(name, watched, rating));
    return true;

}

bool Movies::incrementWatched(std::string name) {
    

    for (int i = 0; i < this->movies.size(); i++) {
        if (movies.at(i).getName() == name) {
            movies.at(i).incrementWatched();
            return true;
        }
    }

    return false;

}

void Movies::display() const {
    for (int i = 0; i < this->movies.size(); i++) {
        movies.at(i).display();
    }
}