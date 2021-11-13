using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Laboratour2
{
    public class Student
    {
        public Student(string Name, string Faculty, string Speciality, string Cathedra, List<string> Subjects, string Mark)
        {
            name = Name;
            fac = Faculty;
            spec = Speciality;
            cath = Cathedra;
            foreach (var el in Subjects)
            {
                subjects.Add(el);
            }
            mark = Mark;
        }
        public Student()
        {
            name = "";
            mark = "";
            fac = "";
            cath = "";
            spec = "";
        }
        public string name;
        public List<string> subjects = new List<string>();
        public string mark;
        public string fac;
        public string cath;
        public string spec;

        public Student(XElement student)
        {
            name = student.Element("FullName")?.Value;
            fac = student.Element("Faculty")?.Value;
            cath = student.Element("Cathedra")?.Value;
            spec = student.Element("Speciality")?.Value;
            mark = student.Element("RateMark")?.Value;
            subjects = new List<string>();
            string[] subs = student.Element("Subjects")?.Value.Split(',');
            foreach (var el in subs)
            {
                subjects.Add(el.Trim());
            }
        }

        public static bool operator ==(Student left, Student condition)
        {
            if (!left.name.Contains(condition.name) && condition.name != "") return false;
            if (!left.fac.Contains(condition.fac) && condition.fac != "") return false;
            if (!left.cath.Contains(condition.cath) && condition.cath != "") return false;
            if (!left.spec.Contains(condition.spec) && condition.spec != "") return false;
            if (!left.mark.Contains(condition.mark) && condition.mark != "") return false;

            if (condition.subjects.Count == 0) return true;
            if(left.subjects.Contains(condition.subjects[0]))
                return true;
            return false;
        }
        public static bool operator !=(Student left, Student right)
        {
            return !(left == right);
        }
    }
}
