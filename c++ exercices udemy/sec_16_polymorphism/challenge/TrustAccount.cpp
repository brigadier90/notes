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


void TrustAccount::print(std::ostream &os) const {
    os << "[Trust Account: " << name << ": $" << balance << ", " << interestRate;
    os << "%, withdrawals: " <<  numWihtdrawals <<  "]";
}

