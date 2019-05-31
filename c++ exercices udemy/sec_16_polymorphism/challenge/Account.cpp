#include "Account.h"

//keep the constructor because we will still be calling it from derived classes
Account::Account(std::string name, double balance) :
    name{name}, balance{balance} {
}

//we will keep this implemented since it makes sense. simple deposit common to all subclasses
bool Account::deposit(double ammount) {
    if (ammount < 0) {
        return false;
    } else {
        balance += ammount;
        return true;
    }
}
//we will keep this implemented since it makes sense. simple withdrawal common to all subclasses
bool Account::withdraw(double ammount) {
    if (balance - ammount >= 0) {
        balance -= ammount;
        return true;
    } else {
        return false;
    }
}


void Account::print(std::ostream &os) const {
    os << "[Account: " << name << ": $" << balance << "]";
}