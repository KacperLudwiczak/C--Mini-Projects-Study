﻿// See https://aka.ms/new-console-template for more information

int[,]  array2D = new int[3,3];
// [0] [0] [0]
// [0] [0] [0]
// [0] [0] [0]

int[,,] array3D = new int[3,3,3];
// It is a square in 3D

int[,] example2D = { {1,2}, {3,4} };
// [1] [2] 
// [3] [4] 

Console.WriteLine(example2D[0,0]);
Console.WriteLine(example2D[0,1]);
Console.WriteLine(example2D[1,0]);
Console.WriteLine(example2D[1,1]);

string[,] example2DIndex =
{
    { "00", "01", "02"},
    { "10", "11", "12"},
    { "20", "21", "22"},
};

string[,,] example3DIndex =
{ 
    {
      { "000", "001"},
      { "010", "011"},
    },
    { 
      { "100", "101"},
      { "110", "111"},
    }
};

// Tic Tac Toe
string[,] ticTacToeField =
{
    { "O", "X", "X"},
    { "O", "O", "X"},
    { "X", "X", "O"},
};

// Sum of the current row
int[,] array = new int[,]
{
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
};

// Iterate over each row
for (int i = 0; i < array.GetLength(0); i++)
{
    int rowSum = 0;
    // Calculate the sum of the current row
    for (int j = 0; j < array.GetLength(1); j++)
    {
        rowSum += array[i, j];
    }
    // Print the sum of the current row to the console
    Console.WriteLine(rowSum);
}

Console.ReadKey();