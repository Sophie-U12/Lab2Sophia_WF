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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void array1dTSMI_Click(object sender, EventArgs e)
        {
            Array1DForm array1DForm = new Array1DForm();
            array1DForm.ShowDialog();
        }

        private void array2dTSMI_Click(object sender, EventArgs e)
        {
            Array2DForm array2DForm = new Array2DForm();
            array2DForm.ShowDialog();
        }
    }
}
