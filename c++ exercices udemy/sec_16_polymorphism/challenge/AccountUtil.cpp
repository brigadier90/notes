#include <iostream>
#include "AccountUtil.h"

//code duplication removed in next section
void display(const std::vector<Account *> &accounts) {
    std::cout << "\n===Accounts==================================================" <<std::endl;

    for (const auto &acc:accounts) {
        std::cout << *acc << std::endl;
    }
}
void deposit(std::vector<Account *> &accounts, double ammount) {
    std::cout << "\n===Depositing to Accounts====================================" <<std::endl;
    
    for (auto &acc:accounts) {

        if((*acc).deposit(ammount))   
            std::cout << "Deposited $" << ammount << " to " << *acc << std::endl;
        else
            std::cout << "Failed to deposit $" << ammount << " to " << *acc << std::endl;
        
    }
}
void withdraw(std::vector<Account *> &accounts, double ammount) {
    std::cout << "\n===Withdrawing from Accounts=================================" <<std::endl;
    
    for (auto &acc:accounts) {

        if((*acc).withdraw(ammount))   
            std::cout << "Withdrew $" << ammount << " from " << *acc << std::endl;
        else
            std::cout << "Failed to withdraw $" << ammount << " from " << *acc << std::endl;
        
    }
}