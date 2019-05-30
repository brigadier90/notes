#ifndef _SAVINGS_ACCOUNT_H_
#define _SAVINGS_ACCOUNT_H_
#include "Account.h"
#include <iostream>


//withdraw same as account therefore we do not override

class SavingsAccount : public Account {

    //if we use Account overloaded operator (which takes Account obj instead of SavingsAccount),
    //then the SavingsAccount being passed through will be sliced to an Account obj and we will
    //not be able to access account.insterestRate
    friend std::ostream &operator<<(std::ostream &os, const SavingsAccount &account);

    private:
        static constexpr const char *defName = "Unnamed Savings Account";
        static constexpr double defBalance = 0.0;
        static constexpr double defInterestRate = 0.0;
    protected:
        double interestRate;
    public:

        SavingsAccount(std::string name = defName, double balance = defBalance, double interestRate = defInterestRate);
        bool deposit(double ammount);

        
};


#endif