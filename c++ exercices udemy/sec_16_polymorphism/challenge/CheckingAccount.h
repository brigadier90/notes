#ifndef _CHECKING_ACCOUNT_H_
#define _CHECKING_ACCOUNT_H_

#include "Account.h"

class CheckingAccount : public Account {

    private:
        static constexpr const char *defName = "Unnamed Savings Account";
        static constexpr double defBalance = 0.0;
        static constexpr double defWithdrawalFee = 1.5;
    public:
        CheckingAccount(std::string name = defName, double balance = defBalance);
        virtual ~CheckingAccount() = default;
        virtual bool withdraw(double ammount) override;
        virtual bool deposit(double ammount) override;

        virtual void print(std::ostream &os) const override;

        

};

#endif