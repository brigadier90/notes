#include "IPrintable.h"
#include <iostream>

std::ostream &operator<<(std::ostream &os, const IPrintable &printable) {
    printable.print(os);
    return os;
};