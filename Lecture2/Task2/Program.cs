int[] array = { 12, 23, 34, 45, 56, 67, 78, 89, 90 };

int n = array.Length;
int find = 56;
int index = 0;

while (index < n)
{
if (array[index] == find)
{
    Console.WriteLine(index);
    break;
}
    //index = index + 1;
    index++;
}