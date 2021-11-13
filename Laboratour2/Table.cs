using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Xsl;

namespace Laboratour2
{
    public partial class Table : Form
    {
        List<Student> St;

        private void comboFill(HashSet<string> lhs, ref ComboBox rhs)
        {
            foreach (var str in lhs)
            {
                rhs.Items.Add(str);
            }
        }
        public void GetXML()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\Laba2OOP\Laboratour2\Laboratour2\StudentSuccess.xml");

            var name = new HashSet<string>();
            var faculty = new HashSet<string>();
            var speciality = new HashSet<string>();
            var cathedra = new HashSet<string>();
            var subjects = new HashSet<string>();
            var ratemark = new HashSet<string>();

            var list = doc.DocumentElement;
            foreach (XmlNode Students in list)
            {
                foreach (XmlNode node in Students)
                {
                    switch (node.Name)
                    {
                        case "FullName":
                            name.Add(node.InnerText);
                            break;
                        case "Speciality":
                            speciality.Add(node.InnerText);
                            break;
                        case "Faculty":
                            faculty.Add(node.InnerText);
                            break;
                        case "Cathedra":
                            cathedra.Add(node.InnerText);
                            break;
                        case "Subjects":
                            string temp = node.InnerText;
                            string[] subs = temp.Split(',');
                            foreach (var str in subs)
                            {
                                subjects.Add(str.Trim());
                            }
                            break;
                        case "RateMark":
                            ratemark.Add(node.InnerText);
                            break;
                    }
                }
            }
            comboFill(name, ref comboBoxNames);
            comboFill(speciality, ref comboBoxSpeciality);
            comboFill(faculty, ref comboBoxFaculties);
            comboFill(cathedra, ref comboBoxCathedras);
            comboFill(subjects, ref comboBoxSubjects);
            comboFill(ratemark, ref comboBoxMarks);
        }
        public Table()
        {
            InitializeComponent();
            GetXML();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            Answer.Text = "";
            Student st = new Student();

            if (checkBoxПІБ.Checked)
            {
                st.name = comboBoxNames.SelectedItem.ToString();
            }
            if (checkBoxФакультет.Checked)
            {
                st.fac = comboBoxFaculties.SelectedItem.ToString();
            }
            if (checkBoxСпеціальність.Checked)
            {
                st.spec = comboBoxSpeciality.SelectedItem.ToString();
            }
            if (checkBoxКафедра.Checked)
            {
                st.cath = comboBoxCathedras.SelectedItem.ToString();
            }
            if (checkBoxОцінка.Checked)
            {
                st.mark = comboBoxMarks.SelectedItem.ToString();
            }
            if (checkBoxПредмет.Checked)
            {
                st.subjects.Add(comboBoxSubjects.SelectedItem.ToString());
            }
            IXMLStrategy analysis = new XMLDOM();

            if (radioButtonDOM.Checked)
            {
                analysis = new XMLDOM();
            }
            if (radioButtonSAX.Checked)
            {
                analysis = new XMLSAX();
            }
            if (radioButtonLINQ.Checked)
            {
                analysis = new XMLLINQ();
            }
            St = new List<Student>();
            St = analysis.Search(st);
            PrintRes(St);
        }
        private void PrintRes(List<Student> sts)
        {
            foreach (var s in sts)
            {
                Answer.Text += "Студент: " + s.name + "\n";
                Answer.Text += "Факультет: " + s.fac + "\n";
                Answer.Text += "Спецiальнiсть: " + s.spec + "\n";
                Answer.Text += "Кафедра: " + s.cath + "\n";
                Answer.Text += "Предмети: ";
                foreach(var el in s.subjects)
                {
                    Answer.Text += el;
                    if (el != s.subjects[s.subjects.Count - 1])
                        Answer.Text += ", ";
                    else
                        Answer.Text += "\n";
                }
                Answer.Text += "Рейтинговий бал: " + s.mark + "\n";
                Answer.Text += "\n\n\n";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Answer.Text = "";
            checkBoxПІБ.Checked = false;
            checkBoxФакультет.Checked = false;
            checkBoxСпеціальність.Checked = false;
            checkBoxКафедра.Checked = false;
            checkBoxПредмет.Checked = false;
            checkBoxОцінка.Checked = false;
            comboBoxNames.SelectedIndex = -1;
            comboBoxFaculties.SelectedIndex = -1;
            comboBoxSpeciality.SelectedIndex = -1;
            comboBoxCathedras.SelectedIndex = -1;
            comboBoxSubjects.SelectedIndex = -1;
            comboBoxMarks.SelectedIndex = -1;
            radioButtonDOM.Checked = false;
            radioButtonSAX.Checked = false;
            radioButtonLINQ.Checked = false;
            clearXML();
        }

        private void buttonTrans_Click(object sender, EventArgs e)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            const string message = "Ви впевнені? Попередні записи буде втрачено назавжди!";
            const string caption = "Створення запису html";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
                transform();
        }

