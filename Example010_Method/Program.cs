int[] array = { 19, 28, 37, 64, 46, 55, 64, 73, 82, 91 };

int n = array.Length;
int find = 64;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;

}
