#ifndef _SAVINGS_ACCOUNT_H_
#define _SAVINGS_ACCOUNT_H_
#include "Account.h"
#include <iostream>


//withdraw same as account therefore we do not override

class SavingsAccount : public Account {

    private:
        static constexpr const char *defName = "Unnamed Savings Account";
        static constexpr double defBalance = 0.0;
        static constexpr double defInterestRate = 0.0;
    protected:
        double interestRate;
    public:

        SavingsAccount(std::string name = defName, double balance = defBalance, double interestRate = defInterestRate);
        virtual ~SavingsAccount() = default;
        virtual bool deposit(double ammount) override;
        virtual bool withdraw(double ammount) override;

        virtual void print(std::ostream &os) const override;

        
};


#endif