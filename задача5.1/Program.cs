//34 Задайте массив заполненный случайными положительными трехзначными
//числами. Напишите программу,которая покажет количество четных чисел
// в массиве
//[345,897,568,234]->2
int[] GenerateArray (int length){
    var Array =new int[length];
    var random= new Random();
    for(var i=0;i<Array.Length;i++){
        Array[i]= random.Next(100,1000);
    }
    return Array;
}
void PrintArrey(int[]array){
    for(var i=0;i<array.Length;i++){
        Console.Write(array[i]+",");
    }
    System.Console.WriteLine();
}
int AltNum(int[]array){
    int N=0;
    for(var i=0;i<array.Length;i++){
        if (array[i]%2==0)
        N++;
    }
    return N;
}
var array=GenerateArray(6);
PrintArrey(array);
System.Console.WriteLine(AltNum(array));

