// замена элементов массива, если сначала у нас элемент положительный, то потмо его нужно сделать отрицательным
int size  = 10;
int [] array = new int [size];
int [] newarray = new int[size];
void Firstarray(int [] array1)
{
    for (int i =0;i<array.Length;i++)
    {
     array[i] = new Random().Next(-9,10);
    }
}
Firstarray(array);
Console.WriteLine(string.Join(",", array));
void Newarr (int [] newarr)
{
for (int j=0;j<newarr.Length;j++)
{
newarr[j] = array[j]*(-1);
}
}
Newarr(newarray);
Console.WriteLine(string.Join(",", newarray));