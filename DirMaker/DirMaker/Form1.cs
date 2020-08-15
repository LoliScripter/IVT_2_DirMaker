using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DirMaker
{
    public partial class Form1 : Form
    {
        string path = "";
        string[] names;

        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != String.Empty && textBox2.Text != String.Empty)
            {
                path = textBox1.Text;
                names = textBox2.Text.Split(' ', ',');

                if (Directory.Exists(path))
                {
                    foreach (string folder_name in names)
                    {
                        Directory.CreateDirectory(path + "\\" + folder_name);
                    }
                    MessageBox.Show("Готово!");
                }
                else
                {
                    MessageBox.Show("ОШИБКА!!! Указан несуществующий путь!");
                }
            }
            else
            {
                MessageBox.Show("ОШИБКА!!! Указан пустой путь, пустая строка или неверный разделитель!");
            }  
        }
    }
}