#ifndef _MOVIES_H_
#define _MOVIES_H_
#include <vector>
#include <string>
#include "Movie.h"

class Movies {
    private:
        std::vector<Movie> movies;
    
    public:
                Movies();
                ~Movies();

        bool    addMovie(std::string name, int watched, std::string rating);
        bool    incrementWatched(std::string name);
        void display() const;


};

#endif