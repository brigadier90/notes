#include <iostream>
#include <string>
#include <vector>
#include "Account.h"
#include "SavingsAccount.h"
#include "CheckingAccount.h"
#include "TrustAccount.h"
#include "AccountUtil.h"

using namespace std;
int main() {

    cout.precision(2);
    cout << fixed;
    
    //Accounts
    vector<Account> accounts;
    
    accounts.push_back(Account{});
    accounts.push_back(Account {"Ali", 100});
    accounts.push_back(Account {"Hassan", 500});
    accounts.push_back(Account {"Saad", 1000});

    display(accounts);
    deposit(accounts, 100);
    withdraw(accounts, 200);


    //Savings
    vector<SavingsAccount> savingsAccounts;
    
    savingsAccounts.push_back(SavingsAccount{});
    savingsAccounts.push_back(SavingsAccount {"Ali", 100});
    savingsAccounts.push_back(SavingsAccount {"Hassan", 500});
    savingsAccounts.push_back(SavingsAccount {"Saad", 1000});

    display(savingsAccounts);
    deposit(savingsAccounts, 100);
    withdraw(savingsAccounts, 200);

    //Checking
    vector<CheckingAccount> checkingAccounts;
    
    checkingAccounts.push_back(CheckingAccount{});
    checkingAccounts.push_back(CheckingAccount {"Ali", 100});
    checkingAccounts.push_back(CheckingAccount {"Hassan", 500});
    checkingAccounts.push_back(CheckingAccount {"Saad", 1000});

    display(checkingAccounts);
    deposit(checkingAccounts, 100);
    withdraw(checkingAccounts, 200);


    //Trust
    vector<TrustAccount> trustAccounts;
    
    trustAccounts.push_back(TrustAccount{});
    trustAccounts.push_back(TrustAccount {"Ali", 100, 2});
    trustAccounts.push_back(TrustAccount {"Hassan", 500, 5});
    trustAccounts.push_back(TrustAccount {"Saad", 1000, 10});

    display(trustAccounts);
    deposit(trustAccounts, 100);
    withdraw(trustAccounts, 200);
    withdraw(trustAccounts, 200);
    withdraw(trustAccounts, 200);
    withdraw(trustAccounts, 200);




    


    return 0;
}