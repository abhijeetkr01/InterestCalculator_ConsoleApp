using System;

namespace TM05
{
    interface Account
    {
        void calculateInterest();
    }

    public class InvalidEntryException : Exception
    {
        public InvalidEntryException(string message): base(message)
        { }
    }

    abstract class FDAccount : Account
    {
        protected double Interest_rate;
        protected double Amount;
        protected int No_of_days;
        protected int Age;

        public abstract void calculateInterest();
    }

    class FD : FDAccount
    {
        public FD()
        {
            int i=0;
            Console.WriteLine("Enter the FD amount:");
            bool Amt = Double.TryParse(Console.ReadLine(),out Amount);
            Console.WriteLine("Enter the number of days:");
            bool days = int.TryParse(Console.ReadLine(), out No_of_days);
            Console.WriteLine("Enter your Age:");
            bool age = int.TryParse(Console.ReadLine(),out Age);

            if (Amount<10000000)
            {
                if (Age>=60)
                {
                    if(No_of_days>=7 && No_of_days<=14)
                    {
                        Interest_rate = 5.00;
                    }
                    else if (No_of_days >= 15 && No_of_days <= 29)
                    {
                        Interest_rate = 5.25;
                    }
                    else if (No_of_days >= 30 && No_of_days <= 45)
                    {
                        Interest_rate = 6.00;
                    }
                    else if (No_of_days >= 45 && No_of_days <= 60)
                    {
                        Interest_rate = 7.50;
                    }
                    else if (No_of_days >= 61 && No_of_days <= 184)
                    {
                        Interest_rate = 8.00;
                    }
                    else if (No_of_days >= 185 && No_of_days <= 365)
                    {
                        Interest_rate = 8.50;
                    }
                }
                else if(Age<60)
                {
                    if (No_of_days >= 7 && No_of_days <= 14)
                    {
                        Interest_rate = 4.50;
                    }
                    else if (No_of_days >= 15 && No_of_days <= 29)
                    {
                        Interest_rate = 4.75;
                    }
                    else if (No_of_days >= 30 && No_of_days <= 45)
                    {
                        Interest_rate = 5.50;
                    }
                    else if (No_of_days >= 46 && No_of_days <= 60)
                    {
                        Interest_rate = 7.00;
                    }
                    else if (No_of_days >= 61 && No_of_days <= 184)
                    {
                        Interest_rate = 7.50;
                    }
                    else if (No_of_days >= 185 && No_of_days <= 365)
                    {
                        Interest_rate = 8.00;
                    }
                }
                else if(Amount>=10000000)
                {
                    if (No_of_days >= 7 && No_of_days <= 14)
                    {
                        Interest_rate = 6.50;
                    }
                    if (No_of_days >= 15 && No_of_days <= 45)
                    {
                        Interest_rate = 6.75;
                    }
                    if (No_of_days >= 46 && No_of_days <= 60)
                    {
                        Interest_rate = 8.00;
                    }
                    if (No_of_days >= 61 && No_of_days <= 184)
                    {
                        Interest_rate = 8.50;
                    }
                    if (No_of_days >= 185 && No_of_days <= 365)
                    {
                        Interest_rate = 10.00;
                    }
                }
            }

            try
            {
                Validate(Amt, days, age);
            }
            catch (InvalidEntryException e)
            {
                i = 1;
                Console.WriteLine("\nException: {0}\n", e.Message);
            }
            finally
            {
                if (i != 1)
                {
                    calculateInterest();
                }
            }
            
        }

        public override void calculateInterest()
        {
            Console.WriteLine("\nInterest Gained = {0}\n", Interest_rate * Amount * 0.01);
        }

        public void Validate(bool amt, bool days, bool age)
        {
           if((!amt)||(Amount<0)) 
                throw new InvalidEntryException("Invalid Amount. Please enter correct values.");
           if((!days)||(No_of_days<1)||(No_of_days>365))
                throw new InvalidEntryException("Invalid No of Days. Please enter correct values.");
           if((!age)||(Age<1))
                throw new InvalidEntryException("Invalid Age. Please enter correct values.");
        }
    }

    abstract class RDAccount : Account
    {
        protected double Interest_rate;
        protected double Amount;
        protected int Months;
        protected int Age;

        public abstract void calculateInterest();
    }

