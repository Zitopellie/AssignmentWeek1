#region Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has the maximal sum of its elements
using System;
using System.ComponentModel;
/*
{
int n, m;
while (true)
{
    Console.WriteLine("How many row has your matrix? Note: Input an integer greater than 2:   ");
    string s = (Console.ReadLine());
    if(int.TryParse(s, out n))
    {
        if ( n > 2)
            break;
    }
  
}

}

while (true)
{
    Console.WriteLine("How many columns has your matrix? Note: Input an integer greater than 2:   ");
    string t = (Console.ReadLine());
    if (int.TryParse(t, out m))
    {
        if (m > 2)
            break;
    }

}


Console.WriteLine("\n your matrix is of dimension {0},{1}", n, m);

int[,] array = new int[n, m];

Console.Write("Input elements in the matrix :\n");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {

        while (true)
        {
            Console.WriteLine("element - [{0},{1}] : ", i, j);
            string t = (Console.ReadLine());
            if (int.TryParse(t, out int z))
            {
                array[i, j] = z;
                break;
            }

        }

    }

}

Console.Write("\nThe matrix is : \n");
for (int i = 0; i < n; i++)
{
    Console.Write("\n");
    for (int j = 0; j < m; j++)
        Console.Write("{0}\t", array[i, j]);
}
Console.Write("\n\n");



// Creating variables for highest sum of the matrix and the matrix that contains the highest sum 
int highest = 0;
int[,] highestArray = new int[3,3];

for(int i = 0, sum = 0; i < n; i++)
{
    
    if (i + 2 > n - 1)
        break;
    for (int j = 0; i < m; j++)
    {
        if (j + 2 > m - 1)
            break;

        for(int k = i; k < i + 2; k++)
        {
            for (int l = 0; l < j + 2; l++)
            {
                sum += array[k, l];
            }
        }
        if (sum > highest)
        {
            highest = sum;
            /*for(int o = i, w = 0; o < n; w++, o++)
            {
                for(int p = j, x = 0; p < m; p++, x++)
                {
                    highestArray[w,x] = array[o,p];
                }
            }
        }

    }
    Console.WriteLine(highestArray.ToString());
    */
}
#endregion

#region
//Write a program that creates an array containing all letters from the alphabet
//(A-Z). Read a word from the console and print
//the index of each of its letters in the array

//Please note that this expects users to enter only capital letters
{
    char[] characterArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    Console.WriteLine("enter a word(in capital Letters");
    string word = Console.ReadLine(); 
    
    for(int i = 0; i < word.Length; i++)
    {
        for(int j = 0; j < characterArray.Length; j++)
            if(word[i] == characterArray[j])
                Console.WriteLine("{0} is at index {1} of capital letters in English alphabet", word[i], characterArray[j]);
    }
    }


#endregion



#region
//Write a program that fills a matrix of size (N, N) and show same in the console (for N=4):
{
    int m;
    int n = 4;
    int[,] array = new int[n, m];

    Console.Write("Input elements in the matrix :\n");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {

            while (true)
            {
                Console.WriteLine("element - [{0},{1}] : ", i, j);
                string t = (Console.ReadLine());
                if (int.TryParse(t, out int z))
                {
                    array[i, j] = z;
                    break;
                }

            }

        }

    }

    Console.Write("\nThe matrix is : \n");
    for (int i = 0; i < n; i++)
    {
        Console.Write("\n");
        for (int j = 0; j < m; j++)
            Console.Write("{0}\t", array[i, j]);
    }
    Console.Write("\n\n");
}

#endregion


#region

//Write a program to convert decimal numbers to their binary representation
int n, i;
int[] a = new int[10];
Console.Write("Enter the number to convert: ");
n = int.Parse(Console.ReadLine());
for (i = 0; n > 0; i++)
{
    a[i] = n % 2;
    n = n / 2;
}
Console.Write("Binary of the given number= ");
for (i = i - 1; i >= 0; i--)
{
    Console.Write(a[i]);
}

#endregion


#region

//Write a program to convert binary numbers to their decimal representation

Console.Write("Enter the Binary Number : ");
int binaryNumber = int.Parse(Console.ReadLine());
int decimalValue = 0;
// initializing base1 value to 1, i.e 2^0 
int base1 = 1;

