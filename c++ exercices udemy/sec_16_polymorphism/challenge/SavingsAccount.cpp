#include "SavingsAccount.h"

SavingsAccount:: SavingsAccount(std::string name, double balance, double interestRate) :
    Account{name, balance}, interestRate{interestRate} {
}



bool SavingsAccount::deposit(double ammount) {
    ammount += ammount * (interestRate/100);
    return Account::deposit(ammount);
}

bool SavingsAccount::withdraw(double ammount) {
    return Account::withdraw(ammount);
}

void SavingsAccount::print(std::ostream &os) const {
    os << "[Savings Account: " << name << ": $" << balance << ", " << interestRate << "%]";
}