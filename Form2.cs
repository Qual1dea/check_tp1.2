using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InputNumber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar >= '+' && e.KeyChar <= '-' || e.KeyChar == Convert.ToChar(8)))
                e.KeyChar = (char)0;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!(e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 || e.KeyCode >= Keys.Oemplus && e.KeyCode <= Keys.OemMinus || e.KeyCode == Keys.Back))
                e.SuppressKeyPress = true;               
        }

        private void CheckButton_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(InputNumber1.Text))
            {
                e.Cancel = true;
                InputNumber1.Focus();
                errorProvider1.SetError(InputNumber1, "Введите число");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(InputNumber1, null);
            }
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(InputNumber1.Text, "Окно заголовка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sbyte result = Convert.ToSByte(InputNumber1.Text);
                MessageBox.Show("Значение корректно"+result);
            }
            catch(FormatException)
            {
                MessageBox.Show("Неверный формат");
                InputNumber1.Focus();
            }
            catch(OverflowException)    
            {
                MessageBox.Show("Значение слишком большое/маленькое");
                InputNumber1.Text = "0";
            }
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            int pixelIsToMove = -25;
            textBoxLeft.Left = pixelIsToMove;
        }
    }
}
