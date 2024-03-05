// Задача 2: Задайте строку, содержащую латинские буквы
// в обоих регистрах. Сформируйте строку, в которой все
// заглавные буквы заменены на строчные. 

// “aBcD1ef!-” => “abcd1ef!-” 

string upCaseToLowCase(string src)
{
    return src.ToLower();
}

string src = "aBcD1ef!";

Console.WriteLine(upCaseToLowCase(src));