using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Project
{
    public class DataPreparation
    {
        /// <summary>
        /// Technical subjects average GPA 
        /// </summary>
        double techStat;
        /// <summary>
        /// Humanitarian subjects average GPA
        /// </summary>
        double humStat;
        /// <summary>
        /// Preparing data for work
        /// </summary>
        /// <param name="path"></param>
        public void PrepareData(string path)
        {
            if (File.Exists(path))
            {
                string text = File.ReadAllText(path);
                text = text.Replace(",", ".");
                File.WriteAllText(path, text, Encoding.UTF8);
            }
        }

        /// <summary>
        /// Taking data to the specified list
        /// </summary>
        /// <param name="path"></param>
        /// <returns>List of Students info</returns>
        public List<StudentStat> TakeData(string path)
        {
            List<StudentStat> output = new List<StudentStat>();
            if (File.Exists(path))
            {
                foreach (string line in File.ReadLines(path))
                {
                    string[] info;
                    StudentStat tempStud = new StudentStat();
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
                    tempStud.SemesterGPA = new List<double>();
                    while (i < info.Length - 1)
                    {
                        tempStud.SemesterGPA.Add(double.Parse(info[i]));
                        i++;
                    }
                    output.Add(tempStud);
                    techStat += tempStud.TechGPA;
                    humStat += tempStud.HumGPA;
                }

            }
            techStat = techStat / output.Count;
            humStat = humStat / output.Count;

            return output;
        }
        /// <summary>
        /// Get Technical Subjects average GPA
        /// </summary>
        /// <returns></returns>
        public double GetTechStat()
        {
            return techStat;
        }

        /// <summary>
        /// Get Humanitarian subjects GPA
        /// </summary>
        /// <returns></returns>
        public double GetHumStat()
        {
            return humStat;
        }
        
        public double TechLearningResults(List<StudentStat> students, string id)
        {
            string IDname = id.Substring(0, 3);
            List<StudentStat> tempStud = students.FindAll(p => p.Id.Contains(IDname));

            List<StudentStat> ans = new List<StudentStat>(tempStud.OrderByDescending(d => d.TechGPA));

            int number = 0;

            for (int i=0; i < ans.Count; i++)
            {
                if (ans[i].Id == id)
                {
                    number = i + 1;
                    break;
                }
            }

            return ((1.0 - ((double)number / (double)ans.Count)) * 100); 
        }

        public double HumLearningResults(List<StudentStat> students, string id)
        {
            string IDname = id.Substring(0, 3);
            List<StudentStat> tempStud = students.FindAll(p => p.Id.Contains(IDname));

            List<StudentStat> ans = new List<StudentStat>(tempStud.OrderByDescending(d => d.HumGPA));

            int number = 0;

            for (int i=0; i<ans.Count; i++)
            {
                if (ans[i].Id == id)
                {
                    number = i + 1;
                    break;
                }
            }

            return ((1.0 - ((double)number / (double)ans.Count)) * 100);
        }
    }
}
