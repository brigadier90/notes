#include "Account.h"

Account::Account() :
    balance{0.0}, name{"An Account"} {

}

Account::~Account() {

}

void Account::deposit(double ammount) {
    balance += ammount;
    std::cout << "depositing into Account amount: $" << balance << std::endl;
}

void Account::withdraw(double ammount) {
    balance -= ammount;
    std::cout << "Withdraeing from Account amount: $" << balance << std::endl;
}