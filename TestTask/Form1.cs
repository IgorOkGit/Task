using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;

            //Розділення речень на слова

            string[] words = text.Split(' ');

            //Ствоерння змінної для прийняття унікальних символів з слова
            List<char> chars = new List<char>();

            //Змінна для прийняття унікального символу
            char uniqueSymbol;

            //Цикл для перевірки кожного слова

            for (int i = 0; i < words.Length; i++)
            {   
                
                //Розбивання слова на символи
                char[] charsinword = words[i].ToArray();



                // Цикл для перевірки неповторюваності символів у слові

                for (int j = 1; j < charsinword.Length; j++)
                {

                    char currentChar = charsinword[j];
                    // Перевірка на неповторюваність символу у слові
                    if (!chars.Contains(currentChar) && charsinword.Count(c => c == currentChar) == 1)
                    {
                        chars.Add(charsinword[0]);
                        break;

                    }
                    

                    
                }


            }

            //Цикл на перевірку унікальності одного символу з масиву
                foreach (char symbol in chars)
                {

                if (chars.Count(s => s == symbol) == 1)
                    {
                        uniqueSymbol = symbol;
                        MessageBox.Show(uniqueSymbol.ToString());
                        break;
                    }
                }



        }

    }
}
