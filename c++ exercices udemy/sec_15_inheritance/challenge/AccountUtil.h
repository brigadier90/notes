#ifndef _ACCOUNT_UTIL_H_
#define _ACCOUNT_UTIL_H_
#include <vector>
#include "Account.h"
#include "SavingsAccount.h"
#include "CheckingAccount.h"
#include "TrustAccount.h"

//Utility helper for Account class
void display(const std::vector<Account> &accounts);
void deposit(std::vector<Account> &accounts, double ammount);
void withdraw(std::vector<Account> &accounts, double ammount);

//Utility helper for SavingsAccount class
void display(const std::vector<SavingsAccount> &accounts);
void deposit(std::vector<SavingsAccount> &accounts, double ammount);
void withdraw(std::vector<SavingsAccount> &accounts, double ammount);

//Utility helper for CheckingAccount class
void display(const std::vector<CheckingAccount> &accounts);
void deposit(std::vector<CheckingAccount> &accounts, double ammount);
void withdraw(std::vector<CheckingAccount> &accounts, double ammount);

//Utility helper for TrustAccount class
void display(const std::vector<TrustAccount> &accounts);
void deposit(std::vector<TrustAccount> &accounts, double ammount);
void withdraw(std::vector<TrustAccount> &accounts, double ammount);



#endif