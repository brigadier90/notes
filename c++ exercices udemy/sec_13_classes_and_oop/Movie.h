#ifndef _MOVIE_H_
#define _MOVIE_H_
#include <iostream>

class Movie {
    private:
        std::string  name;
        int     watched;
        std::string  rating;
    public:
        //constructor
                Movie(std::string name, int watched, std::string rating);
        //copy constructor
                Movie(const Movie &source);
        //destructor
                ~Movie();

        std::string  getName();
        int     getWatched();
        std::string  getRating();

        void    setName(std::string name);
        void    setWatched(int watched);
        void    setRating(std::string rating);

        //increment watched
        void    incrementWatched() {watched++;};
        void    display() const;


};
#endif