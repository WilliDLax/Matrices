using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Working with 2 dim arrays");

    int[,] matrix1 = new int[,]{
      {1,2},
      {5,6}
    };

    int[,] matrix2 = new int[,]{
      {1,2},
      {5,6}
    };

    int matrix1rows = matrix1.GetLength(0);
    int matrix1cols = matrix1.GetLength(1);
    int matrix2rows = matrix2.GetLength(0);
    int matrix2cols = matrix2.GetLength(1);

    int[,] product = new int[matrix1rows,matrix2cols];

    for(int i= 0; i<matrix1rows; i++){
      for(int j=0; j<matrix2cols; j++){
        for(int k=0; k<matrix1cols; k++){
          product[i,j] += matrix1[i,k] * matrix2[k,j];
        
        }
        Console.Write(" "+product[i,j]);
      }
      Console.WriteLine();
    }
  }
}