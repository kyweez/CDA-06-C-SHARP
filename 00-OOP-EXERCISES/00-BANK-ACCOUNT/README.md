# Bank account

A (simplified) bank account is characterized by:
* an unique number
* the name of its owner
* his balance (amount remaining on the account): it can be negative
* the amount of authorized overdraft : the balance does not can go below.

We give this class the behaviors
* Give a text message representation of all its information
* credit an amount provided
* debit the balance from an amount provided, but be careful "flag" (booleen) will indicate if the operation could be carried out
* transfer an amount from the current account to another account; same remark as for the previous paragraph.
* compare the balance of the current object with the balance of another account provided, the result will be a boolean
