#include "CheckingAccount.h"

CheckingAccount::CheckingAccount(std::string name, double balance): 
    Account{name, balance} {
}

bool CheckingAccount::withdraw(double ammount) {
    ammount += defWithdrawalFee;
    return Account::withdraw(ammount);
}

std::ostream &operator<<(std::ostream &os, const CheckingAccount &account) {
    os << "[Checking Account: " << account.name << ": $" << account.balance << "]";
    return os;
}