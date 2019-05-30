#include "Account.h"

Account::Account(std::string name, double balance) :
    name{name}, balance{balance} {
}

bool Account::deposit(double ammount) {
    if (ammount < 0) {
        return false;
    } else {
        balance += ammount;
        return true;
    }
}

bool Account::withdraw(double ammount) {
    if (balance - ammount >= 0) {
        balance -= ammount;
        return true;
    } else {
        return false;
    }
}

double Account::getBalance() const {
    return balance;
}

std::ostream &operator<<(std::ostream &os, const Account &account) {
    os << "[Account: " << account.name << ": $" << account.balance << "]";
    return os;
}