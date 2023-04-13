// Task 10

/*
int Decade(int num)
{
    int decade = num / 10;
    int result = decade % 10;
    return result;
}

Console.Write("Введите трехзначное число ");
int num = Convert.ToInt32(Console.ReadLine());

int otvet = Decade(num);

Console.WriteLine($"Вторая цифра от числа {num}  -> {otvet}");
*/

// Task 13

/*
int Unit(int num)
{
    int result = -1;
    int otvet = num % 10;
    if(num / 100 == 0) return result;
    else return otvet;
}

Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int otvet = Unit(num);

Console.Write($"Третья цифра от числа {num} -> {otvet}");
*/

// Task 15

/*
bool Weekend(int num)
{
    if(num == 7 || num ==6) return true;
    else return false;
}

Console.Write("Введите день недели числом ");
int num = Convert.ToInt32(Console.ReadLine());

bool otvet = Weekend(num);

Console.Write(otvet);
*/