using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7;

namespace EN_project.DB
{
    public partial class form_id : Form
    {

        DBEntities11 db = new DBEntities11();
        public form_id()
        {
            InitializeComponent();
            
        }
        private void Add_students_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserName.Text == "" || textBox7.Text == "" || textBox6.Text == "" || textBox3.Text == "" || textBox8.Text == "" || textBox5.Text == "")
                { MessageBox.Show("please fill in this field", "Error"); }
                else
                {
                    student s = new student
                    {
                        Username = UserName.Text,
                        FirstName = textBox7.Text,
                        LastName = textBox6.Text,
                        Email = textBox3.Text,
                        Phone = textBox8.Text,
                        Departmentld = int.Parse(textBox5.Text),
                        RegisterDate = monthCalendar1.SelectionStart.ToString(),
                    };
                    db.students.Add(s);
                    db.SaveChanges();
                    MessageBox.Show("Added", "Attination");
                }
            }
            catch (Exception) { MessageBox.Show("Wrong data enter", "Error"); }
           
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
        {
            if (textBox9.Text == "" || textBox4.Text == "" || textBox1.Text == "" || textBox10.Text == "")
            { MessageBox.Show("please fill in this field", "Error"); }
            else
            {
                subject sub = new subject
                {
                    Name = textBox2.Text,
                    Departmentld = int.Parse(textBox9.Text),
                    MlnimumDegree = int.Parse(textBox4.Text),
                    Year = int.Parse(textBox1.Text),
                    Term = int.Parse(textBox10.Text),

                };
                db.subjects.Add(sub);
                db.SaveChanges();
                MessageBox.Show("Added", "Attination");
            }
        }
            catch (Exception) { MessageBox.Show("Wrong data enter", "Error"); }
          
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox12.Text == "" || textBox13.Text == "" || textBox11.Text == "")
                { MessageBox.Show("please fill in this field", "Error"); }
                else
                {
                    StudentMark sm = new StudentMark
                    {
                        Mark = int.Parse(textBox12.Text),
                        StudentId = int.Parse(textBox13.Text),
                        ExamId = int.Parse(textBox11.Text),

                    };
                    db.StudentMarks.Add(sm);
                    db.SaveChanges();
                    MessageBox.Show("Added", "Attination");
                }
            }
            catch (Exception) { MessageBox.Show("Wrong data enter", "Error"); }
           
           
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox14.Text == "")
                { MessageBox.Show("please fill in this field", "Error"); }
                else
                {
                    Departmebt dep = new Departmebt
                    {
                        Name = textBox14.Text
                    };
                    db.Departmebts.Add(dep);
                    db.SaveChanges();
                    MessageBox.Show("Added", "Attination");
                }
            }
            catch (Exception) { MessageBox.Show("Wrong data enter", "Error"); }
           
            } 
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox17.Text == "" || textBox16.Text == "")
                { MessageBox.Show("please fill in this field", "Error"); }
                else
                {
                    Exam ex = new Exam
                    {
                        Term = int.Parse(textBox17.Text),
                        Date = monthCalendar3.SelectionStart.ToString(),
                        Subjectld = int.Parse(textBox16.Text),

                    };
                    db.Exams.Add(ex);
                    db.SaveChanges();
                    MessageBox.Show("Added", "Attination");
                }
            }
            catch (Exception) { MessageBox.Show("Wrong data enter", "Error"); }
          


        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox20.Text == "" || textBox19.Text == "")
                { MessageBox.Show("please fill in this field", "Error"); }
                else
                {
                    SubjectLecture subl = new SubjectLecture
                    {
                        Title = textBox20.Text,
                        Content = richTextBox1.Text,
                        subject_id = int.Parse(textBox19.Text),
                    };
                    db.SubjectLectures.Add(subl);
                    db.SaveChanges();
                    MessageBox.Show("Added", "Attination");

                }
            }
            catch (Exception) { MessageBox.Show("Wrong data enter", "Error"); }
           
        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.MaxLength = 10;
        }
    }
}
