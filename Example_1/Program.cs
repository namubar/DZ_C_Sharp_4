Console.WriteLine ("Введите пятизначное число: ");
int n = int.Parse (Console.ReadLine()!);
int temp = n;
int revDigit = 0;
int isPalindrom (int n)
{
    //int temp = n;
    //int revDigit = 0;
    while (n>0)
    {
   //int revDigit = 0;
    int digit = n % 10;
    //int temp = n;
    revDigit = revDigit * 10 + digit;
    n = n / 10;
    }
    return revDigit;
}    
    isPalindrom (n);
    
    if (temp == revDigit)
    {
        Console.WriteLine ("Да, это палиндром");
    }
    else
    {
        Console.WriteLine ("Нет, это не палиндром");
    }

