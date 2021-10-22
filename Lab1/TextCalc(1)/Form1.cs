using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextCalc_1_
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)//количество согласных
        {
            string[] textMass = textBox1.Text.Split('й', 'ц', 'к', 'н', 'г', 'ш', 'щ', 'з', 'х', 'ф', 'в', 'п', 'р', 'л', 'д', 'ж', 'ч', 'с', 'м', 'т', 'б', 'ь', 'ъ');
            textBox6.Text = (textMass.Length - 1).ToString() + " согласных букв";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//ввод строки
        {
           

        }

        private void button8_Click(object sender, EventArgs e)//количество слов в строке
        {
            int f;
            string[] textMass = textBox1.Text.Split(' ');
            f = textMass.Length;
            if(textBox1.Text=="")
                f--;
            textBox6.Text = f.ToString() + " слов";
        }

      
        private void button9_Click(object sender, EventArgs e)//удаление всей строки
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)//замена
        {
            textBox4.Text = "Введите подстроку, которую нужно заменить";
            textBox5.Text = "Введите замену для подстроки";
            textBox6.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)//удаление
        {

            textBox4.Text = "Введите удаляемую подстроку";
            textBox6.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)//получение индекса
        {
            textBox4.Text = "Введите индекс символа";
            textBox6.Text = "";
            textBox3.Text = "";
            textBox2.Text = "";
            textBox5.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)//количество гласных
        {
            string[] textMass = textBox1.Text.Split('а', 'о', 'у', 'ы', 'э', 'и', 'я', 'ю', 'е', 'ё');
            textBox6.Text = (textMass.Length - 1).ToString() + " гласных букв";
        }

        private void button7_Click(object sender, EventArgs e)//количество предложений
        {
            string[] textMass2 = textBox1.Text.Split('.');
            textBox6.Text = (textMass2.Length - 1).ToString() + " предложений";
          
        }

      
        private void button4_Click_1(object sender, EventArgs e)//длинна строки
        {
            textBox6.Text = "длина строки - " + textBox1.Text.Length.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = textBox1.Text.Replace(textBox2.Text, textBox3.Text);
            }
            catch { }
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                textBox6.Text = textBox1.Text.Replace(textBox2.Text, "***");
            }
            catch { }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try { int i = Convert.ToInt32(textBox2.Text);
            textBox6.Text = textBox1.Text[i - 1].ToString();
            i = 0;}
            catch{ }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
        }
    }
}
