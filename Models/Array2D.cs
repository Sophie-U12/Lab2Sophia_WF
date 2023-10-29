using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Sophia_WF.Models
{
    public class Array2D<T>
    {
        private T[,] array;
        private int lengthA;
        private int lengthB;

        public Array2D()
        {
            MyArray = new T[0, 0];
        }

        public Array2D(int size)
        {
            MyArray = new T[size, size];
        }
        public Array2D(int sizeA, int sizeB)
        {
            MyArray = new T[sizeA, sizeB];
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < lengthA; i++)
            {
                for (int j = 0; j < lengthB; j++)
                {
                    result += array[i, j].ToString() + (j < lengthB - 1 ? " " : "");
                }
                result += (i < lengthA - 1 ? "\n" : "");
            }
            return result;
        }

        public string GetAllArrayAsString()
        {
            return this.ToString();
        }

        public string GetElementAsString(int indexI, int indexJ)
        {
            return this[indexI, indexJ].ToString();
        }

        public T this[int indexI, int indexJ]
        {
            get
            {
                if (indexI < 0 || indexI >= lengthA) throw new IndexOutOfRangeException($"Index [{indexI}, {indexJ}] out of range [{lengthA}, {lengthB}]!");
                return array[indexI, indexJ];
            }
            set
            {
                if (indexI < 0 || indexI >= lengthA) throw new IndexOutOfRangeException($"Index [{indexI}, {indexJ}] out of range [{lengthA}, {lengthB}]!");
                array[indexI, indexJ] = value;
            }
        }

        public T[,] MyArray
        {
            get
            {
                return array;
            }
            set
            {
                array = value;
                lengthA = array.GetLength(0);
                lengthB = array.GetLength(1);
            }
        }
        public int LengthA { get => lengthA; }
        public int LengthB { get => lengthB; }
    }
}
