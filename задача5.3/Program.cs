//38 Задайте массив вещественных чисел.Найдите разницу между max и min
//элементов массива.[3 7 22 2 78]->76
Double[] GenerateArray (double Length){
    var Array =new double[5];
    var random= new Random();
    for(var i=0;i<Array.Length;i++){
        Array[i]= random.NextDouble()*100;
    }
    return Array;
}
void PrintArrey(double[]array){
    for(var i=0;i<array.Length;i++){
        Console.Write(array[i]+".");
    }
    System.Console.WriteLine();
}
Double rez (double[]array){
       Double max=0; 
       Double min=100;
        for(var i=0;i<array.Length;i++){
                if (array[i]> max)
        max= array[i];
        }         
           
        for(var i=0;i<array.Length;i++){
                if (array[i]< min)
                min = array[i]; 
        }   
        Double razn=max-min;
 return razn ;   
}           
var array=GenerateArray(5);
PrintArrey(array);
System.Console.WriteLine(rez(array));


