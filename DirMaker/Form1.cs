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

            names = new string[11] { "Антонов", "Гладких", "Грабарчук", "Давыдов", "Задорожний",
                                     "Коробка", "Лазаренко", "Павленко", "Петренко", "Поддуев", "Чернышов"};
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != String.Empty)
                path = textBox1.Text;
            else
                MessageBox.Show("ОШИБКА!!! Указан пустой путь!");

            if (Directory.Exists(path))
            {
                foreach (string student_name in names)
                {
                    Directory.CreateDirectory(path + "\\" + student_name);
                }
                MessageBox.Show("Готово! Создано папок: " + names.Length.ToString());
            }
            else
            {
                MessageBox.Show("ОШИБКА!!! Указан несуществующий путь!");
            }
        }
    }
}