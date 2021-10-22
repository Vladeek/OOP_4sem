using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPLab02
{
    public partial class AdvancedSearch : Form
    {
        public AdvancedSearch()
        {
            InitializeComponent();
        }

        public (string fullname, int? course, Student.SPEC? spec) GetData()
        {
            (string fullname, int? course, Student.SPEC? spec) retCor = (null, null, null);

            if (this.fullname_textBox.Enabled) { retCor.fullname = this.fullname_textBox.Text; }
            if(this.course_groupBox.Enabled)
            {
                foreach(RadioButton el in course_groupBox.Controls)
                {
                    if (el.Checked) { retCor.course = Convert.ToInt32(el.Text); break; }
                }
            }
            if (this.spec_groupBox.Enabled)
            {
                foreach (RadioButton el in spec_groupBox.Controls)
                {
                    if (el.Checked)
                    {
                        switch(el.Text)
                        {
                            case "ПОИТ": retCor.spec = Student.SPEC.POIT; break;
                            case "ПОиБМС": retCor.spec = Student.SPEC.MOBILE; break;
                            case "ДЭиВИ": retCor.spec = Student.SPEC.DESIGNER; break;
                            case "ИСИТ": retCor.spec = Student.SPEC.ISIT; break;
                        }
                        break;
                    }
                }
            }
            return retCor;
        }

        private void fullName_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked) { fullname_textBox.Enabled = true; }
            else { fullname_textBox.Enabled = false; }
        }
        private void course_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked) { course_groupBox.Enabled = true; }
            else { course_groupBox.Enabled = false; }
        }
        private void spec_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked) { spec_groupBox.Enabled = true; }
            else { spec_groupBox.Enabled = false; }
        }

        private void OK_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
