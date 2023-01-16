using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Manipulation
{
    public partial class FrmStringManipulation : Form
    {
        public FrmStringManipulation()
        {
            InitializeComponent();
        }

        private void BtnLength_Click(object sender, EventArgs e)
        {
            //Length
            TxtResult.Text = TxtInput.Text.Length.ToString();
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            //Substring After 4
            TxtResult.Text = TxtInput.Text.Substring(4);
        }

        private void BtnSubstring34_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtInput.Text.Substring(3,4);
        }

        private void BtnStartsWith_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtInput.Text.StartsWith("1").ToString();
        }

        private void BtnEndswith_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtInput.Text.EndsWith("9").ToString();
        }

        private void BtnIndexof3_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtInput.Text.IndexOf("3").ToString();
        }

        private void BtnToupper_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtInput.Text.ToUpper();
        }

        private void BtnTolower_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtInput.Text.ToLower();
        }

        private void BtnReplace_Click(object sender, EventArgs e)
        {
            TxtResult.Text = TxtInput.Text.Replace("1", "9");
        }

        private void BtnVowels_Click(object sender, EventArgs e)
        {
            int count = 0;
            string sentence = TxtInput.Text;
            int length = sentence.Length;
            for (int i = 0; i < length; i++)
            {
                string vowelCheck = sentence.Substring(i,1);
                if(vowelCheck=="a" || vowelCheck == "e" || vowelCheck == "i" || vowelCheck == "o" || vowelCheck == "u" || vowelCheck == "A" || vowelCheck == "E" || vowelCheck == "I" || vowelCheck == "O" || vowelCheck == "U")
                {
                    count++;
                }
            }
            MessageBox.Show($"There Are {count} Vowels In This Sentence");
        }

        //BtnSplit This Will Split 
        private void button1_Click(object sender, EventArgs e)
        {
            //int v; 
            string sentence = TxtInput.Text;
            int length = sentence.Length;
            for (int i = 0; i < length; i++)
            {
                string letter = sentence.Substring(i, 1);
                if(letter == ",")
                {
                    MessageBox.Show("First Part Before Comma");
                    string first = sentence.Substring(0 , i);
                    MessageBox.Show(first);
                    MessageBox.Show("After Comma");
                    string second = sentence.Substring(i+1);
                    MessageBox.Show(second);
                }
            }
        }
        private void BtnNoofthe_Click(object sender, EventArgs e)
        {
            int count = 0;
            string sentence = TxtInput.Text;
            int length = sentence.Length;
            
            for (int i = 0; i < length-4; i++)
            {
                string letter = sentence.Substring(i, 5);
                if (letter == " the " || letter == " The " || letter == "The " || letter == "the " || letter == " The" || letter == " the")
                {
                    count++;
                }
            }
            MessageBox.Show($"No of The: {count}");
        }
    }
}
