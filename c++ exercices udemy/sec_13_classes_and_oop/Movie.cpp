
#include "Movie.h"
#include <iostream>
#include <string>

using namespace std;

//constructor
Movie::Movie(std::string name, int watched, std::string rating):
    name(name), watched(watched), rating(rating) {

}

//copy constructor
Movie::Movie(const Movie &source) :
    Movie(source.name, source.watched, source.rating){

}

//destructor
Movie::~Movie() {

}

std::string Movie::getName() {
    return this->name;
}

std::string Movie::getRating() {
    return this->rating;
}

int Movie::getWatched() {
    return this->watched;
} 

void Movie::setName(std::string name) {
    this->name = name;
} 

void Movie::setRating(std::string rating) {
    this->rating = rating;
}

void Movie::setWatched(int watched) {
    this->watched = watched;
}

void Movie::display() const {
    cout    << "Name: " 
            << this->name 
            << ", Rating: " 
            << this->rating 
            << ", watched: " 
            << this->watched 
            << endl;
}