

// Задача №34

// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.


 // Метод вывода данных в консоль
 void PrintData(string res)
 {
     Console.WriteLine(res);
 }

 // Метод генерации 1D массива
 int[] Gen1DArray(int len, int minValue, int maxValue)
 {
     int[] arr = new int[len];
     for (int i = 0; i < arr.Length; i++)
     {
         arr[i] = new Random().Next(minValue, maxValue + 1);
     }
     return arr;
 }

 // Метод печати 1D массива в консоль
 void Print1DArr(int[] arr)
 {
     Console.Write("[");
     for (int i = 0; i < arr.Length - 1; i++)
     {
         Console.Write(arr[i] + ", ");
     }
     Console.WriteLine(arr[arr.Length - 1] + "]");
 }

 // Метод подсчета элементов 1D массива по заданному условию
 int CountElem(int[] arr)
 {
     int res = 0;
     for (int i = 0; i < arr.Length; i++)
     {
         if (Test(arr[i]))
         {
             res++;
         }
     }
     return res;
 }

 // Метод тест элемента массива на четность
 bool Test(int n)
 {
     return (n % 2 == 0);
 }

 // Основной код программы:

 // Генерируем массив по заданным в задачах параметрам
 int[] testArr = Gen1DArray(4,100,999);

 // Выводим массив в консоль
 Print1DArr(testArr);

 // Подсчитываем кол-во четных элементов массива
 int count = CountElem(testArr);
//Выводим ответ в консоль
 PrintData("Количество четных элементов равно: "+count);
