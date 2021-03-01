using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades_If
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Single Grade = 0;//This varible is used to hold the grade
            String Name = "";
            Name = txtName.Text;
            Grade = Convert.ToSingle(txtGrade.Text);
            
            if (Grade < 0) // if the score is less than 50
            {
                lbxGrade.Items.Clear();
                lbxGrade.Items.Add("Hi " + Name + " your Grade entered " + Grade + " = Data Error");
                lblOutput.Text = "Bad Data for " + Name;

            }
            else if (Grade > 100) // if the score is less than 50
            {
                lbxGrade.Items.Clear();
                lbxGrade.Items.Add("Hi " + Name + " your Grade entered " + Grade + " = Data Error");
                lblOutput.Text = "You must be lying " + Name;

            }
            else if (Grade <50) // if the score is less than 50
            {
                lbxGrade.Items.Clear();
                lbxGrade.Items.Add("Hi " +Name+ " you are Fail & your Grade is "+ Grade);
                lblOutput.Text = "Sorry " + Name;
            }
            else
            {
                lbxGrade.Items.Clear();
                lbxGrade.Items.Add("Congratulations " + Name + " You are pass & your grade is " + Grade);
                lblOutput.Text = "Congratulations " + Name;
            }
            

        }
    }
}
