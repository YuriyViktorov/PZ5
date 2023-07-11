
// Задача 38: 
// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


 // Метод генерации 1D массива
 double[] Gen1DArray(int len, int minValue, int maxValue)
 {
     double[] arr = new double[len];
     for (int i = 0; i < arr.Length; i++)
     {
         arr[i] = Math.Round( new Random().NextDouble() * new Random().Next(1, 99), 2);//rand.NextDouble();
     }
     return arr;
 }

 // Метод печати 1D массива в консоль
 void Print1DArr(double[] arr)
 {
     Console.Write("[");
     for (int i = 0; i < arr.Length - 1; i++)
     {
         Console.Write(arr[i] + ", ");
     }
     Console.WriteLine(arr[arr.Length - 1] + "]");
 }

 // Метод вывода значения в консоль
 void PrintData(double res)
 {
     Console.WriteLine(res);
 }

 // Метод рассчета разницы м/д Max и Min элементами массива
 double MaxMinSubtraction(double[] arr)
 {
     // переменной max присваиваем значение, минимально возможное для int32 - это константа = -2147483648
     double max = double.MinValue;
     // переменной min присваиваем значение, максимально возможное для int32 - это константа = +2147483648
     double min = double.MaxValue;
     for (int i = 0; i < arr.Length; i++)
     {
         if (arr[i] > max) max = arr[i];
         if (arr[i] < min) min = arr[i];
     }
     return max - min;
 }

 // Основной код программы:

 // генерируем 1D массив
 double[] testArr = Gen1DArray(4, 1, 99);

 // Выводим сгенерируемый массив в консоль
 Print1DArr(testArr);

 // Считаем разницу м/д max и min элементами массива, результат выводим в консоль
 PrintData(MaxMinSubtraction(testArr));