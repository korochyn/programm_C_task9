// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Ввод координат точки А
Console.Write("Введите координату X точки A ");
int A_coordinat_X = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y точки A ");
int A_coordinat_Y = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z точки A ");
int A_coordinat_Z = int.Parse(Console.ReadLine()!);

// Ввод координат точки В
Console.Write("Введите координату X точки B ");
int B_coordinat_X = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Y точки B ");
int B_coordinat_Y = int.Parse(Console.ReadLine()!);
Console.Write("Введите координату Z точки B ");
int B_coordinat_Z = int.Parse(Console.ReadLine()!);

// Вычисление разностей по каждой из координат
int diff_X = A_coordinat_X-B_coordinat_X;
int diff_Y = A_coordinat_Y-B_coordinat_Y;
int diff_Z = A_coordinat_Z-B_coordinat_Z;

// Вычисление растояния как квадратного корня из суммы квадратов разносте по каждой из координат
double hypotenuse1 =  Math.Sqrt(diff_X*diff_X + diff_Y*diff_Y+diff_Z*diff_Z);
Console.WriteLine(hypotenuse1);
