#include "Movie.h"

Movie::Movie(string title, int priceCode) {
    this->title = title;
    this->priceCode = priceCode;
}

int Movie::getPriceCode() {
    return priceCode;
}

void Movie::setPriceCode(int priceCode) {
    this->priceCode = priceCode;
}

string Movie:: getTitle() {
    return title;
}