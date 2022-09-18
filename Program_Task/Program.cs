string[] array1 = {"[", "hello", " ", "2", " ", "world", " ", ":-)", "]"};
string[] array2 = {"[", "1234", " ", "1567", " ", "-2", " ", "computer science", "]"};
string[] array3 = {"[", "Russia"," ", "Denmark"," ", "Kazan", "]"};

void MethodArray(string[] array)
{
     string[] newarr = new string[array.Length];
     for (int i = 0; i < array.Length; i++)
     {      
        if(array[i].Length <= 3)
        {
        newarr[i]=array[i];
        Console.Write(newarr[i]); 
        }
     }
        Console.WriteLine(); 
}

void PrintArray(string[] Array)
{
   for (int i = 0; i < Array.Length; i++)
    {
        Console.Write(Array[i]);
    }
    Console.WriteLine();
}

MethodArray(array1);
PrintArray(array1);
Console.WriteLine();

MethodArray(array2);
PrintArray(array2);
Console.WriteLine();

MethodArray(array3);
PrintArray(array3);
Console.WriteLine();