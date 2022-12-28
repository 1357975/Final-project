void Zadacha()
//Написать программу, которая из имеющегося массива строк, формирует 
//массив из строк, длина которых меньше либо равна 3 символа.

{

Console.WriteLine("Введите массив через запятую: ");
string text = Console.ReadLine();

string[] existArray = text.Split(",");
string[] newArray = existArray.Where(text=>text.Length<4).ToArray();

Console.WriteLine("Массив из строк, длина которых меньше либо равна 3:  ");
Console.WriteLine(String.Join(", ", newArray));

}
Zadacha();