using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Text.Json;
using System.IO;
using System.ComponentModel.DataAnnotations;

namespace LPLab02
{
    public partial class StudentForm : Form
    {
        private List<Student> studs;

        //Паттерн Хранитель(Memento) позволяет выносить
        //внутреннее состояние объекта за его пределы для
        //последующего возможного восстановления объекта без
        //нарушения принципа инкапсуляции.

        private StudListState getListState()
        {
            string data = JsonSerializer.Serialize(studs);
            return new StudListState(data);
        }

        private void setListState(StudListState state)
        {
            studs = JsonSerializer.Deserialize<List<Student>>(state.Data);
        }

        public StudentForm()
        {
            InitializeComponent();
            ageShow_label.Text = ageScrollBar.Value.ToString();
            studs = new List<Student>();
            if (File.Exists(@"data.json"))
            {
                string res;
                using (StreamReader fs = new StreamReader(@"data.json"))
                {
                    res = fs.ReadToEnd();
                }

                List<Student> temp = null;
                try
                {
                    temp = JsonSerializer.Deserialize<List<Student>>(res);
                }
                catch
                {
                    temp = null;
                }
                if (temp != null)
                {
                    studs.AddRange(temp);
                }
                else
                {
                    MessageBox.Show("Файл поврежден или недоступен", "Ошибка данных");
                    FileInfo f = new FileInfo(@"data.json");
                    f.Delete();
                    return;
                }
            }
            else MessageBox.Show("Информация отсутсвует", "Ошибка данных");
        }

        private void UnvalidatedControl(Control control)
        {
            control.BackColor = Color.Tomato;
            control.Tag = false;
        }

        private void ValidatedControl(Control control)
        {
            control.BackColor = Color.White;
            control.Tag = true;
        }

        private void ageScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            ageShow_label.Text = ageScrollBar.Value.ToString();
        }

