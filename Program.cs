using System;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello, World!");
    // Swap ss = new Swap();
    // ss.Swapping();
    // Multiplication mm = new Multiplication();
    // mm.Multi();
    // ArithmeticOperations ac = new ArithmeticOperations();
    // ac.Arithmetic();
    // Result rr = new Result();
    // rr.Resulting();
    // Grade gg = new Grade();
    // gg.Gradesheet();
    // Pattern pk = new Pattern();
    // pk.PatternPP();
    // PatternPP ps = new PatternPP();
    // ps.PPT();
    // MultiplicationTable mm = new MultiplicationTable();
    // mm.Multi();
    // Factorial ff = new Factorial();
    // ff.Factor();
    // Student ss = new Student();
    // ss.Marks();
    // StudentSS sd = new StudentSS();
    // sd.SSS();
    // Factor fc = new Factor();
    // fc.Fact();
    // SumProgram ss = new SumProgram();
    // ss.Sum();
    // ArmstrongCheck aa = new ArmstrongCheck();
    // aa.Armstrong();
    // BinaryToDecimal bb = new BinaryToDecimal();
    // bb.Number(); 
    //  int x = 5, y = 7;

    //     Console.WriteLine("Before calling Swap: x = {0}, y = {1}", x, y);


    //     Swapper obj = new Swapper();

    //     obj.Swap(x, y);

    //     Console.WriteLine("\nAfter calling Swap: x = {0}, y = {1}", x, y);

    //     Console.ReadLine();
    //            int x = 10, y = 20;

    // Console.WriteLine("Before calling Swap: x = {0}, y = {1}", x, y);

    // RefKywordSwapping obj = new RefKywordSwapping();
    // obj.Swap(ref x, ref y);


    // Console.WriteLine("\nAfter calling Swap: x = {0}, y = {1}", x, y);


    // Calculator calc = new Calculator();

    // int num1 = 5;
    // int num2 = 5;


    // int result1 = calc.SquareByValue(num1);
    // Console.WriteLine("Call by Value result: " + result1);
    // Console.WriteLine("Original num1 (unchanged): " + num1);


    // calc.SquareByReference(ref num2);
    // Console.WriteLine("Call by Reference result (num2 changed): " + num2);
    //  MathOperation obj = new MathOperation(); 

    // int num = 6;
    // Console.WriteLine("Original number: " + num);


    // obj.Square(ref num);

    // Console.WriteLine("After squaring (call by reference): " + num);
         SumAndProduct obj = new SumAndProduct();

        int num1 = 4, num2 = 5;
        int sum, product;

        
        obj.Calculate(num1, num2, out sum, out product);

        Console.WriteLine("First Number: " + num1);
        Console.WriteLine("Second Number: " + num2);
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Product: " + product);
    }
}

    

  

    



