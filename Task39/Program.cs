// Напишите программу, которая перевернёт одномерный массив (последний элемент 
// будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


using static System.Console;
Clear();

Write("Введите размер массива: ");
int arraySize = int.Parse(ReadLine()!);
int[] array = GetArray(arraySize); 

WriteLine($"[{string.Join(",", array)}]");
ReverseArray2(array);  
WriteLine($"[{string.Join(",", array)}]");


int [] GetArray (int size)
{
    int[] resultArray = new int[size];
    for(int i=0; i< size; i++)
    {
        resultArray[i]= new Random().Next(1,10);
    }

    return resultArray;
}

void ReverseArray2(int[] InnArray)
{
    for(int i=0; i < InnArray.Length/2; i++)
    {
        int temp = InnArray[i];
        InnArray[i] =  InnArray[InnArray.Length - i -1];
        InnArray[InnArray.Length - i -1] = temp;

        
    }

}
