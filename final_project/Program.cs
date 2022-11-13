/* Итоговая проверочная работа. Текст задания:
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */

Console.WriteLine("Первоначальный массив:");
string[] incomingArray = new string[3] { "Russia", "Denmark", "Kazan"};
printIncomingArray(incomingArray);
int N = 3;
string[] resultArray = getResultArray(incomingArray);
Console.WriteLine($"Массив строк, длина которых меньше либо равна {N}:");
printResultArray(resultArray);


string[] getResultArray(string[] incomingArray)
{
    int j = 0;
    string[] resultArray = new string[incomingArray.Length];
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if (incomingArray[i].Length <= N)
        {
            resultArray[j] = incomingArray[i];
            j++;
        }
    }
    return resultArray;
}

void printIncomingArray(string[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
} 

void printResultArray(string[] resultArray)
{
    Console.Write("[");
    for (int i = 0; i < resultArray.Length; i++)
    {
        Console.Write(resultArray[i]);
        if (i < resultArray.Length - 1
        &&!String.IsNullOrEmpty(resultArray[i])
        &&i+1!=resultArray.Length-1
        &&!String.IsNullOrEmpty(resultArray[i+1]))
        {
            Console.Write(", ");
        }  
    }
    Console.WriteLine("]");
} 

