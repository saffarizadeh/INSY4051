namespace AssignmentThree;

class Program
{
    static void Main(string[] args)
    {
        double amount;
        int numberOfYears;
        double apr;
        double rate;
        int n;
        double discountFactor;
        double payment;
        double interest;
        double principal;
        double balance;

        Console.Write("Loan Amount: ");
        amount = Convert.ToDouble(Console.ReadLine());
        Console.Write("Number of Years: ");
        numberOfYears = Convert.ToInt32(Console.ReadLine());
        Console.Write("Annual Interest Rate (e.g., 7%): ");
        apr = Convert.ToDouble(Console.ReadLine()) / 100;

        rate = apr / 12;
        n = numberOfYears * 12;
        discountFactor = (Math.Pow((1 + rate), n) - 1) / (rate * Math.Pow((1 + rate), n));
        payment = amount / discountFactor;

        Console.WriteLine();
        Console.WriteLine($"Monthly Payment: {payment:C2}");
        Console.WriteLine($"Total Payment: {payment * n:C2}");

        balance = amount;
        Console.WriteLine();
        Console.WriteLine($"{"Payment#", -15}{"Interest", -15}{"Principal", -15}{"Balance", -15}");

        for (int i = 1; i <= n; i++)
        {
            interest = balance * rate;
            principal = payment - interest;
            balance = balance - principal;
            Console.WriteLine($"{i,-15}{interest,-15:C2}{principal,-15:C2}{balance,-15:C2}");
        }

    }
}

