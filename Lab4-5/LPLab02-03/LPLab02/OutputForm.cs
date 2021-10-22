using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.RegularExpressions;
namespace LPLab02
{
    public partial class OutputForm : Form
    {
        List<Student> studs;
        List<Student> currentSelect;
        public OutputForm(List<Student> students)
        {
            InitializeComponent();
            this.studs = students;
            this.currentSelect = students;
            FillData();
        }

        private ListViewItem CreateNote(Student el)
        {
            return new ListViewItem(new string[] {
                        el.FullName,
                        el.Age.ToString(),
                        el.Spec.ToString(),
                        el.Birthday.ToShortDateString(),// Date.ToString(),
                        el.Course.ToString(),
                        el.Group.ToString(),
                        Math.Round(el.AverageMark, 3).ToString(),
                        el.Gen == Student.GENDER.Male ? "м" : "ж",
                        el.Addr.ToString()
                    });
        }

        private void FillData()
        {
            if(studs.Count > 0)
            {
                foreach(Student el in studs)
                {
                    items.Items.Add(CreateNote(el));
                }
            }
        }
        private void FillData(List<Student> data)
        {
            if (data.Count > 0)
            {
                foreach (Student el in data)
                {
                    items.Items.Add(CreateNote(el));
                }
            }
        }
        private void RenewList(List<Student> new_list)
        {
            items.Items.Clear();
            FillData(new_list);
            currentSelect = new_list;
        }

        private List<Student> SelectByBullName(string fullname)
        {
            List<Student> ret = new List<Student>();
            Regex reg = new Regex(fullname, RegexOptions.IgnoreCase);
            
            foreach(Student el in studs)
            {
                Match match = reg.Match(el.FullName);
                if (match.Success)
                    ret.Add(el);
            }

            return ret;
        }
        private List<Student> SelectByBullName(List<Student> list, string fullname)
        {
            List<Student> ret = new List<Student>();
            Regex reg = new Regex(fullname, RegexOptions.IgnoreCase);

            foreach (Student el in list)
            {
                Match match = reg.Match(el.FullName);
                if (match.Success)
                    ret.Add(el);
            }

            return ret;
        }
        private List<Student> SelectBySpecialization(Student.SPEC spec)
        {
            List<Student> ret = new List<Student>();

            foreach(Student el in studs)
            {
                if (el.Spec == spec)
                    ret.Add(el);
            }

            return ret;
        }
        private List<Student> SelectBySpecialization(List<Student> list, Student.SPEC spec)
        {
            List<Student> ret = new List<Student>();

            foreach (Student el in list)
            {
                if (el.Spec == spec)
                    ret.Add(el);
            }

            return ret;
        }

        private List<Student> SelectByCourse(int course)
        {
            List<Student> ret = new List<Student>();

            foreach(Student el in studs)
            {
                if (el.Course == course)
                    ret.Add(el);
            }

            return ret;
        }
        private List<Student> SelectByCourse(List<Student> list, int course)
        {
            List<Student> ret = new List<Student>();

            foreach (Student el in list)
            {
                if (el.Course == course)
                    ret.Add(el);
            }

            return ret;
        }

        private List<Student> SelectByAverageMark(string mark)
        {
            List<Student> ret = new List<Student>();

            foreach(Student el in studs)
            {
                if (el.AverageMark >= Convert.ToDouble(mark))
                    ret.Add(el);
            }

            return ret;
        }

