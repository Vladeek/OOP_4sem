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
    public partial class GetAverageMarkWindow : Form
    {
        public string GetData()
        {
            return this.maskedTextBox_averageMark.Text.Replace(' ', '0');
        }

        public GetAverageMarkWindow()
        {
            InitializeComponent();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
