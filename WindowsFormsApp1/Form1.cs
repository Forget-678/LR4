using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtX.Text, out double x))
            {
                MessageBox.Show("Пожалуйста, введите корректное число для x", "Ошибка ввода",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtX.Focus();
                return;
            }

            if (!double.TryParse(txtY.Text, out double y))
            {
                MessageBox.Show("Пожалуйста, введите корректное число для y", "Ошибка ввода",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtY.Focus();
                return;
            }

            double xRad = x * Math.PI / 180.0;
            double yRad = y * Math.PI / 180.0;

            double result = (5 * Math.Sin(xRad) + 3 * Math.Cos(yRad)) * 5;
            lblResult.Text = $"Результат: {result:F4}";
        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
