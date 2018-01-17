using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // Crearte a andom object "randomNum" and generate random number
        Random randomNum = new Random();

        int addend1, addend2;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void StartQuiz()
        {
            addend1 = randomNum.Next(51);
            addend2 = randomNum.Next(51);
    

            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            sum.Value = 0;

            int addition = addend1 + addend2;
            if (addition == sum.Value)
            {
                MessageBox.Show("Excellent");
            }
        }
    }
}
