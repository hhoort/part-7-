
// See https://aka.ms/new-console-template for more information

//part 1

//// Input first number
//Console.Write("Enter the first number: ");
//int num1 = Convert.ToInt32(Console.ReadLine());

//// Input second number
//Console.Write("Enter the second number: ");
//int num2 = Convert.ToInt32(Console.ReadLine());

//// Addition
//int add = num1 + num2;
//Console.WriteLine($"The Addition is: {num1} + {num2} = {add}");

//// Subtraction
//int sub = num1 - num2;
//Console.WriteLine($"The Subtraction is: {num1} - {num2} = {sub}");

//// Multiplication
//int mul = num1 * num2;
//Console.WriteLine($" The Multiplication is: {num1} * {num2} = {mul}");

//// Division

//    int div = num1 / num2;
//    Console.WriteLine($"The Division is: {num1} / {num2} = {div}");


//// Modulus (Remainder)

//    int remainder = num1 % num2;
//    Console.WriteLine($"The remainder(Modulus) is: {num1} % {num2} = {remainder}");




//part 2

//Input first number
        Console.Write("Enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

// Input second number
Console.Write("Enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Compare  the result
if (num1 > num2)
{
    Console.WriteLine($"{num1} is greater than {num2}");
}
else if (num1 < num2)
{
    Console.WriteLine($"{num1} is less than {num2}");
}
else
{
    Console.WriteLine($"{num1} is equal to {num2}");
}


//part 3

//while

//// Input a number
//Console.Write("Enter a number: ");
//int number = Convert.ToInt32(Console.ReadLine());

//int i = 1;
//while (i <= 10)
//{
//    int result = number * i;
//    Console.WriteLine($"{number} * {i} = {result}");
//    i++;
//}


//do while

//  // Input a number
//  Console.Write("Enter a number: ");
//  int number = Convert.ToInt32(Console.ReadLine());

//  int i = 1;
//  do
//  {
//      int result = number * i;
//      Console.WriteLine($"{number} * {i} = {result}");
//      i++;
//  }
//while (i <= 10);

//for loop

//// Input a number
//Console.Write("Enter a number: ");
//int number = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    int result = number * i;
//    Console.WriteLine($"{number} * {i} = {result}");
//}

//part 4


//int num_Rows = 5;

//for (int i = 1; i <= num_Rows; i++)
//{
//    for (int j = 1; j <= i; j++)
//    {
//        Console.Write("*");
//    }
//    Console.WriteLine(i);
//}

//part 5 (even number )

// int sum = 0;

////for loop
// for (int i = 1; i <= 100; i++)
// {
//     if ((i % 2) != 0)
//     {
//         continue;
//     }
//     sum += i;

//     // Use break 
//     if (i > 50)
//     {
//         break;
//     }
// }

// Console.WriteLine($"The sum of even numbers is: {sum}");

//part 6

//Console.Write("Enter a name: ");
//string r = Console.ReadLine();

//string ans = "";
//for (int i = r.Length - 1; i >= 0; i--)
//{
//    ans = ans + r[i];

//}
//Console.WriteLine($"The reversed name is :{ans}");


// part 7

//Console.WriteLine("Prime numbers between 1 and 100:");

//for (int number = 2; number <= 100; number++)
//{
//    bool isPrime = true;

//    for (int divisor = 2; divisor < number; divisor++)
//    {
//        if (number % divisor == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }

//    if (isPrime)
//    {
//        Console.Write($"{number} ");
//    }
//}













