//36 Задайте одномерный массив,заполненный случайными числами.
//Найдите сумму элементов,стоящих на нечетных позициях.
//[3,7,23,12]->19
//[-4,-6,89,6]->0
int[] GenerateArray (int length){
    var Array =new int[length];
    var random= new Random();
    for(var i=0;i<Array.Length;i++){
        Array[i]= random.Next(10,100);
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
        if (array[i]%2>0)
        N++;
    }
    return N;
}
var array=GenerateArray(4);
PrintArrey(array);
System.Console.WriteLine(AltNum(array));
