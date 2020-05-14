using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class MatrixMultiplication
    {
        public void InputMatrixAndDisplay()
        {
            Console.WriteLine("enter the no of rows and columns for first matrix ");
            int noOfRowsOfMatrix1 = int.Parse(Console.ReadLine());
            int noOfColumnsOfMatrix1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the no of rows and columns for second matrix ");
            int noOfRowsOfMatrix2 = int.Parse(Console.ReadLine());
            int noOfColumnsOfMatrix2 = int.Parse(Console.ReadLine());
            if(noOfColumnsOfMatrix1==noOfRowsOfMatrix2)
            {
                Matrix matrix1 = new Matrix(noOfRowsOfMatrix1, noOfColumnsOfMatrix1);
                Matrix matrix2 = new Matrix(noOfRowsOfMatrix2, noOfColumnsOfMatrix2);
                Console.WriteLine("Enter the elements of matrix1 ");
                matrix1.Read();
                Console.WriteLine("Enter the elements of matrix2 ");
                matrix2.Read();
                DisplayMatrix(matrix1, matrix2, noOfRowsOfMatrix1, noOfColumnsOfMatrix2);
            }
            else
            {
                Console.WriteLine("Entered wrong dimension of matrix matrix multiplication not possible");
            }
        }
        public void DisplayMatrix(Matrix matrix1, Matrix matrix2, int noOfRowsOfMatrix1, int noOfColumnsOfMatrix2)
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Display matrix1 below :");
            Console.WriteLine("----------------------------------------------------------------------------------");
            matrix1.Display(DisplayType.All);
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Display matrix2 below :");
            Console.WriteLine("----------------------------------------------------------------------------------");
            matrix2.Display(DisplayType.All);
            Console.WriteLine("----------------------------------------------------------------------------------");
            Matrix  product = matrix1 * matrix2;
            Console.WriteLine("Product of matrix 1 and matrix 2 is below :");
            Console.WriteLine("----------------------------------------------------------------------------------");
            product.Display(DisplayType.All);
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Display Even elements of matrix below : ");
            Console.WriteLine("----------------------------------------------------------------------------------");
            product.Display(DisplayType.Even);
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("Display odd elements of matrix below :");
            Console.WriteLine("----------------------------------------------------------------------------------");
            product.Display(DisplayType.Odd);
            Console.WriteLine("----------------------------------------------------------------------------------");
            product.SumOfBothEvenOddElements();
            Console.WriteLine("Sum of even elements of matrix  is :" + product.GetSumofEvenElements());
            Console.WriteLine("Sum of Odd elements of matrix is :" + product.GetSumofOddElements());
        }
    }
}