        private void textBox_flatNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char newChar = e.KeyChar;
            if (!Char.IsDigit(newChar) && !Char.IsControl(newChar))
            {
                e.Handled = true; // не заполнять
            }
        }

        private void textBox_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            char newChar = e.KeyChar;
            if (!Char.IsLetter(newChar) && !Char.IsControl(newChar))
            {
                e.Handled = true; // не заполнять
            }
        }

        private void textbox_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            char newChar = e.KeyChar;
            if ((Char.IsDigit(newChar) && !Char.IsControl(newChar) && newChar != '-') || newChar == '!')
            {
                e.Handled = true; // не заполнять
            }
        }

        private void textbox_name_Leave(object sender, EventArgs e) // fullname validating
        {
            if (textbox_name.Text == "")
            {
                UnvalidatedControl(textbox_name);
                return;
            }
            string[] slices = textbox_name.Text.Split(' ');
            if (slices.Length != 3)
            {
                UnvalidatedControl(textbox_name);
                return;
            }
            foreach (string el in slices)
            {
                if (el.StartsWith(" ") || el.StartsWith("-") || el.Length == 0)
                {
                    UnvalidatedControl(textbox_name);
                    return;
                }
            }

            ValidatedControl(textbox_name);
        }

        private void dateTimePicker_birthday_Leave(object sender, EventArgs e) // birthday validating
        {
            ValidatedControl(dateTimePicker_birthday);//cant change background     
        }

        private void maskedTextBox_averageMark_Leave(object sender, EventArgs e)
        {
            if (maskedTextBox_averageMark.Text[0] == ' ')
            {
                maskedTextBox_averageMark.Clear();
                UnvalidatedControl(maskedTextBox_averageMark);
                return;
            }
            ValidatedControl(maskedTextBox_averageMark);
        }

        private void textBox_city_Leave(object sender, EventArgs e)
        {
            if (textBox_city.Text.Length == 0)
            {
                UnvalidatedControl(textBox_city);
            }
            else
            {
                ValidatedControl(textBox_city);
            }
        }

        private void maskedTextBox_index_Leave(object sender, EventArgs e)
        {
            if (maskedTextBox_index.Text.Length != 6)
            {
                UnvalidatedControl(maskedTextBox_index);
            }
            else
            {
                ValidatedControl(maskedTextBox_index);
            }
        }

        private void textBox_street_Leave(object sender, EventArgs e)
        {
            if (textBox_street.Text.Length != 0)
            {
                ValidatedControl(textBox_street);
            }
            else
            {
                UnvalidatedControl(textBox_street);
            }
        }

        private void numericUpDown_houseNumber_Leave(object sender, EventArgs e)
        {
            ValidatedControl(numericUpDown_houseNumber);
        }

        private void textBox_flatNumber_Leave(object sender, EventArgs e)
        {
            ValidatedControl(label_flatNumber);
        }

        private void button_get_Click(object sender, EventArgs e)
        {
            var memento = getListState();

            studs.Clear();

            if (File.Exists(@"data.json"))
            {
                string res;
                using (StreamReader fs = new StreamReader(@"data.json"))
                {
                    res = fs.ReadToEnd();
                }

                List<Student> temp = null;
                try
                {
                    temp = JsonSerializer.Deserialize<List<Student>>(res); 
                }
                catch
                {
                    temp = null;
                }
                if (temp != null)
                {
                    studs.AddRange(temp);
                } else
                {
                    MessageBox.Show("Файл поврежден или недоступен", "Ошибка данных");
                    FileInfo f = new FileInfo(@"data.json");
                    f.Delete();

                    setListState(memento);

                    return;
                }
                OutputForm nf = new OutputForm(studs);
                nf.ShowDialog();
                // считывание, проверка и вывод в окно
            }
            else MessageBox.Show("Информация отсутсвует", "Ошибка данных");
        } 

        private void button_send_Click(object sender, EventArgs e)// уже лучше  
        {
            if (ValidateForm())
            {
                // if validated
                //Student newStudent = new Student();
                IStudentBuilder builder = new StudentBuilder();
                //newStudent.FullName = textbox_name.Text;
                //newStudent.Age = (byte)ageScrollBar.Value;
                builder
                    .setFullName(textbox_name.Text)
                    .setAge((byte)ageScrollBar.Value);
                foreach (RadioButton el in groupBox_spec.Controls)
                {
                    if (el.Checked)
                    {
                        if (el.Name.Contains("poit")) builder.setSpec(Student.SPEC.POIT);
                        if (el.Name.Contains("isit")) builder.setSpec(Student.SPEC.ISIT);
                        if (el.Name.Contains("poibams")) builder.setSpec(Student.SPEC.MOBILE);
                        if (el.Name.Contains("designer")) builder.setSpec(Student.SPEC.DESIGNER);
                    }
                }
                //newStudent.Birthday = dateTimePicker_birthday.Value;
                builder.setBirthday(dateTimePicker_birthday.Value);
                foreach (RadioButton el in groupBox_course.Controls)
                {
                    if (el.Checked) builder.setCourse(byte.Parse(el.Name.Reverse().First().ToString()));
                }
                //newStudent.Group = (byte)numericUpDown_group.Value;
                //newStudent.AverageMark = float.Parse(maskedTextBox_averageMark.Text);
                builder
                    .setGroup((byte)numericUpDown_group.Value)
                    .setAverageMark(float.Parse(maskedTextBox_averageMark.Text))
                    .setGender(radioButton_male.Checked ? Student.GENDER.Male : Student.GENDER.Female);
                //if (radioButton_male.Checked) newStudent.Gen = Student.GENDER.Male;
                //else newStudent.Gen = Student.GENDER.Female;

                //агрегация тут
                Address newAddress = new Address(
                    textBox_city.Text,
                    int.Parse(maskedTextBox_index.Text),
                    textBox_street.Text,
                    byte.Parse(numericUpDown_houseNumber.Value.ToString())
                    );
                if (textBox_flatNumber.Text.Length != 0) newAddress.FlatNumber = byte.Parse(textBox_flatNumber.Text);

                //newStudent.Addr = newAddress;
                builder.setAddress(newAddress);

                if(ValidateStudent(builder.getResult()))
                    studs.Add(builder.getResult());
                else { MessageBox.Show("Ошибка валидации..", "Validation Error!"); return; }
                
                string js = JsonSerializer.Serialize<List<Student>>(studs);
                using (StreamWriter sw = new StreamWriter(@"data.json", false))
                {
                    sw.Write(js);
                }

                MessageBox.Show("Форма успешно добавлена!", "Добавление формы");
            }
            else MessageBox.Show("Имеются ошибочные поля.", "Form Error");
        }

        private bool ValidateStudent(Student el)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(el);
            if(Validator.TryValidateObject(el, context, results, false))
                return true;

            return false;
        }
        private bool ValidateForm()
        {
            bool ri = true;
            foreach (Control el in this.Controls)
            {
                if (el is RadioButton) continue;
                //MessageBox.Show(el.Name);
                if (el is GroupBox)
                {
                    foreach (Control g_el in el.Controls)
                    {
                        if (g_el.Tag != null)
                        {
                            if ((bool)(g_el.Tag) == false)
                            {
                                UnvalidatedControl(g_el);
                                ri = false;
                            }
                        }
                    }
                }
                if (el.Tag != null)
                {
                    if ((bool)(el.Tag) == false)
                    {
                        UnvalidatedControl(el);
                        ri = false;
                    }
                }
            }
            return ri;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = button_get;

            // optional
            IStudentFactory factory =
                //new PoitFactory();
                //new DesignFactory();
                new MobileFactory();
            MessageBox.Show(factory.CreateStudent().certainSpec.ToString());
        }

        private void StudentForm_Shown(object sender, EventArgs e)
        {
            StudentFormPropertiesSingleton props = StudentFormPropertiesSingleton.getInstance();
            props.BackColor = this.BackColor;
            props.FormFont = this.Font;
            props.FormHeight = this.Height;
            props.FormWidth = this.Width;

            //Student temp = new Student();
            //temp.Addr = new Address();
            //MessageBox.Show(temp.clone().ToString());

        }
    }
}