while (binaryNumber > 0)
{
    int reminder = binaryNumber % 10;
    binaryNumber = binaryNumber / 10;
    decimalValue += reminder * base1;
    base1 = base1 * 2;
}
Console.Write($"Decimal Value : {decimalValue} ");
Console.ReadKey();
#endregion

#region Write a program to convert hexadecimal numbers to their decimal representation

//declaring a variable and assigning hex value
string hex_value = "10FA";

//converting hex to integer
int int_value = Convert.ToInt32(hex_value, 16);

//printing the values
Console.WriteLine("hex_value = {0}", hex_value);
Console.WriteLine("int_value = {0}", int_value);

//hit ENTER to exit
Console.ReadLine();
#endregion


#region  2Bi


//Reverses the digits of a number

//I have learnt from my tutorial that I can use stack to reverse the digits of a number by storing it in an array etc

{
    Stack<int> numbers = new Stack<int>();
    while (numbers.Peek() != 0)
    {
        Console.WriteLine("enter digits, enter 0 to stop ");
        numbers.Push(Int32.Parse(Console.ReadLine()));
    }
    //now I remove the 0, the last integer input from the stack
    numbers.Pop();
    int[] arrayOrder = new int[numbers.Count];
    for (int u = 0; u < arrayOrder.Length; u++)
    {
        arrayOrder[u] = numbers.Pop();
    }
    Console.WriteLine("In reverse order: ");
    for (int z = 0; z < arrayOrder.Length; z++)
    {
        Console.WriteLine(arrayOrder[z]);
    }

}
#endregion

#region 2Bii
//Calculates the average of a sequence of integers
{
    Stack<int> numbers = new Stack<int>();
    while (numbers.Peek() != 0)
    {
        Console.WriteLine("enter digits, enter 0 to stop ");
        numbers.Push(Int32.Parse(Console.ReadLine()));
    }
    //now I remove the 0, the last integer input from the stack
    numbers.Pop();
    int[] arrayOrder = new int[numbers.Count];
    for (int u = 0; u < arrayOrder.Length; u++)
    {
        arrayOrder[u] = numbers.Pop();
    }
    int sum = 0;
    for (int z = 0 ; z < arrayOrder.Length; z++)
    {
        sum += arrayOrder[z];
    }
    float average = sum / arrayOrder.Length;
    Console.WriteLine("Average of these numbers is {0}", average);
}
#endregion

#region 2Biii
/* Solves a linear equation a * x + b = 0
Create appropriate methods.
	Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0 */

{
    Console.WriteLine("Program to solve a liner equation a*x+b, where x is the unknown variable, given that all other parameters will be given as inputs by the user");
    int aa, bb;
    while (true)
    {
        Console.WriteLine("Enter the value of a");
        string t = (Console.ReadLine());
        if (int.TryParse(t, out  aa))
        {
            if (aa != 0)
                break;
        }
    }

    while (true)
    {
        Console.WriteLine("Enter the value of b");
        string t = (Console.ReadLine());
        if (int.TryParse(t, out  bb))
        {
            if (aa*bb > 0)
                break;
        }
    }

    Console.WriteLine("x = {} ", -bb / aa);

}
#endregion

#region 2Biv
//Write a recursive program for generating and printing all permutations of the numbers 1, 2, ..., n for a given integer number n. Example:
//n = 3 => { 1, 2, 3}, { 1, 3, 2}, { 2, 1, 3}, { 2, 3, 1}, { 3, 1, 2},{ 3, 2, 1}

{

   namespace Recursive_Permutation
{
    public class CalPermutations
    {
        public int Run(int[] array, int indexer)
        {
            if (indexer > array.Length)
            {
                return 1;
            }
            else
            {
                for (int i = 0; i <= array.Length; i++)
                {
                    array[indexer] = i;
                    Display(array);
                }
                Run(array, indexer - 1);

            }
            return indexer;
        }
        public void Display(int[] array)
        {
            foreach (int num in array)
            {
                Console.Write(num);
            }
            Console.WriteLine();
        }


    }
}


#endregion
//}



