#include <string>

using namespace std;

class Movie {

    #define CHILDRENS = 2;
    #define REGULAR = 0; 
    #define NEW_RELEASE = 1;

    private:
        string  title;
        int     priceCode;

    public:
                Movie(string title, int priceCode);
        int     getPriceCode();
        void    setPriceCode(int priceCode);
        string  getTitle();
                ~Movie();

};
