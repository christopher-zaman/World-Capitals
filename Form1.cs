using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CapitalsWorld
{   
    public partial class Form1 : Form
    {
        int Score = 0;
        int CorrectOptionBox;
        public Form1()
        {
            InitializeComponent();
        }
        void AskQuestion()
        {
            // Step A
            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=MONDIAL.accdb;Jet OLEDB:Database Password=password";

            // Step B
            DataSet data = new DataSet();
            OleDbDataAdapter adap = new OleDbDataAdapter("SELECT * FROM Country", connStr);
            adap.Fill(data);

            //Step C
            int countryCount = data.Tables[0].Rows.Count;

            //Step D
            Random random = new Random();
            int correctAnswer = random.Next(0, countryCount - 1);
            int wrongAnswer = random.Next(0, countryCount - 1);

            //Step E
            string questionCountryName = data.Tables[0].Rows[correctAnswer]["CountryName"].ToString();
            string questionCorrectCapital = data.Tables[0].Rows[correctAnswer]["Capital"].ToString();
            string questionWrongCapital = data.Tables[0].Rows[wrongAnswer]["Capital"].ToString();

            //Step F
            lblQuestion.Text = "What is the capital of " + questionCountryName + "?";

            // Step G
            if (DateTime.Now.Millisecond % 2 == 0)
            {
                optChoice1.Text = questionCorrectCapital; // first box has the right choice
                optChoice2.Text = questionWrongCapital;
                CorrectOptionBox = 1;
            }
            else
            {
                optChoice1.Text = questionWrongCapital;
                optChoice2.Text = questionCorrectCapital; // second box has the right choice
                CorrectOptionBox = 2;
            }
        }
        void EvaluateAnswer()
        {
            if ((CorrectOptionBox == 1 && optChoice1.Checked) || (CorrectOptionBox == 2 && optChoice2.Checked))
                Score += 10;
            else
                Score -= 10;

            // display the current score of the user
            lblScore.Text = "Your Score is " + Score.ToString();

            //and ask another question
            AskQuestion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AskQuestion();
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            EvaluateAnswer();
        }
    }
}
