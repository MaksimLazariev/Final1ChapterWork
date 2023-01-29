// Программа ищет в введенном массиве строки, длина которых меньше либо равна 3 символам и копирует их в другой массив из строк.


//------------------  Методы ---------------------------

//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Ввод одномерного массива
void Input1DArr(string[] arr)
{    
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите {i+1}е слово > ");
        arr[i] = Console.ReadLine() ?? "0";
    }
}

// Поиск слов длиной <=3 в массиве из строк. Мы не знаем количество найденых элементов, поэтому не можем заранее завести массив под них. Поэтому копируем их в строку через зяпятую
string FindWordsInArray(string[] startArray)
{
    int wordLength = 3;
    string tempLine = string.Empty;

    // int wordCounter = 0;
    for (int i = 0; i < startArray.Length; i++)
    {
        if (startArray[i].Length <= wordLength)
        {
            tempLine += startArray[i] + ',';
    //        wordCounter++;
        } 
    }
    return tempLine;
}

// Печать одномерного массива
void Print1DArr(string[] arr, string msg)
{
    Console.Write(msg + "\n[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}


//-------------------  Тело программы ------------------
Console.Clear();
Console.WriteLine("Программа ищет в введенном массиве строки, длина которых меньше либо равна 3 символам и копирует их в другой массив из строк.");

int wordsNumber = ReadData("\nВведите количество слов, которые вы хотите ввести > ");
string[] inputArray = new string [wordsNumber];

// вводим исходный массив
Input1DArr(inputArray);

// пишем найденые элементы в строку
string resultLine = FindWordsInArray(inputArray);

// Создаем новый массив, копируем элементы из строки
string[] resultArray  = resultLine.Split(',',  StringSplitOptions.RemoveEmptyEntries);

// Проверяем, если нет слов длиной меньше или равных 3 символа
if ( resultArray.Length > 0 ) 
{
    // печатаем исходный массив
    Print1DArr(inputArray, "\nИсходный массив ");
    // печатаем полученный массив
    Print1DArr(resultArray, "Полученный массив ");
}
else 
{
    Console.WriteLine("\nВ заданном массиве нет слов длиной меньше или равных длиной в 3 символа");
}