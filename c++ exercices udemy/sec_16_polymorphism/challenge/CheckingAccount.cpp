#include "CheckingAccount.h"

CheckingAccount::CheckingAccount(std::string name, double balance): 
    Account{name, balance} {
}

bool CheckingAccount::withdraw(double ammount) {
    ammount += defWithdrawalFee;
    return Account::withdraw(ammount);
}

bool CheckingAccount::deposit(double ammount) {
    return Account::deposit(ammount);
}

void CheckingAccount::print(std::ostream &os) const {
    os << "[Checking Account: " << name << ": $" << balance << "]";
}