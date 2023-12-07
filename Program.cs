namespace Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //bankaccount class
            BankAccount myAccount = new BankAccount("1234567890");

            myAccount.Deposit(1000m);
            myAccount.Withdraw(500m);
            myAccount.DisplayBalance();


            //car class
            Car newone = new Car("Tesla", 2023, 800000f);
            newone.Display();


           
            // Rectangle example
            Rectangle myRectangle = new Rectangle(4.5f, 3.2f);
            float area = myRectangle.CalculateArea();
            Console.WriteLine($"Rectangle Area: {area}");

            
            // Circle example
            Circle myCircle = new Circle(5f);
            float circleArea = myCircle.CalculateArea();
            Console.WriteLine($"Circle Area: {circleArea}");

            // Student example
            Student myStudent = new Student("John Doe", 20, "Computer Science");
            myStudent.Introduce();
        }
    }
}