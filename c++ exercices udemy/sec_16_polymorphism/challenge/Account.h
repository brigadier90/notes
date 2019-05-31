#ifndef _ACCOUNT_H_
#define _ACCOUNT_H_
#include <iostream>
#include <string>
#include "IPrintable.h"

class Account : public IPrintable{

    private:
        static constexpr const char *defName = "Unnamed Account";
        static constexpr double defBalance = 0.0;

    protected:
        std::string name;
        double balance;

    public:
        
        Account(std::string name = defName, double balance = defBalance);
        //virtual classes must implement virtual destructors for dynamic binding
        virtual ~Account() = default;

        virtual bool deposit(double ammount) = 0;
        virtual bool withdraw(double ammount) = 0;

        virtual void print(std::ostream &os) const override;


};



#endif