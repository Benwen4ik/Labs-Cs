using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.Json;

namespace _1_лаба_ссп
{
    public partial class Form1 : Form
    {
        String[] font =  { "Segoe UI", "Arial", "Times New Roman", "Segoe Script", "Tahoma" };

        Font lastFont = new Font("Segoe UI",9);
        Color lastColor = Color.Black;


        List<Font> listfont = new List<Font> { };
        int combobox2;

        static string path1 = @"C:\note.txt";   // путь к файлу
        static string path2 = @"C:\set.txt";
      
        public Form1()
        {

            //String[] font = new string[] { "Segoe UI", "Arial", "Times New Roman", "Segoe Script", "Broadway", "Tahoma" };
            InitializeComponent();
            comboBox1.Items.AddRange(font);
            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
            richTextBox1.SelectionChanged += richTextBox1_SelectionChanged;
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            // saveFileDialog.Filter = 
        } 
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (comboBox1.Items == null) comboBox1.SelectedIndex = 0;
            // string a = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            string a = font[comboBox1.SelectedIndex].ToString();
            var start = richTextBox1.SelectionStart;
            var startlen = richTextBox1.SelectionLength;
            if (richTextBox1.SelectionFont != null)
            {
                richTextBox1.SelectionFont = new Font(a, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
            }
            else
            {
                for (int k = 0; k < startlen; k++)
                {
                    richTextBox1.Select(start + k, 1);
                    richTextBox1.SelectionFont = new Font(a, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
                }
                richTextBox1.SelectionStart = start;
                richTextBox1.SelectionLength = startlen;
            }
            richTextBox1.Focus();
            if (richTextBox1.Text.Length != 0)
            {
                lastFont = richTextBox1.SelectionFont;
              //  listfont.Add(richTextBox1.SelectionFont);
               // combobox2++;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size,
                        Use_BoldStyle());
            }
            else
            {
                var start = richTextBox1.SelectionStart;
                var startlen = richTextBox1.SelectionLength;
                for (int k = 0; k < startlen; k++)
                {
                    richTextBox1.Select(start + k, 1);
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size,
                        Use_BoldStyle());
                }
                richTextBox1.SelectionStart = start;
                richTextBox1.SelectionLength = startlen;
            }
            richTextBox1.Focus();
            if (richTextBox1.Text.Length != 0)
            {
                lastFont = richTextBox1.SelectionFont;
              //  listfont.Add(richTextBox1.SelectionFont);
              //  combobox2++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size,
                Use_ItalicStyle());
            }
            else
            {
                var start = richTextBox1.SelectionStart;
                var startlen = richTextBox1.SelectionLength;
                for (int k = 0; k < startlen; k++)
                {
                    richTextBox1.Select(start + k, 1);
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size,
                    Use_ItalicStyle());
                }
                richTextBox1.SelectionStart = start;
                richTextBox1.SelectionLength = startlen;
            }
            richTextBox1.Focus();
            if (richTextBox1.Text.Length != 0)
            {
                lastFont = richTextBox1.SelectionFont;
              //  listfont.Add(richTextBox1.SelectionFont);
             //   combobox2++;
            }
        }

        private FontStyle Use_BoldStyle()
        {
            if (richTextBox1.SelectionFont.Italic == false)
            {
                if (richTextBox1.SelectionFont.Bold == false)
                {
                    button1.BackColor = System.Drawing.Color.DarkGray;
                    return FontStyle.Bold;
                }
                else
                {
                    button1.BackColor = System.Drawing.Color.White;
                    return FontStyle.Regular;
                }
            }
            else
            {
                if (richTextBox1.SelectionFont.Bold == false)
                {
                    button1.BackColor = System.Drawing.Color.DarkGray;
                    return FontStyle.Bold | FontStyle.Italic;
                }
                else
                {
                    button1.BackColor = System.Drawing.Color.White;
                    return FontStyle.Italic;
                }
            }
        }

        private FontStyle Use_ItalicStyle()
        {
            if (richTextBox1.SelectionFont.Bold == false)
            {
                if (richTextBox1.SelectionFont.Italic == false)
                {
                    button2.BackColor = System.Drawing.Color.DarkGray;
                    return FontStyle.Italic;
                }
                else
                {
                    button2.BackColor = System.Drawing.Color.White;
                    return FontStyle.Regular;
                }
            }
            else
            {
                if (richTextBox1.SelectionFont.Italic == false)
                {
                    button2.BackColor = System.Drawing.Color.DarkGray;
                    return FontStyle.Bold | FontStyle.Italic;
                }
                else
                {
                    button2.BackColor = System.Drawing.Color.White;
                    return FontStyle.Bold;
                }
            }

        }   

        private void button3_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();
            MyDialog.AllowFullOpen = false;
            MyDialog.ShowHelp = true;
            MyDialog.Color = richTextBox1.SelectionColor;

            if (MyDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = MyDialog.Color;
                if (MyDialog.Color == Color.Black)
                {
                    button3.BackColor = Color.Black;
                    button3.ForeColor = Color.White;
                }
                else
                {
                    button3.BackColor = MyDialog.Color;
                    button3.ForeColor = Color.Black;
                }
            }
            richTextBox1.Focus();
            // lastFont = richTextBox1.SelectionFont;
            if (richTextBox1.Text.Length != 0)
            {
                lastColor = richTextBox1.SelectionColor;
             //   listfont.Add(richTextBox1.SelectionFont);
              //  combobox2++;
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            int.TryParse(textBox1.Text.ToString(), out int b);
            if (b < 9)
            {
                MessageBox.Show(textBox1, "Допустимые значение размера шрифта 9-45");
                b = ((int)richTextBox1.SelectionFont.Size);
            }
            if (b > 45)
            {
                MessageBox.Show(textBox1, "Допустимые значение размера шрифта 9-45");
                b = ((int)richTextBox1.SelectionFont.Size);
            }
            if (richTextBox1.SelectionFont != null)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, b, richTextBox1.SelectionFont.Style);
            }
            else
            {
                var start = richTextBox1.SelectionStart;
                var startlen = richTextBox1.SelectionLength;
                for (int k = 0; k < startlen; k++)
                {
                    richTextBox1.Select(start + k, 1);
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, b, richTextBox1.SelectionFont.Style);
                }
                richTextBox1.SelectionStart = start;
                richTextBox1.SelectionLength = startlen;
            }
            richTextBox1.Focus();
            if (richTextBox1.Text.Length != 0)
            {
                lastFont = richTextBox1.SelectionFont;
              //  listfont.Add(richTextBox1.SelectionFont);
              //  combobox2++;
            }
        }
        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                textBox1.Text = richTextBox1.SelectionFont.Size.ToString(); // Update the TextBox with the font size

                if (richTextBox1.SelectionColor == Color.Black)
                {
                    button3.BackColor = Color.Black;
                    button3.ForeColor = Color.White;
                }
                else
                {
                    button3.BackColor = richTextBox1.SelectionColor;
                    button3.ForeColor = Color.Black;
                }
                if (Array.IndexOf(font, richTextBox1.SelectionFont.Name.ToString()) != -1)
                {
                    comboBox1.SelectedIndex = Array.IndexOf(font, richTextBox1.SelectionFont.Name.ToString());
                }
                if (richTextBox1.SelectionFont.Bold == true) button1.BackColor = System.Drawing.Color.DarkGray;
                else button1.BackColor = System.Drawing.Color.White;
                if (richTextBox1.SelectionFont.Italic == true) button2.BackColor = System.Drawing.Color.DarkGray;
                else button2.BackColor = System.Drawing.Color.White;
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            if (richTextBox1.Text.Length == 0)
            {
                richTextBox1.SelectionFont = lastFont;
                richTextBox1.SelectionColor = lastColor;
                ChangedParam(lastFont, lastColor);
            }

        }

        private void ChangedParam(Font changeFont, Color color)
        {
            if (changeFont != null)
            {
                textBox1.Text = changeFont.Size.ToString();
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily,changeFont.Size);
                if (color == Color.Black)
                {
                    button3.BackColor = Color.Black;
                    button3.ForeColor = Color.White;
                }
                else
                {
                    button3.BackColor = color;
                    button3.ForeColor = Color.Black;
                }
                if (Array.IndexOf(font, changeFont.Name.ToString()) != -1)
                {
                    comboBox1.SelectedIndex = Array.IndexOf(font, changeFont.Name.ToString());
                }
                if (changeFont.Bold == true) button1.BackColor = System.Drawing.Color.DarkGray;
                else button1.BackColor = System.Drawing.Color.White;
                if (changeFont.Italic == true) button2.BackColor = System.Drawing.Color.DarkGray;
                else button2.BackColor = System.Drawing.Color.White;
                if (richTextBox1.Text.Length != 0)
                {
                    //lastFont = richTextBox1.SelectionFont;
                    // lastColor = button3.BackColor;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = comboBox2.SelectedIndex;
            ChangedParam(listfont[a], Color.Black);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (FileStream fstream = File.OpenRead(path1))
            {
                // выделяем массив для считывания данных из файла
                byte[] buffer = new byte[fstream.Length];
                // считываем данные
                fstream.Read(buffer);
                // декодируем байты в строку
                string textFromFile = UTF32Encoding.Default.GetString(buffer);
                richTextBox1.Text = textFromFile;
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (FileStream fstream = new FileStream(path1, FileMode.Truncate))
            {
                // преобразуем строку в байты
                byte[] buffer = Encoding.Default.GetBytes(richTextBox1.Text);
                // запись массива байтов в файл
                fstream.Write(buffer, 0, buffer.Length);
            }
            using (FileStream fstream = new FileStream(path2, FileMode.Truncate))
            {
                // преобразуем строку в байты
                string jsonString = JsonSerializer.Serialize(listfont);
                byte[] buffer = Encoding.Default.GetBytes(jsonString);
                // запись массива байтов в файл
                fstream.Write(buffer);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length != 0)
            {
                listfont.Add(richTextBox1.SelectionFont);
                combobox2++;
                comboBox2.Items.Add("Стиль" + combobox2);
            }
        }
    }
}
