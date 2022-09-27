void Zadacha0019()
  {
  /* Задача 19
  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
  14212 -> нет
  12821 -> да
  23432 -> да */


  Console.Clear();

  Console.Write ("Введите пятизначное число: ");
  int num = Convert.ToInt32(Console.ReadLine());

  string numtxt = Convert.ToString(num);

  if (numtxt [0] == numtxt [4] && numtxt [1] == numtxt [3])
  {
    Console.WriteLine ("Число является палидромом");
  }
  else
  {
    Console.WriteLine ("Число не является палидромом");
  }

  }

void Zadacha0021()
  {
  /* Задача 21
  Напишите программу, которая принимает на вход координаты двух точек 
  находит расстояние между ними в 3D пространстве.
  A (3,6,8); B (2,1,-7), -> 15.84
  A (7,-5, 0); B (1,-1,9) -> 11.53 */

  Console.Clear();

  Console.Write ("Введите координату X1: ");
  int X1 = int.Parse(Console.ReadLine());

  Console.Write ("Введите координату Y1: ");
  int Y1 = int.Parse(Console.ReadLine());

  Console.Write ("Введите координату Z1: ");
  int Z1 = int.Parse(Console.ReadLine());

  Console.Write ("Введите координату X2: ");
  int X2 = int.Parse(Console.ReadLine());

  Console.Write ("Введите координату Y2: ");
  int Y2 = int.Parse(Console.ReadLine());

  Console.Write ("Введите координату Z2: ");
  int Z2 = int.Parse(Console.ReadLine());

  double lenght = (Math.Round(Math.Sqrt(Math.Pow ((X1 - X2), 2) + Math.Pow ((Y1 - Y2), 2) + Math.Pow ((Z1 - Z2), 2)),2));

  Console.WriteLine("Расстояние между точками = " + lenght);

  }

void Zadacha0023()
  {
  /* Задача 23
  Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
  3 -> 1, 8, 27
  5 -> 1, 8, 27, 64, 125 */

  Console.Clear();

  Console.Write("Введите число N: ");
  int num = int.Parse(Console.ReadLine());

  for (int i = 1; i <= num; i++)
  Console.Write(Math.Pow (i, 3) + " ");
  }




Zadacha0019();
//Zadacha0021();
//Zadacha0023();