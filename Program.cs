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

int a = int.Parse(Console.ReadLine());
Console.WriteLine(CountDigits(a));
int CountDigits(int a)
{
    int s=0;
    for(int i=a; i>0; i/=10)s++;
    return s;
}