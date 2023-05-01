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

namespace EN_project
{
    public partial class Form2 : Form
    {
        DBEntities11 db = new DBEntities11();
        public Form2()
        {
            InitializeComponent();
        }

        public DBEntities11 Db { get => db; set => db = value; }

        private void Show<t>(t dbt)
        {
            if (dbt == null)
                MessageBox.Show("null");
            else
            {
                dataGridView2.ReadOnly = true;
                dataGridView2.DataSource = dbt;
                Db.SaveChanges();
                Refresh();

            }
        }
        private void SH_Students_Click(object sender, EventArgs e)
        {
            Show(Db.students.ToList());
        }

        private void SH_Subjects_Click(object sender, EventArgs e)
        {
            Show(Db.subjects.ToList());
        }

        private void Subject_Lectures_Click(object sender, EventArgs e)
        {
            Show(Db.SubjectLectures.ToList());
        }

        private void SH_Departments_Click(object sender, EventArgs e)
        {
            Show(Db.Departmebts.ToList());
        }

        private void SH_Exams_Click(object sender, EventArgs e)
        {
            Show(Db.Exams.ToList());
        }

        private void Student_Marks_Click(object sender, EventArgs e)
        {
            Show(Db.StudentMarks.ToList());
        }

        private void SH_Students_Click_1(object sender, EventArgs e)
        {
            Show(Db.students.ToList());
        }

        private void DEl_Students_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                student st = Db.students.SingleOrDefault(std => std.Id == id);

