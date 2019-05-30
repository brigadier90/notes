#include "SavingsAccount.h"

SavingsAccount:: SavingsAccount(std::string name, double balance, double interestRate) :
    Account{name, balance}, interestRate{interestRate} {
}



bool SavingsAccount::deposit(double ammount) {
    ammount += ammount * (interestRate/100);
    return Account::deposit(ammount);
}

//if we use Account overloaded operator (which takes Account obj instead of SavingsAccount),
    //then the SavingsAccount being passed through will be sliced to an Account obj and we will
    //not be able to access account.insterestRate
std::ostream &operator<<(std::ostream &os, const SavingsAccount &account) {
    os << "[Savings Account: " << account.name << ": $" << account.balance << ", " << account.interestRate << "%]";
    return os;
}