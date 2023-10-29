using Lab2Sophia_WF.Models;
using Lab2Sophia_WF.Models.Enums;
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
    public partial class Array1DForm : Form
    {
        private Random _rnd;
        private Array<Wind> _array;
        public Array1DForm()
        {
            InitializeComponent();
            _rnd = new Random();
            _array = new Array<Wind>();
        }

        private void btnFillArray_Click(object sender, EventArgs e)
        {
            _array = new Array<Wind>((int)nudN.Value);
            dataGridView1.Rows.Clear();

            for(int i = 0; i < _array.Length; i++)
            {
                _array[i] = new Wind((WindDirection)_rnd.Next((int)WindDirection.North, (int)WindDirection.East + 1),
                    Math.Round(_rnd.Next(20) + _rnd.NextDouble(), 2));
                dataGridView1.Rows.Add(_array[i].ToString());
            }

        }

        private int GetCalculate(Array<Wind> array)
        {
            int count = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i].Direction == WindDirection.South && array[i].Power > 8d)
                {
                    count++;
                }
            }

            return count;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if(_array.Length > 0)
            {
                MessageBox.Show($"Кількість днів коли дув південний вітер з силою, що перевищує 8 м / с: {GetCalculate(_array)}",
                    "Реузльтат!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Масив не заповнений! З початку заповніть масив!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
