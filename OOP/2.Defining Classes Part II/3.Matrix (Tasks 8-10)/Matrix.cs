using System;
using System.Text;

namespace Matrix
{
    class Matrix<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T> 
    // Task 8
    {
        private readonly T[,] matrix;

        public Matrix(int rows, int cols)
        {
            matrix = new T[rows, cols];
        }
        public Matrix(T[,] matrix)
        {
            this.matrix = matrix;
        }

        public int Rows
        {
            get { return matrix.GetLength(0); }
        }

        public int Cols
        {
            get { return matrix.GetLength(1); }
        }
        // Task 9
        public T this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= Rows || col < 0 || col >= Cols)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return matrix[row, col];
                }
            }
            set
            {
                if (row < 0 || row >= Rows || col < 0 || col >= Cols)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    matrix[row, col] = value;
                }
            }
        }
        // Task 10
        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows == second.Rows && first.Cols == second.Cols)
            {
                Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);
                for (int i = 0; i < first.Rows; i++)
                {
                    for (int j = 0; j < first.Cols; j++)
                    {
                        result[i, j] = (dynamic)first[i, j] + (dynamic)second[i, j];
                    }
                }
                return result;
            }
            else
            {
                throw new System.ArgumentException("To add matrixes, they must be with same dimentions");
            }
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows == second.Rows && first.Cols == second.Cols)
            {
                Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);
                for (int i = 0; i < first.Rows; i++)
                {
                    for (int j = 0; j < first.Cols; j++)
                    {
                        result[i, j] = (dynamic)first[i, j] - (dynamic)second[i, j];
                    }
                }
                return result;
            }
            else
            {
                throw new System.ArgumentException("To substract matrixes, they must be with same dimentions");
            }
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Cols != second.Rows)
            {
                throw new System.ArgumentException("To multiply matrixes, rows of first must be same as columns of second");
            }
            else
            {
                Matrix<T> result = new Matrix<T>(first.Rows, second.Cols);
                for (int i = 0; i < result.Rows; i++)
                {
                    for (int j = 0; j < result.Cols; j++)
                    {
                        for (int k = 0; k < first.Cols; k++)
                        {
                            result[i, j] += (dynamic)first[i, k] * (dynamic)second[k, j];
                        }
                    }
                }
                return result;
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool isNonZero = true;
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        isNonZero = false;
                    }
                }
            }
            return isNonZero;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool isNonZero = true;
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if ((dynamic)matrix[i, j] == 0)
                    {
                        isNonZero = false;
                    }
                }
            }
            return isNonZero;
        }

        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (j == 0)
                    {
                        print.Append("|".PadRight(3));
                    }
                    print.Append(Convert.ToString(this.matrix[i, j]).PadRight(3));
                    print.Append("|".PadRight(3));
                }
                print.Append("\n");
            }
            return print.ToString();
        }
    }
}
