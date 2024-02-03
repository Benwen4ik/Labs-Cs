using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_лаба_ссп
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            String[] font = new string[] { "Segoe UI", "Arial", "Times New Roman", "Segoe Script" };
            String[] size = new string[] { "9", "12", "15", "18" };
            String[] colors = new string[] { "Черный", "Красный", "Желтый", "Синий" };
            InitializeComponent();
            comboBox1.Items.AddRange(font); 
            comboBox2.Items.AddRange(size);
            comboBox3.Items.AddRange(colors);
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // label1.Text = textBox1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            textBox1.Font = new Font(a, textBox1.Font.Size,textBox1.Font.Style);
            richTextBox1.SelectionFont = new Font(a, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Font currentfont = richTextBox1.SelectionFont;
            if (textBox1.Font.Bold == false)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Bold);
                richTextBox1.SelectionFont = new Font(currentfont, FontStyle.Bold);
                button1.BackColor = System.Drawing.Color.DarkGray; 
            }
            else
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Regular);
                richTextBox1.SelectionFont = new Font(currentfont , FontStyle.Regular);
                button1.BackColor = System.Drawing.Color.White ;
            }
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            Font currentfont = richTextBox1.SelectionFont;
            if (textBox1.Font.Italic == false)
            {
                textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Italic);
                richTextBox1.SelectionFont = new Font(currentfont, FontStyle.Italic);
                button2.BackColor = System.Drawing.Color.DarkGray;
            }
            else { textBox1.Font = new Font(textBox1.Font.FontFamily, textBox1.Font.Size, FontStyle.Regular);
                richTextBox1.SelectionFont = new Font(currentfont, FontStyle.Regular);
                button2.BackColor = System.Drawing.Color.White;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse ( comboBox2.Items[comboBox2.SelectedIndex].ToString(), out int b);
            textBox1.Font = new Font(textBox1.Font.FontFamily, b, textBox1.Font.Style);
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, b, richTextBox1.SelectionFont.Style);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = comboBox3.Items[comboBox3.SelectedIndex].ToString();
            switch (c)
            {
                case "Черный":
                    textBox1.ForeColor = System.Drawing.Color.Black;
                    //richTextBox1.ForeColor = System.Drawing.Color.Black;
                    richTextBox1.SelectionColor = System.Drawing.Color.Black;
                    break;
                case "Красный":
                    textBox1.ForeColor = System.Drawing.Color.Red;
                    //richTextBox1.ForeColor = System.Drawing.Color.Red;
                    richTextBox1.SelectionColor = System.Drawing.Color.Red;
                    break;
                case "Желтый":
                    textBox1.ForeColor = System.Drawing.Color.Gold;
                    // richTextBox1.ForeColor = System.Drawing.Color.Gold;
                    richTextBox1.SelectionColor = System.Drawing.Color.Gold;
                    break;
                case "Синий":
                    textBox1.ForeColor = System.Drawing.Color.Blue;
                    // richTextBox1.ForeColor = System.Drawing.Color.Blue;
                    richTextBox1.SelectionColor = System.Drawing.Color.Blue;
                    break;
                default :
                    textBox1.ForeColor = System.Drawing.Color.Black;
                    // richTextBox1.ForeColor = System.Drawing.Color.Black;
                    richTextBox1.SelectionColor = System.Drawing.Color.Black;
                    break;
            }
            
        }

        private void textBox1_FontChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
       
        }

        bool isBoldEnabled = false; // Переменная для отслеживания состояния переключателя "Жирный/Не жирный"


       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
