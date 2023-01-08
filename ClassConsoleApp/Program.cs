namespace ClassConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            int pay;

            Staff staff1 = new Staff("Peter");
            staff1.HoursWorked = 160;
            pay = staff1.CalculatePay();
            Console.WriteLine("pay = {0}", pay);

            Staff staff2 = new Staff("Dozie", "Asogwa");
            staff2.HoursWorked = 200;
            pay = staff2.CalculatePay(2000,1250);
            Console.WriteLine("Pay is = {0}", pay);

            Staff staff3 = new Staff ("Ola");
            staff3.HoursWorked = -5;
            pay = staff3.CalculatePay();
            Console.WriteLine("Pay is = {0}", pay);


            Console.ReadKey();
            Console.Beep();
        }

        class Staff
        {
            private string _nameOfStaff;
            private const int _hourlyRate = 30;
            private int _hWorked;

            public int HoursWorked
            {
                get
                { return _hWorked; }
                set
                {
                    if (value > 0)
                        _hWorked = value;
                    else
                        _hWorked = 0;
                }
            }

            public void PrintMessage()
            {
                Console.WriteLine("Calculating Pay...");
            }

            public int CalculatePay()
            {
                PrintMessage();

                int StaffPay;
                StaffPay = _hWorked * _hourlyRate;

                if (_hWorked > 0)
                    return StaffPay;
                else
                    return 0;
            }

            public int CalculatePay(int bonus, int allowance)
            {
                PrintMessage();

                if (_hWorked > 0)
                    return _hWorked * _hourlyRate + bonus + allowance;
                else
                    return 0;
            }

            public Staff(String name)
            {
                _nameOfStaff = name;
                Console.WriteLine("\n" + _nameOfStaff);
                Console.WriteLine("----------------------------");
            }

            public Staff(string firstName, string lastName)
            {
                _nameOfStaff = firstName + " " + lastName;
                Console.WriteLine("\n" + _nameOfStaff);
                Console.WriteLine("----------------------------");
            }


        }
    }
}