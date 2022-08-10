/* Написать программу, которая формирует массив из строк 
с длиной меньше либо ровно 3 символа.
*/
Console.WriteLine("Enter your words using spacebar: ");

string[] words = Console.ReadLine()!.Split(); // Type array of strings.
string[] newwords = new string[words.Length]; // Empty array.
int j = 0;

for (int i = 0; i < words.Length; i++)
{
    if (words[i].Length <= 3) // Check if word is shotre then 3.
    {
        newwords[j] = words[i]; // Put in in a new array.
        Console.Write($"{newwords[j]} ");// Show it.
        j++;
    }
}