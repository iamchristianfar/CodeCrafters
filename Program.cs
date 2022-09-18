using CodeCrafters_OTP;
using System;

public class Program
{
    private readonly PasswordGenerator passwordGenerator;
    public Program(PasswordGenerator passwordGenerator)
    {
        this.passwordGenerator = passwordGenerator;
    }
    Random random = new Random();
    static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        Console.WriteLine("Please enter your Id:");
        var userId2 = Console.ReadLine();
        DateTime datetime = DateTime.Now;
        int Id;
        var success = int.TryParse(userId2, out Id);
        if (!success)
        {
            Console.WriteLine("This is not a valid userId");
            return;
        }
        var generator = new PasswordGenerator();

        Timer timer = new System.Threading.Timer(o => { generator.Generate(Id, datetime); }, null,0,3000);
       
    }
   
}


