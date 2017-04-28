using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string path = @"C:\Users\Sattar\Downloads\CSharp\Database_Project\Database_Project\kbtuData.txt";
        public List<StudentStat> students = new List<StudentStat>();
        public List<string> speciality = new List<string>();
        public List<string> years = new List<string>();

        DataPreparation dp = new DataPreparation();

        public double techStat;
        public double humStat;
        
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            students = dp.TakeData(path);

            for (int i=0; i<students.Count; i++)
            {
                string temp = students[i].Name + " " + students[i].Surname;
                if (!speciality.Contains(students[i].Speciality))
                {
                    speciality.Add(students[i].Speciality);
                    comboBox2.Items.Add(students[i].Speciality);
                }
                string tempId = students[i].Id.Substring(0, 4);
                if (!years.Contains(tempId))
                {
                    years.Add(tempId);
                    comboBox3.Items.Add(tempId);
                }
                comboBox1.Items.Add(temp);
            }
            

            techStat = dp.GetTechStat();
            humStat = dp.GetHumStat();

            string toTech = "Technical Subjects Average GPA - " + techStat;
            string toHum = "Humanitarian Subjects Average GPA - " + humStat;
            chart2.Series[0].Points.AddXY(toTech, techStat);
            chart2.Series[0].Points.AddXY(toHum, humStat);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] item = comboBox1.SelectedItem.ToString().Split(' ');
            StudentStat tempStudStat = students.First(p => p.Surname.Equals(item[1]));

            name.Text = tempStudStat.Name;
            surname.Text = tempStudStat.Surname;
            id.Text = tempStudStat.Id;
            techGPA.Text = tempStudStat.TechGPA.ToString();
            humGPA.Text = tempStudStat.HumGPA.ToString();

            int TechProcent = (int)dp.TechLearningResults(students, tempStudStat.Id);
            int HumProcent = (int)dp.HumLearningResults(students, tempStudStat.Id);
            label7.Text = TechProcent + "% of Students in Technical Subjects and " + HumProcent + "% of students in Humanitarian Subjects!";
            label6.Visible = true;
            label7.Visible = true;

            string toTech = "Technical Subjects Average GPA - " + tempStudStat.TechGPA;
            string toHum = "Humanitarian Subjects Average GPA - " + tempStudStat.HumGPA;
            chart2.Series[0].Points.Clear();
            chart2.Series[0].Points.AddXY(toTech, tempStudStat.TechGPA);
            chart2.Series[0].Points.AddXY(toHum, tempStudStat.HumGPA);
            
            chart1.Series[0].Points.Clear();
            for (int i=0; i<tempStudStat.SemesterGPA.Count; i++)
            {
                chart1.Series[0].Points.AddXY((i + 1), tempStudStat.SemesterGPA[i]);
            }
            chart1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dp.PrepareData(path);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem != null)
            {
                List<StudentStat> itemsToComboBox = students.FindAll(p => p.Speciality == comboBox2.SelectedItem.ToString() && p.Id.Contains(comboBox3.SelectedItem.ToString()));
                comboBox1.Items.Clear();
                for (int i = 0; i < itemsToComboBox.Count; i++)
                {
                    comboBox1.Items.Add(itemsToComboBox[i].Name + " " + itemsToComboBox[i].Surname);
                }
            }
            else
            {
                List<StudentStat> itemsToComboBox = students.FindAll(p => p.Speciality == comboBox2.SelectedItem.ToString());
                comboBox1.Items.Clear();
                for (int i = 0; i < itemsToComboBox.Count; i++)
                {
                    comboBox1.Items.Add(itemsToComboBox[i].Name + " " + itemsToComboBox[i].Surname);
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                List<StudentStat> itemsToComboBox = students.FindAll(p => p.Id.Contains(comboBox3.SelectedItem.ToString()) && p.Speciality == comboBox2.SelectedItem.ToString());
                comboBox1.Items.Clear();
                for (int i = 0; i < itemsToComboBox.Count; i++)
                {
                    comboBox1.Items.Add(itemsToComboBox[i].Name + " " + itemsToComboBox[i].Surname);
                }
            }
            else
            {
                List<StudentStat> itemsToComboBox = students.FindAll(p => p.Id.Contains(comboBox3.SelectedItem.ToString()));
                comboBox1.Items.Clear();
                for (int i = 0; i < itemsToComboBox.Count; i++)
                {
                    comboBox1.Items.Add(itemsToComboBox[i].Name + " " + itemsToComboBox[i].Surname);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            chart3.Series[0].Points.Clear();
            chart4.Series[0].Points.Clear();
            for (int i=0; i<years.Count; i++)
            {
                List<StudentStat> name = students.FindAll(d => d.Id.Contains(years[i]));
                double tempTechGPA = 0;
                double tempHumGPA = 0;
                for (int j=0; j<name.Count; j++)
                {
                    tempTechGPA += name[j].TechGPA;
                    tempHumGPA += name[j].HumGPA;
                }
                tempTechGPA = tempTechGPA / name.Count;
                tempHumGPA = tempHumGPA / name.Count;

                chart3.Series[0].Points.AddXY(years[i], tempHumGPA);
                chart4.Series[0].Points.AddXY(years[i], tempTechGPA);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
