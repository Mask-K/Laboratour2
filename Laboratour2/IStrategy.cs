using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Laboratour2
{
    public interface IXMLStrategy
    {
        List<Student> Search(Student student);
    }


    class XMLDOM : IXMLStrategy
    {
        public List<Student> Search(Student type)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"D:\Laba2OOP\Laboratour2\Laboratour2\StudentSuccess.xml");
            var list = xDoc.DocumentElement;
            string FullName = "";
            string faculty = "";
            string speciality = "";
            string cathedra = "";
            var subjects = new List<string>();
            string ratemark = "";
            var students = new List<Student>();

            foreach (XmlNode stus in list)
            {
                foreach (XmlNode student in stus)
                {
                    switch (student.Name)
                    {
                        case "FullName":
                            FullName = student.InnerText;
                            break;
                        case "Faculty":
                            faculty = student.InnerText;
                            break;
                        case "Speciality":
                            speciality = student.InnerText;
                            break;
                        case "Cathedra":
                            cathedra = student.InnerText;
                            break;
                        case "Subjects":
                            string temp = student.InnerText;
                            string[] subs = temp.Split(',');
                            foreach (var el in subs)
                            {
                                subjects.Add(el.Trim());
                            }
                            break;
                        case "RateMark":
                            ratemark = student.InnerText;
                            break;
                    }
                }
                students.Add(new Student(FullName, faculty, speciality, cathedra, subjects, ratemark));
                subjects.Clear();
            }
            Student[] copy = new Student[students.Count];
            students.CopyTo(copy);
            foreach (var st in copy)
            {
                if (st != type)
                    students.Remove(st);
            }
            return students;
        }
    }

    class XMLSAX : IXMLStrategy
    {
        public List<Student> Search(Student type)
        {
            var result = new List<Student>();
            using (XmlReader xr = XmlReader.Create(@"D:\Laba2OOP\Laboratour2\Laboratour2\StudentSuccess.xml"))
            {
                string FullName = "";
                string faculty = "";
                string speciality = "";
                string cathedra = "";
                var subjects = new List<string>();
                string ratemark = "";
                string tag = "";
                while (xr.Read())
                {
                    switch (xr.NodeType)
                    {
                        case XmlNodeType.Element:
                            tag = xr.Name;
                            break;
                        case XmlNodeType.Text:
                            {
                                switch (tag)
                                {
                                    case "FullName":
                                        FullName = xr.Value;
                                        break;
                                    case "Faculty":
                                        faculty = xr.Value;
                                        break;
                                    case "Speciality":
                                        speciality = xr.Value;
                                        break;
                                    case "Cathedra":
                                        cathedra = xr.Value;
                                        break;
                                    case "Subjects":
                                        string temp = xr.Value;
                                        string[] subs = temp.Split(',');
                                        foreach (var el in subs)
                                        {
                                            subjects.Add(el.Trim());
                                        }
                                        break;
                                    case "RateMark":
                                        ratemark = xr.Value;
                                        break;
                                }
                                break;
                            }
                        case XmlNodeType.EndElement:
                            {
                                if (tag.Equals("RateMark"))
                                {
                                    var temp = new Student(FullName, faculty, speciality, cathedra, subjects, ratemark);
                                    if (temp == type)
                                        result.Add(new Student(FullName, faculty, speciality, cathedra, subjects, ratemark));
                                    FullName = "";
                                    faculty = "";
                                    speciality = "";
                                    cathedra = "";
                                    subjects = new List<string>();
                                    ratemark = "";
                                }

                                break;
                            }
                    }
                }
            }
            return result;
        }
    }
    class XMLLINQ : IXMLStrategy
    {
        public List<Student> Search(Student type)
        {
            XDocument xDoc = XDocument.Load(@"D:\Laba2OOP\Laboratour2\Laboratour2\StudentSuccess.xml");
            var matches = from student in xDoc.Element("Students").Elements("Student")
                          let transStudent = new Student(student)
                          where transStudent == type
                          select transStudent;

            var result = new List<Student>();
            foreach (var m in matches)
            {
                result.Add(m);
            }
            return result;
        }
    }
}
