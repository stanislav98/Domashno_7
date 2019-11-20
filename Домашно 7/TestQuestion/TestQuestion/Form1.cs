using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TestQuestion
{
    public partial class Form1 : Form
    {
        RadioButton[] buttons;
        public Form1()
        {
            InitializeComponent();           
            buttons = new[] { radioButton1, radioButton2, radioButton3,radioButton4 };
        }
        
        string[] questions = new string[]
        {   "What is 9 cubed?", "What is 6+4?",
        "What type of animal is tuna sandwiches made from?",
        "What is 19 backwards?","How many Tomb Raider movies were made?",
        "In which country were the first Olympic Games held?","What is the name of the Barcelona football stadium ?"

        };
        string[] answers = new string[] {

            "9", "81", "729", "2",
            "4", "2", "10", "1",
            "zebra", "aardvark", "fish", "gnu",
            "31", "81", "91", "88",
            "Two movies","Three movies","One movies","None",
            "Greece","France","Turkey","Surbia",
            "Camp Nou","Vasil Levski","Uembli","Santiago Bernabeu"
          };
        string[] quizAnswers = new string[] { "729", "10", "aardvark", "91","Two movies","Greece", "Camp Nou" };
        int i = 1;
        int begin = 4;
        int brr = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
          
            label1.Text = questions[0];         
            buttons[0].Text = answers[0];
            buttons[1].Text = answers[1];
            buttons[2].Text = answers[2];
            buttons[3].Text = answers[3];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string ans = " ";
                foreach (var ctrl in buttons.Where(w => w.Checked))
                {
                    ans = ctrl.Text;

                }
                foreach(var r in quizAnswers)
                {
                if (ans == r)
                {
                    MessageBox.Show("Correct", "ANSEWR", MessageBoxButtons.OK, MessageBoxIcon.None);
                    brr++;
                    textBox1.Text = brr.ToString();

                }
               
               /* else
                {
                    MessageBox.Show("WRONG", "Answer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
            if (brr == 7)
            {
                MessageBox.Show(" You finish the Test with 7 from 7 correct answers", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.Image = Image.FromFile("C:\\Users\\Nitro\\Desktop\\resize_on_the_fly.jpg");
                button3.Show();
                button2.Hide();
                button1.Hide();
            }
            else if (label1.Text == questions.Last())
            {
                MessageBox.Show("End of the Test");
                button3.Show();
                button2.Hide();
                button1.Hide();
            }
            else
            {
                button2.Show();
                button1.Hide();
            }

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            

            label1.Text = questions[i++];
            int end = begin + 4;
            int index = 0;        
            for(int i=begin;i<end;i++)
            {
                buttons[index].Text = answers[i];
                index++;
                
            }
            begin+=4;

            button1.Show();
            button2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();
            NewForm.Show();
            this.Dispose(false);
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
