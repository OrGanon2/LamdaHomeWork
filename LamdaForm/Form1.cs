using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LamdaForm
{
    //Greet Hello = (string Name) => { Console.WriteLine($"welcome{Name}"); };
    //Hello("Bennet");
    public delegate int Dele(int a, int b);
    public delegate bool DeleStudent(Student studentlist);
    public delegate int DeleSum(Student Sum);
    public delegate double DelAvrage(Student Avrage);
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        DelAvrage AvrageGrade = (Student GradeAvrage) => { return GradeAvrage.Grade; };

       
        DelAvrage AvrageAge = (Student AgeAvrage) => { return AgeAvrage.Age; };

        DeleSum TotalLeft = (Student studentCostLeft) => { return studentCostLeft.Cost; };


        DeleSum TotalPaid = (Student studentTotal) => { return studentTotal.Cost; };


        DeleStudent Check = (Student student) =>
        { if (student.Name[0] == student.LastName[0])
            {
                return true;

            }
            return false;
        };
       
        DeleStudent StudentGrade = (Student student) => { if (student.Grade < 50)
            { return true; }
            return false;
        };
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
          

        }

        private void Remove_Click(object sender, EventArgs e)
        {

           

        }

        private void GradeCheck_Click(object sender, EventArgs e)
        {
          

        }

        private void FullnameCheck_Click(object sender, EventArgs e)
        {
            
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void AvrGradeText_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgeAvrText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void TotalPayText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Age_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cost_TextChanged(object sender, EventArgs e)
        {

        }

        private void Paid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click_1(object sender, EventArgs e)
        {
            StudentManage.AddStudent(ID.Text, Name.Text, LastName.Text, int.Parse(Grade.Text), int.Parse(Age.Text), int.Parse(Cost.Text), int.Parse(Paid.Text));
            listBox1.Items.Clear();
            foreach (var item in StudentManage.StudentList)
            {
                listBox1.Items.Add(item);
            }
            TotalPayText.Text = StudentManage.Sum(TotalPaid).ToString();
            CostLeftText.Text = StudentManage.Sum(TotalLeft).ToString();
            AgeAvrText.Text = StudentManage.avrage(AvrageAge).ToString();
            AvrGradeText.Text = StudentManage.avrage(AvrageGrade).ToString();
        }

        private void Remove_Click_1(object sender, EventArgs e)
        {
            try
            {
                bool remove = StudentManage.RemoveStudent(Name.Text, LastName.Text);
                if (!remove)
                {
                    MessageBox.Show("student not found");
                }
                else
                {
                    listBox1.Items.Clear();
                    foreach (var item in StudentManage.StudentList)
                    {
                        listBox1.Items.Add(item);
                    }
                    TotalPayText.Text = StudentManage.Sum(TotalPaid).ToString();
                    CostLeftText.Text = StudentManage.Sum(TotalLeft).ToString();
                    AgeAvrText.Text = StudentManage.avrage(AvrageAge).ToString();
                    AvrGradeText.Text = StudentManage.avrage(AvrageGrade).ToString();
                    MessageBox.Show("Student has been removed Successfully");
                }
            }
            catch (NullReferenceException)
            {

                MessageBox.Show("please insert a name");
            }
        }

        private void FullnameCheck_Click_1(object sender, EventArgs e)
        {
            if (StudentManage.contain(Check))
            {
                MessageBox.Show("there is a student with the same first name last name starting letter");
            }
            else
            {
                MessageBox.Show("no student with the same first name and last name starting letter");
            }
        }

        private void GradeCheck_Click_1(object sender, EventArgs e)
        {
            if (StudentManage.contain(StudentGrade))
            {
                MessageBox.Show("Grades lower then 50");
            }
            else
            {
                MessageBox.Show("there are no Grades lower then 50");
            }
        }
    }
}
