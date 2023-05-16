using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lr_8_11_Katskel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBoxA.Text, out double sideA) &
                    double.TryParse(textBoxB.Text, out double sideB) &
                    double.TryParse(textBoxC.Text, out double sideC))
                {
                    Triangle triangle = new Triangle(sideA, sideB, sideC);
                    label1.Text = triangle.Square().ToString("F3");
                    label2.Text = string.Format("{0:F3}",triangle.Perimeter());
                    triangle.Median(out double medianA, out double medianB, out double medianC);
                    label3.Text = $"Медиана А = {medianA:F3}\n\rМедиана Б = {medianB:F3}\n\rМедиана В = {medianC:F3}";
                }
                else { MessageBox.Show("Переделывай", "Не ввел данные", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex) { MessageBox.Show($"{ex.Message}"); }
        }
    }
}
