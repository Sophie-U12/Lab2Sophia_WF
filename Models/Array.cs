using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Sophia_WF.Models
{
    public class Array<T>
    {
        private T[] array;
        private int length;

        public Array()
        {
            MyArray = new T[0];
        }

        public Array(int size)
        {
            MyArray = new T[size];
        }

        public override string ToString()
        {
            string result = "";
            for(int i = 0; i < length; i++)
            {
                result += array[i].ToString() + (i < length - 1 ? " " : "");
            }
            return result;
        }

        public string GetAllArrayAsString()
        {
            return this.ToString();
        }

        public string GetElementAsString(int index)
        {
            return this[index].ToString();
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length) throw new IndexOutOfRangeException($"Index {index} out of range {length}!");
                return array[index];
            }
            set
            {
                if (index < 0 || index >= array.Length) throw new IndexOutOfRangeException($"Index {index} out of range {length}!");
                array[index] = value;
            }
        }

        public T[] MyArray {
            get 
            { 
                return array; 
            }
            set
            {
                array = value;
                length = array.Length;
            }
        }
        public int Length { get => length; }
    }
}
