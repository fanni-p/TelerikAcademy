using System;

namespace _14.Bank_account
{
    class BankAccount
    {
        static void Main()
        {
            string firstName = "Fani";
            string middleName = "Valentinova";
            string lastName = "Petkova";
            string holderName = firstName + " " + middleName + " " + lastName;
            decimal moneyBalance = 1765435.565M;
            string bankName = "United Bulgarian Bank";
            object IBAN = "BG84" +" "+ "UBBS" +" "+ 8002 +" "+ 4556 +" "+ 7657 +" "+ 20;
            string BIC = "UBBS BGSF";
            ulong card1 = 67696767111111897;
            ulong card2 = 67696767222222897;
            ulong card3 = 67696767333333897;
            Console.WriteLine("Name:{0}\nBalance:{1}\nBank Name:{2}\nIBAN:{3}\nBIC:{4}\nCreditCard1 Number:{5}\nCreditCard2 Number:{6}\nCreditCard3 Number:{7}",
                holderName,moneyBalance,bankName,IBAN,BIC,card1,card2,card3);
        }
    }
}
