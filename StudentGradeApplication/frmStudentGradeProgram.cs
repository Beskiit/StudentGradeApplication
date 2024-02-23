using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class frmStudentGradeProgram : Form
    {
        public frmStudentGradeProgram()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalGrade = 0;
            double gradeEnglish = Convert.ToDouble(textBox2.Text);
            totalGrade += gradeEnglish;
            double gradeMath = Convert.ToDouble(textBox3.Text);
            totalGrade += gradeMath;
            double gradeScience = Convert.ToDouble(textBox4.Text);
            totalGrade += gradeScience;
            double gradeFilipino =  Convert.ToDouble(textBox5.Text);
            totalGrade += gradeFilipino;
            double gradeHistory = Convert.ToDouble(textBox6.Text);
            totalGrade += gradeHistory;

            double average = totalGrade / 5;

            label8.Text = average >= 75.00 ? "                  The student passed. \nThe general average of " + textBox1.Text + " is " + average : "                  The student failed. \nThe general average of " + textBox1.Text + " is " + average;
        }
    }
}
