// class task 1

// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());

// Console.WriteLine(IsDivisible(a ,b).ToString().ToLower());

// bool IsDivisible(int a, int b)
// {
//     return a % b == 0;
// }

// class task 2

// int a = int.Parse(Console.ReadLine());

// Console.WriteLine(GetNumberType(a));

// string GetNumberType(int a)
// {
//     if(a % 2 == 0)
//     {
//         return "Even";
//     }
//     else
//     {
//         return "Odd";
//     }
// }

// class task 5

// int a = int.Parse(Console.ReadLine());

// Console.WriteLine(Factorial(a));

// int Factorial(int a){
//     int sum = 1;
//     for(int i=1 ; i<=a; i++){
//         sum *=i;
//     }
//     return sum;
// }

// class task 6

// int a = int.Parse(Console.ReadLine());

// System.Console.WriteLine(ReverseNumber(a));

// int ReverseNumber(int a)
// {
//     int s = 0;
//     while (a > 0)
//     {
//         s = s * 10 + a % 10;
//         a/= 10;
//     }
//     return s;
// }

// class task 7

// int a = int.Parse(Console.ReadLine());
// Console.WriteLine(CountDigits(a));
// int CountDigits(int a)
// {
//     int s=0;
//     for(int i=a; i>0; i/=10)s++;
//     return s;
// }

//class task 8

//   int a = int.Parse(Console.ReadLine());

// int cnt = 0;

// while (a > 0)
// {
//     int arr = a % 10;

//     if (arr % 2 == 0)
//     {
//         cnt += arr;
//     }

//     a /= 10;
// }

// Console.WriteLine(cnt);

// home task 1


// int a=int.Parse(Console.ReadLine());

// for(int i=0; i<=a; i++)
// {
//     System.Console.Write(i);
// }

// home task 2

// int a=int.Parse(Console.ReadLine());

// for(int i=a; i>=0; i--)
// {
//     System.Console.WriteLine(i);
// }

// home task 3

// int n = int.Parse(Console.ReadLine());

// int sum = 0;

// while (n > 0)
// {
//     sum += n;
//     n--;
// }

// Console.WriteLine(sum);

// home task 4

// int n = int.Parse(Console.ReadLine());

// int rev = 0;

// while (n > 0)
// {
//     int digit = n % 10;
//     rev = rev * 10 + digit;
//     n /= 10;
// }

// while (rev > 0)
// {
//     int digit = rev % 10;
//     Console.Write(digit + " ");
//     rev /= 10;
// }

// home task 5

// int n = int.Parse(Console.ReadLine());

// int cnt = 0;

// while (n > 0)
// {
//     cnt++;
//     n /= 10;
// }

// Console.WriteLine(cnt);

// home task 6


// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());

// Console.WriteLine("All even numbers from " + a + " to " + b + " are :");

// for (int i = a; i <= b; i++)
// {
//     if (i % 2 == 0)
//     {
//         Console.Write(i + " ");
//     }
// }

// Console.WriteLine();

// Console.WriteLine("All odd numbers from " + a + " to " + b + " are :");

// for (int i = a; i <= b; i++)
// {
//     if (i % 2 != 0)
//     {
//         Console.Write(i + " ");
//     }
// }

