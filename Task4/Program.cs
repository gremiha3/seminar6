// Задача 4*(не обязательная): Задайте строку, состоящую
// из слов, разделенных пробелами. Сформировать строку,
// в которой слова расположены в обратном порядке. В
// полученной строке слова должны быть также разделены
// пробелами.

// “Hello my world” => “world my Hello”

string[] stringToArray(string str)
{
    int cntspace = 0;
    foreach (var item in str)
    {
        if (item == ' ') { cntspace++; }
    }

    string[] result = new string[cntspace + 1];
    int i = 0;
    foreach (var item in str)
    {
        if (item != ' ') { result[i] = result[i] + item; }
        else { i++; }
    }

    return result;
}



string revers(string str)
{
    string res = "";
    string[] arrStr = stringToArray(str);
    int i = 0;
    string temp;
    while (i <= (arrStr.Length - 1) / 2)
    {
        temp = arrStr[i];
        arrStr[i] = arrStr[arrStr.Length - 1 - i];
        arrStr[arrStr.Length - 1 - i] = temp;
        i++;
    }
    foreach (var item in arrStr)
    {
        res += item;
        res +=' ';
    }
    return res;
}


string str = "Hello my world";

Console.WriteLine($"{str} => {revers(str)}");