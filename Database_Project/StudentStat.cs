using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Project
{
    public class StudentStat
    {
        /// <summary>
        /// Name of a student
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Surname of a student
        /// </summary>
        public string Surname { get; set; }
        /// <summary>
        /// Family Name of a student
        /// </summary>
        public string FamilyName { get; set; }
        /// <summary>
        /// Student ID
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// Student speciality
        /// </summary>
        public string Speciality { get; set; }
        /// <summary>
        /// Student course
        /// </summary>
        public int Course { get; set; }
        /// <summary>
        /// Student Humanitarian subjects GPA 
        /// </summary>
        public double HumGPA {get; set;}
        /// <summary>
        /// Student Technical subjects GPA
        /// </summary>
        public double TechGPA { get; set; }
        /// <summary>
        /// Student All semesters GPA
        /// </summary>
        public List<double> SemesterGPA { get; set; }

    }
}
