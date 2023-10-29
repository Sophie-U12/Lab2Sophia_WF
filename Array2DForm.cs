using Lab2Sophia_WF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2Sophia_WF
{
    public partial class Array2DForm : Form
    {
        private Array2D<int> _array;
        private Random _rnd;
        public Array2DForm()
        {
            InitializeComponent();
            _array = new Array2D<int>();
            _rnd = new Random();
        }

        private void btnFillArray_Click(object sender, EventArgs e)
        {
            _array = new Array2D<int>((int)nudN.Value);
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            dataGridView1.RowCount = _array.LengthA;
            dataGridView1.ColumnCount = _array.LengthB;

            for (int i = 0; i < _array.LengthA; i++)
            {
                for(int j = 0; j < _array.LengthB; j++)
                {
                    _array[i, j] = _rnd.Next(-10, 10 + 1);
                    dataGridView1[i, j].Value = _array[i, j];
                }
            }

        }

        private int GetCalculate(Array2D<int> array)
        {
            int count = 0;
            for(int i = 0; i < array.LengthA; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if (array[i, j] > 0) count++;
                }
            }

            return count;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (_array.LengthA > 0 && _array.LengthB > 0)
            {
                MessageBox.Show($"Кількість додатних елементів вище лівої діагоналі: {GetCalculate(_array)}",
                    "Реузльтат!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Масив не заповнений! З початку заповніть масив!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
