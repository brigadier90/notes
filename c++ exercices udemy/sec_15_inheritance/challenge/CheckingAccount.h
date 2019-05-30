#ifndef _CHECKING_ACCOUNT_H_
#define _CHECKING_ACCOUNT_H_

#include "Account.h"

class CheckingAccount : public Account {
    friend std::ostream &operator<<(std::ostream &os, const CheckingAccount &account);
    private:
        static constexpr const char *defName = "Unnamed Savings Account";
        static constexpr double defBalance = 0.0;
        static constexpr double defWithdrawalFee = 1.5;
    public:
        CheckingAccount(std::string name = defName, double balance = defBalance);
        bool withdraw(double ammount);

};

#endif