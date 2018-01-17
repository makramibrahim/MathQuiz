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
        // create some variables to store numbers
        int timer = 30;
        int numAddition1, numAddition2;
        int numSubtract1, numSubtract2;
        int numMultiply1, nunMultiply2;
        int numDivision1, numDivision2;
        int numModule1, numModule2;
        int numGreater1, numGreater2;
       
        int plus, times, divided, multiply, module, greateThan;

        /**************************************
         * Display the Form quiz on the screen.
         **************************************/
        public Form1()
        {
            InitializeComponent();
            timeLabel.Text = "30 Seconds";
        }

        private void Form1_Load(object sender, EventArgs e) {}
    
        /********************************************
         * StartButton(): On click the quiz will start.
         *******************************************/
        private void StartQuiz_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
        }

        /*******************************************
         * RandomNumber(): Generates a random number.
         *******************************************/
        public void RandomNumber()
        {
            Random randomNum = new Random();

            numAddition1 = randomNum.Next(51);
            numAddition2 = randomNum.Next(51);

            numSubtract1 = randomNum.Next(101);
            numSubtract2 = randomNum.Next(101);

            numMultiply1 = randomNum.Next(51);
            nunMultiply2 = randomNum.Next(51);

            numDivision1 = randomNum.Next(51);
            numDivision2 = randomNum.Next(51);

            numModule1 = randomNum.Next(51);
            numModule2 = randomNum.Next(51);

            numGreater1 = randomNum.Next(51);
            numGreater2 = randomNum.Next(51);

            plusLeft.Text = numAddition1.ToString();
            plusRight.Text = numAddition2.ToString();

            minuesLeft.Text = numSubtract1.ToString();
            minuesRight.Text = numSubtract2.ToString();

            timesLeft.Text = numMultiply1.ToString();
            timesRight.Text = nunMultiply2.ToString();

            dividedLeft.Text = numDivision1.ToString();
            dividedRight.Text = numDivision2.ToString();

            modLeft.Text = numModule1.ToString();
            modRight.Text = numModule2.ToString();

            greaterLeft.Text = numGreater1.ToString();
            greaterRight.Text = numGreater2.ToString();

        }

        /******************************************
         * Quiz(): Start the quiz from here
         ****************************************/
        public void StartTheQuiz()
        {
            // call random number function here.
            RandomNumber();

            plus = numAddition1 + numAddition2;




            timer = 30;
            sum.Value = 0;
            timer1.Start();

        }
        /*************************************************
         * Timer(): Will start to countdown from 30 seconds.
         ************************************************/
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("You passed the test!");
                startButton.Enabled = true;

            }
            
            else if (timer > 0)
            {
                timer --;
               
                timeLabel.Text = timer + " seconds";
            } 
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time is Up!";
                MessageBox.Show("Sorr! You didn't finish in time");
                sum.Value =  plus;
                startButton.Enabled = true;

            }

        }

        /**************************************************
         * Check(): Will check the answer.
         **************************************************/
        private bool CheckTheAnswer()
        {
            if (plus == sum.Value)
                return true;
            else
                return false;
        }
    }
}
