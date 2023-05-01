using EN_project.DB;
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
using static System.Windows.Forms.DataFormats;

namespace EN_project
{
    public partial class update_form : Form
    {

        DBEntities11 db = new DBEntities11();
        int id;
        public update_form()
        {
            InitializeComponent();
        } 
       private  bool no_null(TextBox text)
        {if (text.Text == "")
            { MessageBox.Show("please fill in this field", "Error");
                return true; }
        
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ;
                id = int.Parse(textBox1.Text);
                Departmebt dep = db.Departmebts.SingleOrDefault(de => de.Id == id);
                if (!no_null(textBox14))
                {
                    dep.Name = textBox14.Text;
                    db.SaveChanges();
                    MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                
                int id = int.Parse(textBox1.Text);
                student st = db.students.SingleOrDefault(de => de.Id == id);
                if (!no_null(UserName))
                {
                    st.Username = UserName.Text;
                    db.SaveChanges();
                    Refresh();
                    MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                id = int.Parse(textBox1.Text);
                student det = db.students.SingleOrDefault(de => de.Id == id);
               if(! no_null(textBox7))
                {
                    det.FirstName = textBox7.Text;
                    db.SaveChanges();
                    MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
               
                id = int.Parse(textBox1.Text);
                student det = db.students.SingleOrDefault(de => de.Id == id);
                if (!no_null(textBox6))
                {
                    det.LastName = textBox6.Text;
                    db.SaveChanges();
                    MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {

                id = int.Parse(textBox1.Text);
                student det = db.students.SingleOrDefault(de => de.Id == id);
                if (!no_null(Phone)) { 
                    det.Phone = Phone.Text;
                db.SaveChanges();
                MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); Phone.Text = "";
            }}
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);Phone.Text = ""; }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {

                id = int.Parse(textBox1.Text);
                student det = db.students.SingleOrDefault(de => de.Id == id);
                if (!no_null(textBox3))
                {
                    det.Email = textBox3.Text;
                    db.SaveChanges();
                    MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
               
                id = int.Parse(textBox1.Text);
                student det = db.students.SingleOrDefault(de => de.Id == id);
                if (!no_null(textBox5))
                {
                    det.Departmentld = int.Parse(textBox5.Text);
                    db.SaveChanges();
                    MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
               
                id = int.Parse(textBox1.Text);
                student det = db.students.SingleOrDefault(de => de.Id == id);
                det.RegisterDate = monthCalendar1.SelectionStart.ToString();
                db.SaveChanges();
                MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
               
                id = int.Parse(textBox1.Text);
                subject det = db.subjects.SingleOrDefault(de => de.Id == id);
                if (!no_null(textBox11))
                {
                    det.Name = textBox11.Text;
                    db.SaveChanges();
                    MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
               
                id = int.Parse(textBox1.Text);
                subject det = db.subjects.SingleOrDefault(de => de.Id == id);
                if (!no_null(textBox4))
                {
                    det.MlnimumDegree = int.Parse(textBox4.Text);
                    db.SaveChanges();
                    MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information); textBox4.Text = "";
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); textBox4.Text = ""; }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
              
                id = int.Parse(textBox1.Text);
                subject det = db.subjects.SingleOrDefault(de => de.Id == id);
                if (!no_null(textBox10))
                {
                    det.Term = int.Parse(textBox10.Text);
                    db.SaveChanges();
                    MessageBox.Show("updateing", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button11_Click(object sender, EventArgs e)
        {
            try
            {
              
                int id = int.Parse(textBox1.Text);
                subject det = db.subjects.SingleOrDefault(de => de.Id == id);
                if (!no_null(textBox9))
                {
                    det.Departmentld = int.Parse(textBox9.Text);
                    db.SaveChanges();
                    MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button12_Click(object sender, EventArgs e)
        {
            try
            {

                textBox2.MaxLength = 4;
                int id = int.Parse(textBox1.Text);
                subject det = db.subjects.SingleOrDefault(de => de.Id == id);
                if (!no_null(textBox2))
                {
                    det.Year = int.Parse(textBox2.Text);
                    db.SaveChanges();
                    MessageBox.Show("updateing", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            textBox12.MaxLength = 3;
            try
            {
               
                int id = int.Parse(textBox1.Text);
                StudentMark det = db.StudentMarks.SingleOrDefault(de => de.Id == id);
                if (!no_null(textBox12))
                {
                    det.Mark = int.Parse(textBox12.Text);
                    db.SaveChanges();
                    MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
               
                int id = int.Parse(textBox1.Text);
                StudentMark det = db.StudentMarks.SingleOrDefault(de => de.Id == id);
                if (!no_null(textBox13))
                {
                    det.Mark = int.Parse(textBox13.Text);
                    db.SaveChanges();
                    MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
               
                int id = int.Parse(textBox1.Text);
                StudentMark det = db.StudentMarks.SingleOrDefault(de => de.Id == id);
                if (!no_null(textBox15))
                {
                    det.ExamId = int.Parse(textBox15.Text);
                    db.SaveChanges();
                    MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
              
                int id = int.Parse(textBox1.Text);
                Exam det = db.Exams.SingleOrDefault(de => de.Id == id);
                if (!no_null(textBox17))
                {
                    det.Term = int.Parse(textBox17.Text);
                    db.SaveChanges();
                    MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                Exam det = db.Exams.SingleOrDefault(de => de.Id == id);
                det.Date = monthCalendar1.SelectionStart.ToString(); ;
                db.SaveChanges();
                MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
               
                int id = int.Parse(textBox1.Text);
                Exam det = db.Exams.SingleOrDefault(de => de.Id == id);
                if (!no_null(textBox16))
                {
                    det.Subjectld = int.Parse(textBox16.Text);
                    db.SaveChanges();
                    MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button20_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(textBox1.Text);
                SubjectLecture det = db.SubjectLectures.SingleOrDefault(de => de.Id == id);
                if (!no_null(textBox20))
                {
                    det.Title = textBox20.Text;
                    db.SaveChanges();
                    MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            try
            {
       
                int id = int.Parse(textBox1.Text);
                SubjectLecture det = db.SubjectLectures.SingleOrDefault(de => de.Id == id);
                det.Content = richTextBox1.Text;
                db.SaveChanges();
                MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
               
                int id = int.Parse(textBox1.Text);
                SubjectLecture det = db.SubjectLectures.SingleOrDefault(de => de.Id == id);
                if (!no_null(textBox19))
                {
                    det.subject_id = int.Parse(textBox19.Text);
                    db.SaveChanges();
                    MessageBox.Show("updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception) { MessageBox.Show("id dont found", "error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox4.MaxLength = 2;
            if ((char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox4.MaxLength = 10;
            if ((char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = false;
            }
            else e.Handled = true;

        }
        private void only_STring_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((char.IsLetter(e.KeyChar) || char.IsLetter(e.KeyChar)))
            {
                e.Handled = false;
            }
            else e.Handled = true;

        }
    }
}
    
    