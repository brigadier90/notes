#ifndef _I_PRINTABLE_H_
#define _I_PRINTABLE_H_
#include <iostream>

class IPrintable {
    friend std::ostream &operator<<(std::ostream &os, const IPrintable &printable);

    public:
        virtual void print(std::ostream &os) const = 0;
        virtual ~IPrintable() = default;
};

#endif