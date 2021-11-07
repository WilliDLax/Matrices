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

    Matrices matrix = new Matrices();
    matrix.multiply(matrix1,matrix2);

  }
}

class Matrices{
  public void multiply(int[,] firstMat, int[,] secondMat){
    int firstMatRows = firstMat.GetLength(0);
    int firstMatCols = firstMat.GetLength(1);
    int secondMatRows = secondMat.GetLength(0);
    int secondMatCols = secondMat.GetLength(1);

    if(firstMatCols != secondMatRows){
      Console.WriteLine("The 2 matrices cannot be multiplied");
      return;
    }

    int[,] product = new int[firstMatRows,secondMatCols];

    for(int i= 0; i<firstMatRows; i++){
      for(int j=0; j<secondMatCols; j++){
        for(int k=0; k<firstMatCols; k++){
          product[i,j] += firstMat[i,k] * secondMat[k,j];
        }
        Console.Write(" "+product[i,j]);
      }
      Console.WriteLine();
    }
  }
}