                Db.students.Remove(st);
                Db.SaveChanges();
                Refresh();
                MessageBox.Show("Deleted", "Message");
            }
            catch (Exception)
            { MessageBox.Show("no data found ", "Delete"); }
        }

        private void DEl_Subjects_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                subject su = Db.subjects.SingleOrDefault(std => std.Id == id);
                Db.subjects.Remove(su);
                Db.SaveChanges();
                Refresh();
                MessageBox.Show("Deleted", "Message");

            }
            catch (Exception)
            { MessageBox.Show("no data found ", "Delete"); }
        }

        private void DEL_SubjectLectures_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                SubjectLecture sl = Db.SubjectLectures.SingleOrDefault(std => std.Id == id);
                Db.SubjectLectures.Remove(sl);
                Db.SaveChanges();
                MessageBox.Show("Deleted", "Message");

            }
            catch (Exception)
            { MessageBox.Show("no data found ", "Delete"); }
        }

        private void DEL_Deprtments_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                Departmebt de = Db.Departmebts.SingleOrDefault(std => std.Id == id);
                Db.Departmebts.Remove(de);
                Db.SaveChanges();
                MessageBox.Show("Deleted", "Message");

            }
            catch (Exception)
            { MessageBox.Show("no data found ", "Delete"); }
        }

        private void DEL_Exams_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                Exam su = Db.Exams.SingleOrDefault(std => std.Id == id);
                Db.Exams.Remove(su);
                Db.SaveChanges();
                MessageBox.Show("Deleted", "Message");

            }
            catch (Exception)
            { MessageBox.Show("no data found ", "Delete"); }
        }

        private void DEL_StudentMarks_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(textBox1.Text);
                StudentMark su = Db.StudentMarks.SingleOrDefault(std => std.Id == id);
                Db.StudentMarks.Remove(su);
                Db.SaveChanges();
                Refresh();
                MessageBox.Show("Deleted", "Message");

            }
            catch (Exception)
            { MessageBox.Show("no data found ", "Delete"); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                double i = 0;
                int id = int.Parse(textBox9.Text);
                int? avg = 0;
                student st = Db.students.SingleOrDefault(std => std.Id == id);
                var AVG = (from Stu in db.students
                           join sm in db.StudentMarks on Stu.Id equals sm.StudentId
                           where (Stu.Id == id)
                           select sm
                           ).ToList();
                if (st != null)
                {
                    foreach (var s in AVG)
                    {
                        avg += s.Mark;
                        i++;
                    }
                    MessageBox.Show($"{avg / i}", $"Student Average {st.FirstName}");
                }
                else MessageBox.Show("id student does not exist", "Message");
            }
            catch (Exception) { MessageBox.Show("The Student have no marks", "Message"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                List<subject> sub_list = db.subjects.ToList();
                List<SubjectLecture> sl = (from x in db.SubjectLectures
                                           orderby x.subject_id ascending
                                           select x).ToList();
                int c = 0;
                for (int i = 0; i < sub_list.Count; i++)
                {
                    c = 0;
                    for (int j = 0; j < sl.Count; j++)
                    {
                        if (sub_list[i].Id == sl[j].subject_id)
                            c++;
                    }
                    richTextBox1.AppendText(sub_list[i].Name + "\t" + c + "\n");
                }
            }
            catch (Exception) { MessageBox.Show("No Data Found", "Error"); }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                int r = Convert.ToInt32(textBox8.Text);

                var term = db.subjects.ToArray();
                for (int i = 0; i < term.Length; i++)
                {

                    if (term[i].Year == r)
                    {
                        richTextBox1.AppendText(term[i].Name + "\n");
                    }
                }
            }
            catch (Exception) { MessageBox.Show("Year not Found", "ERROR"); }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                int r = Convert.ToInt32(textBox7.Text);
                var term = db.subjects.ToArray();
                for (int i = 0; i < term.Length; i++)
                {

                    if (term[i].Term == r)
                    {
                        richTextBox1.AppendText(term[i].Name + "\n");
                    }
                }
            }
            catch (Exception) { MessageBox.Show("Term not Found", "ERROR"); }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                int r = Convert.ToInt32(textBox6.Text);
                var sub_list = db.subjects.ToArray();

                for (int i = 0; i < sub_list.Length; i++)
                {
                    if (sub_list[i].Departmentld == r)
                    {
                        richTextBox1.AppendText(sub_list[i].Name + "\n");
                    }
                }
            }
            catch (Exception) { MessageBox.Show("Depatment not Found", "ERROR"); }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                int sub_id = int.Parse(textBox5.Text);
                var SE = db.Exams.SingleOrDefault(s => s.Id == sub_id);
                var Student_Exam = (from s in db.students
                                    join SM in db.StudentMarks
                                    on s.Id equals SM.StudentId
                                    where (SM.ExamId == sub_id)
                                    select s);
                if (SE == null) { MessageBox.Show("no id Exam"); }
                else
                {
                    foreach (student o in Student_Exam)
                    {
                        richTextBox1.AppendText("id:\t" + o.Id + "\n" + "useerName: \t" + o.Username + "\n" + "firstName:\t" + o.FirstName + "\n" + "LastName: \t" + o.LastName + "\n" + "Email: \t" + o.Email + "\n" + "Phone: \t" + o.Phone + "\n" + "RegisterDate:\t" + o.RegisterDate + "\n" + "Department id :\t" + o.Departmentld + "\n");
                    }
                }
            }
            catch (Exception) { MessageBox.Show("No Data Found", "Error"); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                int sub_id = int.Parse(textBox4.Text);
                var Student_Exam = (from s in db.students
                                    join SM in db.StudentMarks
                                    on s.Id equals SM.StudentId
                                    where (SM.ExamId != sub_id)
                                    select s);
                if (Student_Exam == null) { MessageBox.Show("All student take this Exam"); }
                else
                {
                    foreach (student o in Student_Exam)
                    {
                        richTextBox1.AppendText("id:\t" + o.Id + "\n" + "useerName: \t" + o.Username + "\n" + "firstName:\t" + o.FirstName + "\n" + "LastName: \t" + o.LastName + "\n" + "Email: \t" + o.Email + "\n" + "Phone: \t" + o.Phone + "\n" + "RegisterDate:\t" + o.RegisterDate + "\n" + "Department id :\t" + o.Departmentld + "\n");
                    }
                }
            }
            catch (Exception) { MessageBox.Show("No Data Found", "Error"); }
        }

        private void student_Search_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                int id = int.Parse(textBox2.Text);
                int t;
                var s = db.students.Where(st => st.Departmentld == id).Select(st => st);
                if (s != null)
                {
                    foreach (student stu in s)
                    {
                        if (textBox3.Text == "")
                            richTextBox1.AppendText("id:\t" + stu.Id + "\n" + "useerName: \t" + stu.Username + "\n" + "firstName:\t" + stu.FirstName + "\n" + "LastName: \t" + stu.LastName + "\n" + "Email: \t" + stu.Email + "\n" + "Phone: \t" + stu.Phone + "\n" + "RegisterDate:\t" + stu.RegisterDate + "\n" + "Department id :\t" + stu.Departmentld + "\n");
                        else
                        {
                            t = int.Parse(textBox3.Text);
                            var term = db.subjects.SingleOrDefault(ter => ter.Term == t);
                            if (term != null)
                            {
                                var Term_st = (from stud in db.students
                                               join sub in db.subjects on stud.Departmentld equals sub.Departmentld
                                               where (sub.Term == t && stud.Departmentld == id)
                                               select stud);
                                foreach (student o in Term_st)
                                {
                                    richTextBox1.AppendText("id:\t" + o.Id + "\n" + "useerName: \t" + o.Username + "\n" + "firstName:\t" + o.FirstName + "\n" + "LastName: \t" + o.LastName + "\n" + "Email: \t" + o.Email + "\n" + "Phone: \t" + o.Phone + "\n" + "RegisterDate:\t" + o.RegisterDate + "\n" + "Department id :\t" + o.Departmentld + "\n");
                                }
                            }
                            else
                                MessageBox.Show("No Term Found", "Message");
                        }
                    }
                }
                else { MessageBox.Show("No Department Found", "Message"); }
            }
            catch (Exception)
            {
                MessageBox.Show("No Data Found", "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_id add = new form_id();
            add.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update_form add = new update_form();
            add.Show();
        }
    }
}
