using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public enum DisplayType
    {
       All=0,
       Odd,
       Even
    };
    class Matrix
    {
        private int _rows;
        private int _columns;
        private int[,] array;
        public Matrix(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
            array = new int[_rows, _columns];
        }
        public void Read()
        {
            for (int row = 0; row < _rows; row++)
            {
                for (int column = 0; column < _columns; column++)
                {
                    Console.WriteLine("enter the element into matrix at postion: " + "[" + row + "]" + "[" + column + "]");
                    array[row, column] = int.Parse(Console.ReadLine());
                }
            }
        }
        private int sumOfOddElementsOfMatrix = 0;
        public int GetSumofOddElements()
        {
            return sumOfOddElementsOfMatrix;
        }
        private int sumOfEvenElementsOfMatrix = 0;
        public int GetSumofEvenElements()
        {
            return sumOfEvenElementsOfMatrix;
        }
        public void SumOfBothEvenOddElements()
        {
            for(int row =0; row<_rows;row++)
            {
                for(int column =0; column<_columns;column++)
                {
                    if(array[row,column]%2==0)
                    {
                        sumOfEvenElementsOfMatrix += array[row, column];
                    }
                    else
                    {
                        sumOfOddElementsOfMatrix += array[row, column];
                    }
                }
            }
        }
        public void Display(DisplayType type)
        {
            for (int row = 0; row < _rows; row++)
            {
                string tab = "|\t";
                for (int column = 0; column < _columns; column++)
                {
                    bool isOddEven = array[row, column] % 2 == 0 ? true : false;
                    switch (type)
                    {
                        case DisplayType.Even:
                            tab += SwitchCase(row, column, isOddEven);
                            break;

                        case DisplayType.Odd:
                            tab += SwitchCase(row, column, !isOddEven);
                            break;

                        case DisplayType.All:
                            tab = tab + array[row, column].ToString() + "\t";
                            break;

                        default:
                            Console.WriteLine("wrong enaum type entered");
                            break;
                    }
                }
                Console.WriteLine(tab + "|");
            }
        }
        public string SwitchCase(int row, int column, bool isOddEven)
        {
            string tab = String.Empty;
            if (isOddEven)
            {
                tab = tab + array[row, column].ToString() + "\t";
            }
            else
            {
                tab = tab + "#" + "\t";
            }
            return tab;
        }
        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            Matrix product = new Matrix(matrix1._rows, matrix2._columns);
            for (int row = 0; row < matrix1._rows; row++)
            {
                for (int column = 0; column < matrix2._columns; column++)
                {
                    for (int middle = 0; middle < matrix1._columns; middle++)
                    {
                        product.array[row, column] += matrix1.array[row, middle] * matrix2.array[middle, column];
                    }
                }
            }
            return product;
        }       
    }
}
