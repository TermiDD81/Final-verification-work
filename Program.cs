
Console.WriteLine("Введите длину массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string []array1 = new string[n];
int array2Length = 0;
for (int i = 0; i < array1.Length; i++)
{
    Console.WriteLine($"Введите строку {i+1}: ");
    array1[i] = Convert.ToString(Console.ReadLine());
    if (array1[i].Length <= 3)
        array2Length++;
}

string []array2 = new string[array2Length];
int j = 0;
for (int i = 0; i < array1.Length; i++)
{
    
    if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }
    }
Console.WriteLine();
Console.WriteLine($"[{string.Join(", ", array1)}] -> [{string.Join(", ", array2)}]");

