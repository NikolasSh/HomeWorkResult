
int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result) && result >=1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }

    return result;
}

string [] InitArray(int number)
{
    
    string[] array = new string[number];
    
    for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Введите {i+1} элемент массива: ");
            array[i] = Console.ReadLine();
            if (array[i].Length == 0)
            {
                i--;
                Console.WriteLine("Вы ничего не ввели, попробуйте еще!");
            }
            
        }

    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        {
            
            Console.Write($"{array[i]} ");
            
        }
}

string [] InitResult(string[] array)
{
    string[] result = new string [array.Length];
    
    int number = 3;
    int j=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= number)
        {

            result[j] = array[i];
            j++;
        }
    }

    return result;
}

int number = GetNumber("Введите количество элементов массива: ");
string [] array = InitArray(number);
string [] result = InitResult(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
PrintArray(result);