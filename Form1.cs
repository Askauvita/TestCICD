using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2___Part_1_Cesar
{
    public partial class Form1 : Form
    {
        string engLangDictionary = "abcdefghijklmnopqrstuvwxyz0123456789";
        string rusLangDictionary = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя0123456789";
        string alphabet;
        public Form1()
        {
            InitializeComponent();
            //EncryptTextBox.TextChanged += new EventHandler(EncryptTextBox_TextChanged);
            //key.TextChanged += new EventHandler(KeyTextBox_TextChanged);
            russian.CheckedChanged += new EventHandler(Language_CheckedChanged);
        }

        private void Language_CheckedChanged(object sender, EventArgs e)
        {
            if (russian.Checked)
                alphabet = rusLangDictionary;
            else
                alphabet = engLangDictionary;
            foreach (char v in breakingTextBox.Text)
            {
                if (alphabet.IndexOf(v) == -1)
                { MessageBox.Show("Текст сообщения содержит недопустимые символы выбранного алфавита."); return; }
            }
        }

        private void breaking_Click(object sender, EventArgs e)
        {
            if (breakingTextBox.Text == String.Empty)
                return;
            int originalkey;
            string textToDecrypt = breakingTextBox.Text.ToLower();
            string resText = "";

            Dictionary<char, int> countOfLetters = new Dictionary<char, int>();
             
            foreach (char c in textToDecrypt)
            {
                if (countOfLetters.ContainsKey(c))
                    countOfLetters[c] += 1;
                else if (Char.IsLetterOrDigit(c))
                    countOfLetters.Add(c, 1);
            }


            if (russian.Checked)
                originalkey = alphabet.IndexOf(GetDefinedSymbol(countOfLetters)) - alphabet.IndexOf('о');
            else
                originalkey = alphabet.IndexOf(GetDefinedSymbol(countOfLetters)) - alphabet.IndexOf('e');

            foreach (char c in textToDecrypt)
            {
                if (Char.IsLetterOrDigit(c))
                {
                    if (alphabet.IndexOf(c) == -1)
                    {
                        MessageBox.Show("Исходный текст содержит недопустимые символы выбранного алфавита.");
                        return;
                    }
                    resText += alphabet[Math.Abs(alphabet.IndexOf(c) - originalkey + alphabet.Length) % alphabet.Length];
                }
                else resText += c;
            }

            resultTextBox.Text = resText;
            keyTextBox.Text = originalkey.ToString();
        }

        private char GetDefinedSymbol(IDictionary<char,int> checkList)
        {
            return checkList.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ((RadioButton)Language.Controls[0]).Checked = true;
            breakingTextBox.Focus();
            alphabet = rusLangDictionary;
           
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = openFileDialog1.FileName;

            string fileText = System.IO.File.ReadAllText(filename);
            breakingTextBox.Text = fileText;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultTextBox.Clear();
            breakingTextBox.Clear();
            keyTextBox.Clear();
        }
    }
}
