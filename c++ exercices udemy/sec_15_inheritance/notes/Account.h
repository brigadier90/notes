#ifndef _ACCOUNT_H_
#define _ACCOUNT_H_
#include <iostream>

class Account {

    public:
        double balance;
        std::string name;

        Account();
        ~Account();

        void deposit(double ammount);
        void withdraw(double ammount);


};



#endif