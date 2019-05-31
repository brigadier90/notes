#ifndef _ACCOUNT_UTIL_H_
#define _ACCOUNT_UTIL_H_
#include <vector>
#include "Account.h"
#include "SavingsAccount.h"
#include "CheckingAccount.h"
#include "TrustAccount.h"

//Utility helper for Account class
void display(const std::vector<Account *> &accounts);
void deposit(std::vector<Account *> &accounts, double ammount);
void withdraw(std::vector<Account *> &accounts, double ammount);


#endif