#include "TrustAccount.h"

TrustAccount::TrustAccount(std::string name, double balance, double interestRate) :
    SavingsAccount{name, balance, interestRate}, numWihtdrawals{0} {
}

bool TrustAccount::deposit(double ammount) {
    if (ammount >= bonusThershold)
        ammount += bonusAmmount;
    
    return Account::deposit(ammount);
}

bool TrustAccount::withdraw(double ammount) {
    
    if (ammount > (maxWithdrawPercent * balance)) 
        return false;
    
    if (numWihtdrawals > maxWithdrawals)
        return false;
    
    numWihtdrawals++;
    
    return SavingsAccount::withdraw(ammount);
    
    
}


std::ostream &operator<<(std::ostream &os, const TrustAccount &account) {
    os << "[Trust Account: " << account.name << ": $" << account.balance << ", " << account.interestRate;
    os << "%, withdrawals: " <<  account.numWihtdrawals <<  "]";
    return os;
}

