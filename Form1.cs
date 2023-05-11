using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            BackgroundImage = Image.FromFile(@"C:\\Users\\Asus\\Desktop\\MafuMafu\\375f5df555cc3a150c4bb4013708c906.jpg");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox1.Location = new Point(10, 10);  // координаты положения элемента на форме
            textBox1.Size = new Size(100, 100);     //размеры элемента
            textBox1.Width = 100;   //ширину элемента
            textBox1.Height = 20;   //высота элемента
            textBox1.Top = 10;      //вертикальную координату элемент
            textBox1.Left = 10;     //горизонтальную координату элемента
            textBox1.BackColor = Color.Black;   //цвет фона элемента
            textBox1.ForeColor = Color.White;   //цвет текста в элементе
            textBox1.Font = new Font("Time New Roman", 12, FontStyle.Bold); //шрифт и стиль текста
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.UseWaitCursor = false ; //тупая загрузка мыши
            button1.FlatStyle = FlatStyle.Flat; //стиль кнопки button1 на "плоский"
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            //double operand1 = double.Parse(textBox1.Text);
            //double operand2 = double.Parse(textBox2.Text);
            //string operation = textBox3.Text;

            string operand1Str = textBox1.Text.Trim();  //Trim() удаляет любые начальные или конечные пробелы
            string operand2Str = textBox2.Text.Trim();
            string operation = textBox3.Text.Trim();
            
            double operand1 = double.Parse(operand1Str);    //Parse - это метод  преобразует строковое в числовое
            double operand2 = double.Parse(operand2Str);
            operation = operation.Replace("x", "*"); //заменяет  "x" на "*"

            double result;  

            if (operation == "+")
            {
                result = operand1 + operand2;
            }
            else if (operation == "-")
            {
                result = operand1 - operand2;
            }
            else if (operation == "*")
            {
                result = operand1 * operand2;
            }
            else if (operation == "/")
            {
                if (operand2 == 0)
                {
                    MessageBox.Show("Деление на ноль невозможно.");
                    return;
                }
                result = operand1 / operand2;
            }
            else
            {
                MessageBox.Show("Некорректная операция.");
                return;
            }

            label1.Text = result.ToString();
        }
    }
}
