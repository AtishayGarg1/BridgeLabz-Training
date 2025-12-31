using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class Bank
    {
        public static string bankName = "Global Bank";
        string branchName = "Main Branch";
        string ifscCode = "GB0001";
        long contactNumber = 1234567890;
        string address = "123 Main St, City, Country";
        static string email = "globalbank@globalbank.com";
        static string website = "www.globalbank.com";
        public static int minimumBalance = 2000;
        static int maxDepositLimit = 100000;
        public static int maxWithdrawLimit = 50000;
        static int maxTransferLimit = 100000;
        long accountNumber;
        public int NumberOfTries = 3;


        public void DisplayBankDetails()
        {
            Console.WriteLine("Bank Name: "+bankName);
            Console.WriteLine("Branch Name: "+branchName);
            Console.WriteLine("IFSC Code: "+ifscCode);
            Console.WriteLine("Contact Number: "+contactNumber);
            Console.WriteLine("Address: "+address);
            Console.WriteLine("Email: "+email);
            Console.WriteLine("Website: "+website);
        }

        public long GetAccountNumber()
        {
            long accNumber = Random.Shared.NextInt64(1000000000, 9999999999);
            accountNumber = accNumber;
            return accountNumber;
        }

        void GetMaxWithdrawLimit()
        {
            Console.WriteLine("Enter Max Withdraw Limit");
            int withdrawLimit = Convert.ToInt32(Console.ReadLine());
            maxWithdrawLimit = withdrawLimit;
        }

        void GetMaxDepositLimit()
        {
            Console.WriteLine("Enter Max Deposit Limit");
            int depositLimit = Convert.ToInt32(Console.ReadLine());
            maxDepositLimit = depositLimit;
        }

        void GetMaxTransferLimit()
        {
            Console.WriteLine("Enter Max Transfer Limit");
            int transferLimit = Convert.ToInt32(Console.ReadLine());
            maxTransferLimit = transferLimit;
        }

        void GetMinimumBalance()
        {
            Console.WriteLine("Enter Minimum Balance");
            int minBalance = Convert.ToInt32(Console.ReadLine());
            minimumBalance = minBalance;
        }

        void GetWebsite()
        {
            Console.WriteLine("Enter Website");
            string website = Console.ReadLine();
            website = website;
        }

        void GetEmail()
        {
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            email = email;
        }

        void GetAddress()
        {
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            address = address;
        }

        void GetContactNumber()
        {
            Console.WriteLine("Enter Contact Number");
            long contactNumber = Convert.ToInt64(Console.ReadLine());
            contactNumber = contactNumber;
        }

        void GetIfscCode()
        {
            Console.WriteLine("Enter IFSC Code");
            string ifscCode = Console.ReadLine();
            ifscCode = ifscCode;
        }

        void GetBranchName()
        {
            Console.WriteLine("Enter Branch Name");
            string branchName = Console.ReadLine();
            branchName = branchName;
        }

        void GetBankName()
        {
            Console.WriteLine("Enter Bank Name");
            string bankName = Console.ReadLine();
            bankName = bankName;
        }
    }











    internal class Program
    {
        static bool sessionActive = true;
        static void Main(string[] args)
        {
            Bank bank = new();
            bank.DisplayBankDetails();
            while (true)
            {
                Console.WriteLine("\n\nWlcome to: " + Bank.bankName);
                Console.WriteLine("1. User");
                Console.WriteLine("2. Admin");
                Console.WriteLine("Enter your choice:");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        User user = new();
                        user.Execute();
                        break;
                    case 2:
                        Admin admin = new();
                        admin.Execute();
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        sessionActive = false;
                        break;
                }
            }
        }
    }









    internal class User
    {
        string userName = "User1234";
        long accountNumber = 00000000000001;
        int pin = 1234;
        string address = "Default Address";
        long contactNumber = 1234567890;
        string email = "Default Email";
        long balance = 0;
        long transactionAmount;
        long loanAmount;
        DateTime dob;
        int depositAmount;
        int withdrawAmountTotal;
        bool isActive = true;
        bool canUpdate = false;
        int userNumber = 0;

        Bank bank = new();




        public void Execute()
        {
            UserMenu();
        }


        bool UserLogin()
        {
            int loginTries = 0;
            while (loginTries < 3)
            {
                Console.WriteLine("\nEnter Pin To login");
                int enteredPin = int.TryParse(Console.ReadLine(), out enteredPin) ? enteredPin : 0;
                if (enteredPin != pin)
                {
                    loginTries++;
                    Console.WriteLine("Invalid Pin");
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        void UserMenu()
        {
            while (!UserLogin())
            {
                Console.WriteLine("Login Failed.");
                return;
            }
            while (isActive)
            {
                Console.WriteLine("\nUser Menu:");
                Console.WriteLine("0. Create new user");
                Console.WriteLine("1. Deposit Amount");
                Console.WriteLine("2. Withdraw Amount");
                Console.WriteLine("3. Update User Details");
                Console.WriteLine("4. Display User Details");
                Console.WriteLine("5. Delete account");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice:");
                int choice = int.TryParse(Console.ReadLine(), out choice) ? choice : 0;
                if (choice != 0 && userNumber == 0)
                {
                    Console.WriteLine("No user exists. Please create a user first.");
                    continue;
                }
                switch (choice)
                {
                    case 0:
                        CreateUser();
                        break;
                    case 1:
                        DepositAmount();
                        break;
                    case 2:
                        WithdrawAmount();
                        break;
                    case 3:
                        canUpdate = true;
                        UpdateUser();
                        break;
                    case 4:
                        DisplayUserDetails();
                        break;
                    case 5:
                        DeleteUser();
                        break;
                    case 6:
                        isActive = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        public void DeleteUser()
        {
            isActive = false;
            userName = "";
            accountNumber = 0;
            pin = 0;
            address = "";
            contactNumber = 0;
            email = "";
            balance = 0;


            Console.WriteLine("Account Deleted Successfully");
        }

        public void CreateUser()
        {
            Console.WriteLine("Enter User Name");
            userName = Console.ReadLine();
            accountNumber = bank.GetAccountNumber();
            Console.WriteLine("Enter PIN");
            pin = int.TryParse(Console.ReadLine(), out pin) ? pin : 0;
            Console.WriteLine("Enter Address");
            address = Console.ReadLine();
            Console.WriteLine("Enter DOB");
            dob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter Contact Number");
            contactNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Email");
            email = Console.ReadLine();
            balance = 0; // Initial balance set to 0
            while (balance == 0)
            {
                Console.WriteLine("To continue deposit Amount Ewual or More than minimum balance\nMinimum Balance: " + Bank.minimumBalance);
                DepositAmount();
            }
            isActive = true; // Account is active upon creation
            Console.WriteLine("Account Created Successfully");
            userNumber++;
        }


        public void UpdateUser()
        {
            while (canUpdate)
            {
                Console.WriteLine("\nEnter Pin to Update Details");
                int enteredPin = int.TryParse(Console.ReadLine(), out enteredPin) ? enteredPin : 0;
                if (enteredPin != pin)
                {
                    Console.WriteLine("Invalid Pin. Update Failed.");
                    return;
                }
                Console.WriteLine("\nUser Menu");
                Console.WriteLine("1. Update Address");
                Console.WriteLine("2. Update Contact Number");
                Console.WriteLine("3. Update Email");
                Console.WriteLine("4. Exit");
                int choice = int.TryParse(Console.ReadLine(), out choice) ? choice : 0;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter New Address");
                        address = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter New Contact Number");
                        contactNumber = long.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Enter New Email");
                        email = Console.ReadLine();
                        break;
                    case 4:
                        canUpdate = false;
                        Console.WriteLine("Exitting");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

        }


        void WithdrawAmount()
        {
            Console.WriteLine("You can withdraw: " + (Bank.maxWithdrawLimit - withdrawAmountTotal));
            Console.WriteLine("Enter Withdraw Amount");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            if (withdrawAmount > balance)
            {
                Console.WriteLine("Insufficient Balance.");
                return;
            }
            if (balance - withdrawAmount < Bank.minimumBalance)
            {
                Console.WriteLine("Balance less than Required minimum balance\n\nDeposit Money to Avoid Penalty Charges");
            }
            Console.WriteLine("Enter Pin");
            int enteredPin = int.TryParse(Console.ReadLine(), out enteredPin) ? enteredPin : 0;
            if (enteredPin != pin)
            {
                Console.WriteLine("Invalid Pin. Transaction Failed.");
                return;
            }
            withdrawAmountTotal += withdrawAmount;
            if (withdrawAmountTotal > Bank.maxWithdrawLimit)
            {
                Console.WriteLine("Withdraw limit exceeded. Transaction Failed.");
                withdrawAmountTotal -= withdrawAmount;
                return;
            }
            balance -= withdrawAmount;
            Console.WriteLine("Amount " + withdrawAmount + " withdrawn successfully. New Balance: " + balance);
        }

        void DepositAmount()
        {

            Console.WriteLine("Enter Deposit Amount");
            depositAmount = Convert.ToInt32(Console.ReadLine());
            if (balance + depositAmount < Bank.minimumBalance)
            {
                Console.WriteLine("Deposit Amount must be greater than minimum balance.");
                return;
            }
            Console.WriteLine("Enter Pin");
            int enteredPin = int.TryParse(Console.ReadLine(), out enteredPin) ? enteredPin : 0;
            if (enteredPin != pin)
            {
                Console.WriteLine("Invalid Pin. Transaction Failed.");
                return;
            }
            balance += depositAmount;
            Console.WriteLine("Amount " + depositAmount + " deposited successfully. New Balance: " + balance);
        }


        public void DisplayUserDetails()
        {
            Console.WriteLine("User Details:");
            Console.WriteLine("User Name: " + userName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Contact Number: " + contactNumber);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("Account Active: " + isActive);
        }
    }





    internal class Admin
    {
        string adminName = "Admin";
        int adminID = 12345678;
        int adminPassword = 5678;
        long adminContactNumber = 1234567890;
        string adminEmail = "Default admin email";
        User user = new();
        bool isActive = true;
        bool operationSession = false;


        public void Execute()
        {
            CreateAdmin();
            AdminMenu();
        }

        bool LoginAdmin()
        {
            int loginTries = 0;
            while (loginTries < 3)
            {
                Console.WriteLine("\nEnter Pin To login");
                int pin = int.TryParse(Console.ReadLine(), out pin) ? pin : 0;
                if (pin != adminPassword)
                {
                    loginTries++;
                    Console.WriteLine("Invalid Pin");
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        void AdminMenu()
        {
            if (!LoginAdmin())
            {
                return;
            }
            while (isActive)
            {
                Console.WriteLine("\nLogin Successful\n");
                Console.WriteLine("Admin Menu:");
                Console.WriteLine("1. Admin Operations");
                Console.WriteLine("2. Exit");
                Console.WriteLine("Enter your choice:");
                int choice = int.TryParse(Console.ReadLine(), out choice) ? choice : 0;
                switch (choice)
                {

                    case 1:
                        operationSession = true;
                        AdminOperations();
                        break;
                    case 2:
                        Console.WriteLine("Exiting Admin Menu");
                        isActive = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }

        public void CreateAdmin()
        {
            Console.WriteLine("Enter Admin Name");
            adminName = Console.ReadLine();
            Console.WriteLine("Enter Admin ID");
            adminID = int.TryParse(Console.ReadLine(), out adminID) ? adminID : 0;
            Console.WriteLine("Enter Admin Pin");
            adminPassword = int.TryParse(Console.ReadLine(), out adminPassword) ? adminPassword : 0;
            Console.WriteLine("Enter Contact Number");
            adminContactNumber = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Email");
            adminEmail = Console.ReadLine();
            Console.WriteLine("Admin Created Successfully");
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

        }

        void DisplayAdminDetails()
        {
            Console.WriteLine("Enter Admin Pin to View Details");
            int pin = int.TryParse(Console.ReadLine(), out pin) ? pin : 0;
            if (pin != adminPassword)
            {
                Console.WriteLine("Invalid Pin");
                return;
            }
            Console.WriteLine("Admin Details:");
            Console.WriteLine("Name: " + adminName);
            Console.WriteLine("ID: " + adminID);
            Console.WriteLine("Contact Number: " + adminContactNumber);
            Console.WriteLine("Email: " + adminEmail);
        }

        void UpdateAdmin()
        {
            Console.WriteLine("Enter Admin Pin to Update Details");
            int pin = int.TryParse(Console.ReadLine(), out pin) ? pin : 0;
            if (pin != adminPassword)
            {
                Console.WriteLine("Invalid Pin");
                return;
            }
            Console.WriteLine("Admin Menu: ");
            Console.WriteLine("1. Update Name");
            Console.WriteLine("2. Update Contact Number");
            Console.WriteLine("3. Update Email");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Enter your choice");
            int choice = int.TryParse(Console.ReadLine(), out choice) ? choice : 0;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter New Admin Name");
                    adminName = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter New Contact Number");
                    adminContactNumber = long.Parse(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("Enter New Email");
                    adminEmail = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Exiting admin operations");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
        void AdminOperations()
        {
            while (operationSession)
            {
                Console.WriteLine("\n\nAdmin Operations:");
                Console.WriteLine("1. Display Admin Details");
                Console.WriteLine("2. Update Admin Details");
                Console.WriteLine("3. Create User");
                Console.WriteLine("4. Update User");
                Console.WriteLine("5. Delete User");
                Console.WriteLine("6. Display User");
                Console.WriteLine("9. Exit");
                Console.WriteLine("Enter your choice:");
                int choice = int.TryParse(Console.ReadLine(), out choice) ? choice : 0;
                switch (choice)
                {
                    case 1:
                        DisplayAdminDetails();
                        break;
                    case 2:
                        UpdateAdmin();
                        break;
                    case 3:
                        user.CreateUser();
                        break;
                    case 4:
                        user.UpdateUser();
                        break;
                    case 5:
                        user.DeleteUser();
                        break;
                    case 6:
                        user.DisplayUserDetails();
                        break;
                    case 9:
                        Console.WriteLine("Exiting Admin Operations");
                        operationSession = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

        }
    }
}
