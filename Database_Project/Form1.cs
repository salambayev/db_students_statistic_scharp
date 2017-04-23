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
        public double techStat;
        public double humStat;

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            string line;
            string[] info;
            StudentStat tempStud = new StudentStat();
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                while((line = file.ReadLine()) != null)
                {
                    info = line.Split(' ');
                    info[6] = info[6].Remove(info[6].Length - 2);
                    info[7] = info[7].Remove(info[7].Length - 2);
                    tempStud.Surname = info[0];
                    tempStud.Name = info[1];
                    tempStud.FamilyName = info[2];
                    tempStud.Id = info[3];
                    tempStud.Speciality = info[4];
                    tempStud.Course = int.Parse(info[5]);
                    tempStud.TechGPA = double.Parse(info[6]);
                    tempStud.HumGPA = double.Parse(info[7]);
                    int i = 8;
                    while(i < info.Length-1)
                    {
                        tempStud.SemesterGPA = new List<double>();
                        tempStud.SemesterGPA.Add(double.Parse(info[i]));
                        i++;
                    }
                    students.Add(tempStud);
                    string temp = tempStud.Name + " " + tempStud.Surname;
                    comboBox1.Items.Add(temp);
                    techStat += tempStud.TechGPA;
                    humStat += tempStud.HumGPA;
                }
                file.Close();

            }

            techStat = techStat / students.Count;
            humStat = humStat / students.Count;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] item = comboBox1.SelectedItem.ToString().Split(' ');
            StudentStat tempStudStat = students.FirstOrDefault((p) => p.Name == item[0] && p.Surname == item[1]);

            name.Text = tempStudStat.Name;
            surname.Text = tempStudStat.Surname;
            id.Text = tempStudStat.Id;
            techGPA.Text = tempStudStat.TechGPA.ToString();
            humGPA.Text = tempStudStat.HumGPA.ToString();
            for (int i=0; i<tempStudStat.SemesterGPA.Count-1; i++)
            {
                chart1.Series["Student"].Points.Clear();
                chart1.Series["Student"].Points.AddXY(i + 1, tempStudStat.SemesterGPA[i]);
                //chart1.Update();
                chart1.Refresh();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
