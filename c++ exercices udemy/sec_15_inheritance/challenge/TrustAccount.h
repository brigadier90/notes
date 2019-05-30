#ifndef _TRUST_ACCOUNT_H_
#define _TRUST_ACCOUNT_H_

#include "SavingsAccount.h"

class TrustAccount : public SavingsAccount {

        friend std::ostream &operator<<(std::ostream &os, const TrustAccount &account);
    private:
        static constexpr const char *defName = "Unnamed Savings Account";
        static constexpr double defBalance = 0.0;
        static constexpr double defInterestRate = 0.0;
        static constexpr double bonusAmmount = 50.0;
        static constexpr double bonusThershold = 5000.0;
        static constexpr int maxWithdrawals = 3;
        static constexpr double maxWithdrawPercent = 0.2;
        int numWihtdrawals;
    public:
        TrustAccount(std::string name = defName, double balance = defBalance, double interestRate = defInterestRate);

        //deposit of 5000 or more will give bonus 50
        bool deposit(double ammount);

        //max 3 withdrawals, each can be a maximum of 20% of account's value
        bool withdraw(double ammount);

};

#endif