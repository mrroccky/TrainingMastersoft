using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Task1DesignStudentGradeSystem
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtRoll_TextChanged(object sender, EventArgs e)
        {

        }

       

        protected void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            int passingMarks = 40;
            int total;
            string name, branch;
            int rollnumber, subject1marks, subject2marks, subject3marks, subject4marks, subject5marks;

            
            try
            {
                rollnumber = int.Parse(txtRoll.Text);
                name = txtName.Text;
                branch = txtName.Text;
                subject1marks = int.Parse(txtSub1marks.Text);
                subject2marks = int.Parse(txtSub2marks.Text);
                subject3marks = int.Parse(txtSub3marks.Text);
                subject4marks = int.Parse(txtSub4marks.Text);
                subject5marks = int.Parse(txtSub5marks.Text);

                if (subject1marks > passingMarks && subject2marks > passingMarks && subject3marks > passingMarks && subject4marks > passingMarks && subject5marks > passingMarks)
                {
                    total = subject1marks + subject2marks + subject3marks + subject4marks + subject5marks;
                    txtTotalMarks.Text = total.ToString();
                   // calculateGrade(total);
                }
            }
            catch (Exception)
            {
                txtGrade.Text = "Kuthtri Error Aahe Bhau";
            }
        }

        protected void btnGenrateGrade_Click(object sender, EventArgs e)
        {
            int passingMarks = 40;
            int total;
            string name, branch;
            int rollnumber, subject1marks, subject2marks, subject3marks, subject4marks, subject5marks;
            try
            {
                rollnumber = int.Parse(txtRoll.Text);
                name = txtName.Text;
                branch = txtName.Text;
                subject1marks = int.Parse(txtSub1marks.Text);
                subject2marks = int.Parse(txtSub2marks.Text);
                subject3marks = int.Parse(txtSub3marks.Text);
                subject4marks = int.Parse(txtSub4marks.Text);
                subject5marks = int.Parse(txtSub5marks.Text);

                if (subject1marks > passingMarks && subject2marks > passingMarks && subject3marks > passingMarks && subject4marks > passingMarks && subject5marks > passingMarks)
                {
                    total = subject1marks + subject2marks + subject3marks + subject4marks + subject5marks;
                    calculateGrade(total);
                }
            }
            catch(Exception)
            {
                txtGrade.Text = "Kuthtri Error Aahe Bhau";
            }
           
        }
        public void calculateGrade(int total)
        {
            if (total>250)
            {
                txtGrade.Text = "Garde A";
            }else if (total>150 && total<250)
            {
                txtGrade.Text = "Garde B";
            }
            else
            {
                txtGrade.Text = "Fail";
            }
        }
    }
}