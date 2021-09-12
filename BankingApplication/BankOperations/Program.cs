using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOperations
{
    class Program
    {
       static Dictionary<int, Account> allCustomerDetails = new Dictionary<int, Account>();

        static void Main(string[] args)
        {
            int result;
            //int age;
            string accno;
            int ch =0;

            Account acc = new Account();

            do
            {
                Console.WriteLine("\n-------------");
                Console.WriteLine("1.New Account\t2.Enquiry\t3.Deposit\t4.Withdrawal\t5.Exit");
                Console.WriteLine("---------------");
                ch =int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        result = createAcc();
                        if (result != 0)
                            Console.WriteLine("Your Account Number \"{0}\" created", result);
                        else
                            Console.WriteLine("Account could not be created. Please reach to help desk.");
                        break;

                    case 2:
                        Console.WriteLine("Enter the Account Number: \t");
                        accno = Console.ReadLine();
                        //acc.accAvailability(accno);
                        break;

                    case 3:
                        Console.WriteLine("Enter the Account Number:\t");
                        accno = Console.ReadLine();
                        // acc.accDeposit(accno);
                        break;

                    case 4:

                        Console.Write("Enter The Customer Account Number:  ");
                        accno = Console.ReadLine();
                        //acc.accWithdraw(accno);
                        break;

                    case 5:
                        Console.Write("Closing the Banking Application...");
                        // System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("invalid choice!");
                        break;
                }

            } while (ch < 4);

          

        }
        public static int createAcc()
        {
            int newAccountNumber = 0;
            Account accno = new Account();
            try
            {
                Console.WriteLine("\nEnter the Customer Name");
                accno.cName = Console.ReadLine();
                if (accno.cName == "")
                    Console.WriteLine("Please enter the Name");

                Console.WriteLine("Enter the Customer Age");
              accno.cAge = int.Parse(Console.ReadLine());

                if (accno.cAge <= 0)
                    Console.WriteLine("Enter the Age");
                Console.WriteLine("\nEnter the PAN Card");
                accno.cPANCard = Console.ReadLine();

                if (accno.cPANCard == null)
                {
                    Console.WriteLine("Enter the Valid PAN card Number");
                }

                if(allCustomerDetails.Count()==0)
                {
                    newAccountNumber = 1;
                    allCustomerDetails.Add(newAccountNumber, accno);
                }
                else
                {
                    int lastAccountNumber = allCustomerDetails.Keys.Last();
                    newAccountNumber = lastAccountNumber + 1;

                    if (!allCustomerDetails.ContainsKey(newAccountNumber))
                    {
                        allCustomerDetails.Add(newAccountNumber, accno);
                    }
                    else
                    {
                        newAccountNumber = 0;
                    }
                }
                

               
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return newAccountNumber;
        }
        //public static void accAvailability()
        //{
        //    if (accno.Equals(accno))
        //    {
        //        Console.WriteLine("\n------------");
        //        Console.WriteLine("Account Number:" + accno);
        //        Console.WriteLine("Name:" + cname);
        //        Console.WriteLine("Age:" + cage);
        //        Console.WriteLine("Address:" + cadd);
        //        Console.WriteLine("Balance:" + Bal);
        //    }
        //    else
        //        Console.WriteLine("Account doesnot exist");
        //}
        //public static void accDeposit()
        //{
        //    if (accno.Equals(accno))

        //    {
        //        Console.Write("Enter the Amount:\t\t");

        //        int Amount = int.Parse(Console.ReadLine());
        //        if (Amount <= 0)
        //            throw new Exception("Amount must be larger than $0");
        //        else
        //            this.Bal = Bal + Amount;

        //        Console.WriteLine("-----------------------------");
        //        Console.WriteLine("Balance is:" + Bal);
        //        Console.WriteLine("-----------------------------");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Account does not exist!");
        //    }
        //}
        //public static void accWithdraw()
        //{
        //    if (accno.Equals(accno))

        //    {
        //        Console.Write("Enter the amount:\t\t");
        //        int Amount = int.Parse(Console.ReadLine());
        //        if (Bal == 0)
        //        {
        //            Console.WriteLine("Insufficient balance");

        //        }
        //        else if (Amount > Bal)
        //        {
        //            Console.WriteLine("Insufficient balance");
        //        }
        //        else
        //        {
        //            Bal = Bal - Amount;
        //            Console.WriteLine("Balance: $" + Bal);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Account does not exist!");
        //    }
        //}
        //public static void Balenquiry()
        //{
        //    Console.WriteLine("Your baance is: " + Bal);
        //}
    }
}







