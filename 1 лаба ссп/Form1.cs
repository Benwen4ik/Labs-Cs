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
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string a = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            var start = richTextBox1.SelectionStart;
            var startlen = richTextBox1.SelectionLength;
            if (richTextBox1.SelectionFont != null)
            {
                richTextBox1.SelectionFont = new Font(a, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
            } else
            {
                for (int k = 0; k < startlen; k++)
                {
                    richTextBox1.Select(start + k, 1);
                    richTextBox1.SelectionFont = new Font(a, richTextBox1.SelectionFont.Size, richTextBox1.SelectionFont.Style);
                }
                richTextBox1.SelectionStart = start;
                richTextBox1.SelectionLength = startlen;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null) {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size,
                        Use_BoldStyle());
            } else
            { 
                var start = richTextBox1.SelectionStart;
                var startlen = richTextBox1.SelectionLength;
                for (int k=0;k<startlen;k++)
                {
                    richTextBox1.Select(start + k, 1);
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size,
                        Use_BoldStyle());
                }
                richTextBox1.SelectionStart = start;
                richTextBox1.SelectionLength = startlen;
            }
        } 

        private void button2_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont != null)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, richTextBox1.SelectionFont.Size,
                        Use_ItalicStyle());
            } else
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int.TryParse(comboBox2.Text.ToString(), out int b);
            if (richTextBox1.SelectionFont != null )
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, b, richTextBox1.SelectionFont.Style);
            } else
            {
                var start = richTextBox1.SelectionStart;
                var startlen = richTextBox1.SelectionLength;
                for (int k=0; k< startlen; k++)
                {
                    richTextBox1.Select(start + k, 1);
                    richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, b, richTextBox1.SelectionFont.Style);
                }
                richTextBox1.SelectionStart = start;
                richTextBox1.SelectionLength = startlen;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = comboBox3.Items[comboBox3.SelectedIndex].ToString();
          //  var start = richTextBox1.SelectionStart;
         //   var startlen = richTextBox1.SelectionLength;
         //   for (int k = 0; k < startlen; k++)
          //  {
           //     richTextBox1.Select(start + k,1);
                switch (c)
                {
                    case "Черный":
                        richTextBox1.SelectionColor = System.Drawing.Color.Black;
                        button3.BackColor = System.Drawing.Color.White;
                        break;
                    case "Красный":
                        richTextBox1.SelectionColor = System.Drawing.Color.Red;
                        button3.BackColor = System.Drawing.Color.Red;
                    break;
                    case "Желтый":
                        richTextBox1.SelectionColor = System.Drawing.Color.Gold;
                        button3.BackColor = System.Drawing.Color.Gold;
                    break;
                    case "Синий":
                        richTextBox1.SelectionColor = System.Drawing.Color.Blue;
                        button3.BackColor = System.Drawing.Color.Blue;
                    break;
                    default:
                        richTextBox1.SelectionColor = System.Drawing.Color.Black;
                        button3.BackColor = System.Drawing.Color.White;
                    break;
                }

        //    }

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
                if (MyDialog.Color == Color.Black) button3.BackColor = Color.White;
                else button3.BackColor = MyDialog.Color;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(comboBox2.Items[comboBox2.SelectedIndex].ToString(), out int b);
            if (b > 5 && b < 72)
            {
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
            }
        }

        
    }
}
