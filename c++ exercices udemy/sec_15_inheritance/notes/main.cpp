#include <string>
#include "Account.h"
#include "SavingsAccount.h"

int main() {


    Account acc;

    acc.deposit(500);

    SavingsAccount sav_acc;
    sav_acc.deposit(200);
    sav_acc.withdraw(100);

    return 0;
}