        private void SearchInfo(object sender, EventArgs e)
        {
            string PressedMenuItem = (sender as ToolStripMenuItem).Text;

            switch(PressedMenuItem)
            {
                case "ФИО":
                    GetFullNameWindow temp = new GetFullNameWindow();

                    temp.ShowDialog();
                    RenewList(SelectByBullName(temp.GetData()));

                    RenewStatusTB("поиск по ФИО");
                    temp.Dispose();
                    break;

                case "ПОИТ":
                    RenewList(SelectBySpecialization(Student.SPEC.POIT));
                    RenewStatusTB("поиск по специальности");
                    break;

                case "ДЭиВИ":
                    RenewList(SelectBySpecialization(Student.SPEC.DESIGNER));
                    RenewStatusTB("поиск по специальности");
                    break;

                case "ПОИБМС":
                    RenewList(SelectBySpecialization(Student.SPEC.MOBILE)); 
                    RenewStatusTB("поиск по специальности");
                    break;

                case "ИСИТ":
                    RenewList(SelectBySpecialization(Student.SPEC.ISIT));
                    RenewStatusTB("поиск по специальности");
                    break;

                case "1":
                    RenewList(SelectByCourse(1)); 
                    RenewStatusTB("поиск по курсу");
                    break;

                case "2":
                    RenewList(SelectByCourse(2));
                    RenewStatusTB("поиск по курсу");
                    break;

                case "3":
                    RenewList(SelectByCourse(3));
                    RenewStatusTB("поиск по курсу");
                    break;

                case "4":
                    RenewList(SelectByCourse(4));
                    RenewStatusTB("поиск по курсу");
                    break;

                case "Ср. Балл":
                    GetAverageMarkWindow markWin = new GetAverageMarkWindow();
                    markWin.ShowDialog();
                    RenewList(SelectByAverageMark(markWin.GetData()));
                    RenewStatusTB("поиск по баллу");
                    break;

                case "Настроить..":
                    AdvancedSearch advsearch = new AdvancedSearch();
                    advsearch.ShowDialog();

                    currentSelect = studs;

                    var data = advsearch.GetData();
                    if(data.fullname != null)
                    {
                        currentSelect = SelectByBullName(currentSelect, data.fullname);
                    }
                    if(data.course != null)
                    {
                        currentSelect = SelectByCourse(currentSelect, Convert.ToByte(data.course.Value));
                    }
                    if (data.spec != null)
                    {
                        currentSelect = SelectBySpecialization(currentSelect, data.spec.Value);
                    }

                    RenewList(currentSelect);

                    RenewStatusTB("настраиваемый поиск");
                    break; // add new search form;
            }
        }
        private void About_StripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("@Berinchik Vladislav\nVersion 2.0", "Info");
        }
        private void Save_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialWin = new SaveFileDialog();
            dialWin.DefaultExt = ".json";
            dialWin.InitialDirectory = @"D:\Лабы\OOP\2k2s\LPLab02-03";
            dialWin.OverwritePrompt = true;
            dialWin.Filter = "Json файлы(*.txt)|*.txt";
            
            if (dialWin.ShowDialog() == DialogResult.Cancel)
                return;

            using (StreamWriter fs = new StreamWriter(dialWin.FileName))
            {
                fs.WriteLine(JsonSerializer.Serialize<List<Student>>(currentSelect));
            }

        }
        private void SortSelectedList(object sender, EventArgs e)
        {
            dynamic selection;
            List<Student> sortedList = new List<Student>();
            switch((sender as ToolStripMenuItem).Text)
            {
                case "по ФИО":
                    selection = currentSelect.OrderBy((el) => el.FullName);

                    foreach (Student el in selection)
                    {
                        sortedList.Add(el);
                    }

                    RenewList(currentSelect = sortedList);

                    RenewStatusTB("сортировка по ФИО");
                    break;

                case "по дате рождения":
                    selection = currentSelect.OrderBy((el) => el.Birthday);

                    foreach (Student el in selection)
                    {
                        sortedList.Add(el);
                    }

                    RenewList(currentSelect = sortedList);
                    RenewStatusTB("сортировка по дате рождения");
                    break;

                case "по специальности":
                    selection = currentSelect.OrderBy((el) => el.Spec);

                    foreach (Student el in selection)
                    {
                        sortedList.Add(el);
                    }

                    RenewList(currentSelect = sortedList);

                    RenewStatusTB("сортировка по специальности");
                    break;

                case "по курсу":
                    selection = currentSelect.OrderBy((el) => el.Course);

                    foreach (Student el in selection)
                    {
                        sortedList.Add(el);
                    }

                    RenewList(currentSelect = sortedList);

                    RenewStatusTB("сортировка по курсу");
                    break;
            }
        }
        private void RenewStatusTB(string operation)
        {
            status_label.Text =
                $"Количество обьектов: " +
                $"{currentSelect.Count()}. " +
                $"Последняя операция: {operation}...";
        }

        private void turnOnOffTools_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tools.Visible = !this.tools.Visible;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time_label.Text = DateTime.Now.ToString();
        }
    }
}
