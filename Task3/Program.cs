// Задача 3: Задайте произвольную строку. Выясните,
// является ли она палиндромом.

// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

string isStrPalindrom(string str)
{
    string res = "Да";
    int i = 0;
    while (i <= (str.Length - 1) / 2)
    {
        //Console.WriteLine($"{str[i]}  -  {str[str.Length - 1 - i]}");
        if (str[i] != str[str.Length - 1 - i]) { res = "Нет"; }
        i++;
    }
    return res;
}

string[] str = {"aBcD1ef!","шалаш","55655"};


foreach (var item in str)
{
    Console.Write($"{item} => ");
Console.WriteLine(isStrPalindrom(item));
}