    class RD : RDAccount
    {
        public RD()
        {
            int i = 0;
            Console.WriteLine("Enter the RD amount:");
            bool Amt = Double.TryParse(Console.ReadLine(), out Amount);
            Console.WriteLine("Enter the number of days:");
            bool time = int.TryParse(Console.ReadLine(), out Months);
            Console.WriteLine("Enter your Age:");
            bool age = int.TryParse(Console.ReadLine(),out Age);

            if (Age >= 60)
            {
                if (Months >= 1 && Months <= 6)
                {
                    Interest_rate = 8.00;
                }
                else if (Months > 6 && Months <= 9)
                {
                    Interest_rate = 8.25;
                }
                else if (Months > 9 && Months <= 12)
                {
                    Interest_rate = 8.50;
                }
                else if (Months > 12 && Months <= 15)
                {
                    Interest_rate = 8.75;
                }
                else if (Months > 15 && Months <= 18)
                {
                    Interest_rate = 9.00;
                }
                else if (Months > 18 && Months <= 21)
                {
                    Interest_rate = 9.25;
                }
            }
            else if (Age < 60)
            {
                if (Months >= 1 && Months <= 6)
                {
                    Interest_rate = 7.50;
                }
                else if (Months >6  && Months <= 9)
                {
                    Interest_rate = 7.75;
                }
                else if (Months > 9 && Months <= 12)
                {
                    Interest_rate = 8.00;
                }
                else if (Months > 12 && Months <= 15)
                {
                    Interest_rate = 8.25;
                }
                else if (Months > 15 && Months <= 18)
                {
                    Interest_rate = 8.50;
                }
                else if (Months > 15 && Months <= 18)
                {
                    Interest_rate = 8.75;
                }
            }

            try
            {
                Validate(Amt, time, age);
            }
            catch (InvalidEntryException e)
            {
                i = 1;
                Console.WriteLine("\nException: {0}\n", e.Message);
            }
            finally
            {
                if (i != 1)
                {
                    calculateInterest();
                }
            }
        }

        public override void calculateInterest()
        {
            Console.WriteLine("\nInterest Gained = {0}\n", Interest_rate * Amount * 0.01);
        }

        public void Validate(bool amt, bool time, bool age)
        {
            if ((!amt) || (Amount < 0))
                throw new InvalidEntryException("Invalid Amount. Please enter correct values.");
            if ((!time) || (Months<1)||(Months>21))
                throw new InvalidEntryException("Invalid No of Months. Please enter correct values.");
            if ((!age) || (Age<1))
                throw new InvalidEntryException("Invalid Age. Please enter correct values.");
        }
    }

    abstract class SBAccount : Account
    {
        protected double Interest_rate;
        protected double Amount;

        public abstract void calculateInterest();
    }

    class SB : SBAccount
    {
        public SB()
        {
            int i = 0;
            Console.WriteLine("Enter the Average amount in your account:");
            bool Amt = Double.TryParse(Console.ReadLine(), out Amount);
            Console.WriteLine("Select Type of Account: ");
            Console.WriteLine("1. Normal");
            Console.WriteLine("2. NRI\n");
            int k=0;
            bool n = int.TryParse(Console.ReadLine(),out k);
            if (k == 2)
                Interest_rate = 6;
            if (k == 1)
                Interest_rate = 4;

            try
            {
                Validate(Amt,n,k);
            }
            catch (InvalidEntryException e)
            {
                i = 1;
                Console.WriteLine("\nException: {0}\n", e.Message);
            }
            finally
            {
                if (i != 1)
                {
                    calculateInterest();
                }
            }
        }

        public override void calculateInterest()
        {
            Console.WriteLine("\nInterest Gained = {0}\n", Interest_rate * Amount * 0.01);
        }

        public void Validate(bool amt,bool inp,int k)
        {
            if ((!amt)|| (Amount<0))
                throw new InvalidEntryException("Invalid Amount. Please enter correct values.");
            if ((!inp) || (k!= 1 && k != 2))
                throw new InvalidEntryException("Invalid option entered. It must be 1 or 2.");
        }
    }


    class TM05_InterestCalc
    {
        static void Menu()
        {
            Console.WriteLine("Select the option: ");
            Console.WriteLine("1. Interest Calculator -SB");
            Console.WriteLine("2. Interest Calculator -FD");
            Console.WriteLine("3. Interest Calculator -RD");
            Console.WriteLine("4. Exit\n");
        }

        static void Main()
        {
            int i=0;
            do
            {
                Menu();
                try
                {
                    bool input=  int.TryParse(Console.ReadLine(), out i);
                    checkvalue(i,input);
                }
                catch(InvalidEntryException e)
                {
                    Console.WriteLine("\nException: {0}\n", e.Message);
                }
                switch (i)
                {
                    case 1:
                        SBAccount SB1 = new SB();
                        break;
                    case 2: FDAccount FD1 = new FD();
                        break;
                    case 3:
                        RDAccount RD1 = new RD();
                        break;
                    case 4:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        break;
                }
            } while (i!=4);
        }

        public static void checkvalue(int a, bool input)
        {
            if((!input)||(!(a>=1 && a<=4)))
                throw new InvalidEntryException("Invalid option entered. It must be between 1-4.");
        }
    }
}