        private void transform()
        {
            prepareXML();
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load(@"D:\Laba2OOP\Laboratour2\Laboratour2\StudentSuccess.xsl");
            string fXML = @"D:\Laba2OOP\Laboratour2\Laboratour2\Transformer.xml";
            string fHTML = @"D:\Laba2OOP\Laboratour2\Laboratour2\StudentSuccess.html";
            xct.Transform(fXML, fHTML);
        }

        private void clearXML()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"D:\Laba2OOP\Laboratour2\Laboratour2\Transformer.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            xRoot.RemoveAll();
            xDoc.Save(@"D:\Laba2OOP\Laboratour2\Laboratour2\Transformer.xml");
        }

        private void prepareXML()
        {
            clearXML();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"D:\Laba2OOP\Laboratour2\Laboratour2\Transformer.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            if (St == null)
                return;
            foreach (var student in St)
            {
                XmlElement studentElem = xDoc.CreateElement("Student");
                XmlElement nameElem = xDoc.CreateElement("FullName");
                XmlElement facultyElem = xDoc.CreateElement("Faculty");
                XmlElement specialityElem = xDoc.CreateElement("Speciality");
                XmlElement cathedraElem = xDoc.CreateElement("Cathedra");
                XmlElement subjectsElem = xDoc.CreateElement("Subjects");
                XmlElement markElem = xDoc.CreateElement("RateMark");
                
                XmlText nameText = xDoc.CreateTextNode(student.name);
                XmlText facultyText = xDoc.CreateTextNode(student.fac);
                XmlText specialityText = xDoc.CreateTextNode(student.spec);
                XmlText cathedraText = xDoc.CreateTextNode(student.cath);
                string subj = "";
                foreach(var s in student.subjects)
                {
                    subj += s;
                    if(s != student.subjects.Last())
                    {
                        subj += ", ";
                    }
                }
                XmlText subjectsText = xDoc.CreateTextNode(subj);
                XmlText markText = xDoc.CreateTextNode(student.mark);

                nameElem.AppendChild(nameText);
                facultyElem.AppendChild(facultyText);
                specialityElem.AppendChild(specialityText);
                cathedraElem.AppendChild(cathedraText);
                subjectsElem.AppendChild(subjectsText);
                markElem.AppendChild(markText);

                studentElem.AppendChild(nameElem);
                studentElem.AppendChild(facultyElem);
                studentElem.AppendChild(specialityElem);
                studentElem.AppendChild(cathedraElem);
                studentElem.AppendChild(subjectsElem);
                studentElem.AppendChild(markElem);
                xRoot.AppendChild(studentElem);
            }
            xDoc.Save(@"D:\Laba2OOP\Laboratour2\Laboratour2\Transformer.xml");
        }

        private void Table_FormClosing(object sender, FormClosingEventArgs e)
        {
            const string message =
                "Ви впевнені, що хочете закрити програму? Дані можуть бути втрачені назавжди!";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
