
namespace LPLab02
{
    partial class AdvancedSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fullName_checkBox = new System.Windows.Forms.CheckBox();
            this.fullname_textBox = new System.Windows.Forms.TextBox();
            this.course_checkBox = new System.Windows.Forms.CheckBox();
            this.course_groupBox = new System.Windows.Forms.GroupBox();
            this.course_1_radioButton = new System.Windows.Forms.RadioButton();
            this.course_2_radioButton = new System.Windows.Forms.RadioButton();
            this.course_3_radioButton = new System.Windows.Forms.RadioButton();
            this.course_4_radioButton = new System.Windows.Forms.RadioButton();
            this.spec_checkBox = new System.Windows.Forms.CheckBox();
            this.spec_groupBox = new System.Windows.Forms.GroupBox();
            this.isit_radioButton = new System.Windows.Forms.RadioButton();
            this.mobile_radioButton = new System.Windows.Forms.RadioButton();
            this.design_radioButton = new System.Windows.Forms.RadioButton();
            this.poit_radioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.course_groupBox.SuspendLayout();
            this.spec_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // fullName_checkBox
            // 
            this.fullName_checkBox.AutoSize = true;
            this.fullName_checkBox.Location = new System.Drawing.Point(12, 12);
            this.fullName_checkBox.Name = "fullName_checkBox";
            this.fullName_checkBox.Size = new System.Drawing.Size(128, 21);
            this.fullName_checkBox.TabIndex = 0;
            this.fullName_checkBox.Text = "Поиск по ФИО\r\n";
            this.fullName_checkBox.UseVisualStyleBackColor = true;
            this.fullName_checkBox.CheckedChanged += new System.EventHandler(this.fullName_checkBox_CheckedChanged);
            // 
            // fullname_textBox
            // 
            this.fullname_textBox.Enabled = false;
            this.fullname_textBox.Location = new System.Drawing.Point(188, 11);
            this.fullname_textBox.MaxLength = 128;
            this.fullname_textBox.Name = "fullname_textBox";
            this.fullname_textBox.Size = new System.Drawing.Size(218, 22);
            this.fullname_textBox.TabIndex = 1;
            // 
            // course_checkBox
            // 
            this.course_checkBox.AutoSize = true;
            this.course_checkBox.Location = new System.Drawing.Point(12, 63);
            this.course_checkBox.Name = "course_checkBox";
            this.course_checkBox.Size = new System.Drawing.Size(130, 21);
            this.course_checkBox.TabIndex = 2;
            this.course_checkBox.Text = "Поиск по курсу";
            this.course_checkBox.UseMnemonic = false;
            this.course_checkBox.UseVisualStyleBackColor = true;
            this.course_checkBox.CheckedChanged += new System.EventHandler(this.course_checkBox_CheckedChanged);
            // 
            // course_groupBox
            // 
            this.course_groupBox.Controls.Add(this.course_4_radioButton);
            this.course_groupBox.Controls.Add(this.course_3_radioButton);
            this.course_groupBox.Controls.Add(this.course_2_radioButton);
            this.course_groupBox.Controls.Add(this.course_1_radioButton);
            this.course_groupBox.Enabled = false;
            this.course_groupBox.Location = new System.Drawing.Point(188, 39);
            this.course_groupBox.Name = "course_groupBox";
            this.course_groupBox.Size = new System.Drawing.Size(218, 54);
            this.course_groupBox.TabIndex = 3;
            this.course_groupBox.TabStop = false;
            // 
            // course_1_radioButton
            // 
            this.course_1_radioButton.AutoSize = true;
            this.course_1_radioButton.Checked = true;
            this.course_1_radioButton.Location = new System.Drawing.Point(3, 18);
            this.course_1_radioButton.Name = "course_1_radioButton";
            this.course_1_radioButton.Size = new System.Drawing.Size(37, 21);
            this.course_1_radioButton.TabIndex = 0;
            this.course_1_radioButton.TabStop = true;
            this.course_1_radioButton.Text = "1";
            this.course_1_radioButton.UseVisualStyleBackColor = true;
            // 
            // course_2_radioButton
            // 
            this.course_2_radioButton.AutoSize = true;
            this.course_2_radioButton.Location = new System.Drawing.Point(46, 18);
            this.course_2_radioButton.Name = "course_2_radioButton";
            this.course_2_radioButton.Size = new System.Drawing.Size(37, 21);
            this.course_2_radioButton.TabIndex = 0;
            this.course_2_radioButton.Text = "2";
            this.course_2_radioButton.UseVisualStyleBackColor = true;
            // 
            // course_3_radioButton
            // 
            this.course_3_radioButton.AutoSize = true;
            this.course_3_radioButton.Location = new System.Drawing.Point(89, 18);
            this.course_3_radioButton.Name = "course_3_radioButton";
            this.course_3_radioButton.Size = new System.Drawing.Size(37, 21);
            this.course_3_radioButton.TabIndex = 0;
            this.course_3_radioButton.Text = "3";
            this.course_3_radioButton.UseVisualStyleBackColor = true;
            // 
            // course_4_radioButton
            // 
            this.course_4_radioButton.AutoSize = true;
            this.course_4_radioButton.Location = new System.Drawing.Point(132, 18);
            this.course_4_radioButton.Name = "course_4_radioButton";
            this.course_4_radioButton.Size = new System.Drawing.Size(37, 21);
            this.course_4_radioButton.TabIndex = 0;
            this.course_4_radioButton.Text = "4";
            this.course_4_radioButton.UseVisualStyleBackColor = true;
            // 
            // spec_checkBox
            // 
            this.spec_checkBox.AutoSize = true;
            this.spec_checkBox.Location = new System.Drawing.Point(10, 121);
            this.spec_checkBox.Name = "spec_checkBox";
            this.spec_checkBox.Size = new System.Drawing.Size(125, 21);
            this.spec_checkBox.TabIndex = 2;
            this.spec_checkBox.Text = "Поиск по спец";
            this.spec_checkBox.UseMnemonic = false;
            this.spec_checkBox.UseVisualStyleBackColor = true;
            this.spec_checkBox.CheckedChanged += new System.EventHandler(this.spec_checkBox_CheckedChanged);
            // 
            // spec_groupBox
            // 
            this.spec_groupBox.Controls.Add(this.isit_radioButton);
            this.spec_groupBox.Controls.Add(this.mobile_radioButton);
            this.spec_groupBox.Controls.Add(this.design_radioButton);
            this.spec_groupBox.Controls.Add(this.poit_radioButton);
            this.spec_groupBox.Enabled = false;
            this.spec_groupBox.Location = new System.Drawing.Point(188, 99);
            this.spec_groupBox.Name = "spec_groupBox";
            this.spec_groupBox.Size = new System.Drawing.Size(218, 108);
            this.spec_groupBox.TabIndex = 3;
            this.spec_groupBox.TabStop = false;
            // 
            // isit_radioButton
            // 
            this.isit_radioButton.AutoSize = true;
            this.isit_radioButton.Location = new System.Drawing.Point(102, 18);
            this.isit_radioButton.Name = "isit_radioButton";
            this.isit_radioButton.Size = new System.Drawing.Size(67, 21);
            this.isit_radioButton.TabIndex = 0;
            this.isit_radioButton.Text = "ИСИТ";
            this.isit_radioButton.UseVisualStyleBackColor = true;
            // 
            // mobile_radioButton
            // 
            this.mobile_radioButton.AutoSize = true;
            this.mobile_radioButton.Location = new System.Drawing.Point(102, 65);
            this.mobile_radioButton.Name = "mobile_radioButton";
            this.mobile_radioButton.Size = new System.Drawing.Size(87, 21);
            this.mobile_radioButton.TabIndex = 0;
            this.mobile_radioButton.Text = "ПОиБМС";
            this.mobile_radioButton.UseVisualStyleBackColor = true;
            // 
            // design_radioButton
            // 
            this.design_radioButton.AutoSize = true;
            this.design_radioButton.Location = new System.Drawing.Point(6, 65);
            this.design_radioButton.Name = "design_radioButton";
            this.design_radioButton.Size = new System.Drawing.Size(76, 21);
            this.design_radioButton.TabIndex = 0;
            this.design_radioButton.Text = "ДЭиВИ";
            this.design_radioButton.UseVisualStyleBackColor = true;
            // 
            // poit_radioButton
            // 
            this.poit_radioButton.AutoSize = true;
            this.poit_radioButton.Checked = true;
            this.poit_radioButton.Location = new System.Drawing.Point(3, 18);
            this.poit_radioButton.Name = "poit_radioButton";
            this.poit_radioButton.Size = new System.Drawing.Size(69, 21);
            this.poit_radioButton.TabIndex = 0;
            this.poit_radioButton.TabStop = true;
            this.poit_radioButton.Text = "ПОИТ";
            this.poit_radioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поиск";
            this.button1.UseMnemonic = false;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.spec_groupBox);
            this.Controls.Add(this.course_groupBox);
            this.Controls.Add(this.spec_checkBox);
            this.Controls.Add(this.course_checkBox);
            this.Controls.Add(this.fullname_textBox);
            this.Controls.Add(this.fullName_checkBox);
            this.MaximumSize = new System.Drawing.Size(447, 312);
            this.MinimumSize = new System.Drawing.Size(447, 312);
            this.Name = "AdvancedSearch";
            this.Text = "AdvancedSearch";
            this.course_groupBox.ResumeLayout(false);
            this.course_groupBox.PerformLayout();
            this.spec_groupBox.ResumeLayout(false);
            this.spec_groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox fullName_checkBox;
        private System.Windows.Forms.TextBox fullname_textBox;
        private System.Windows.Forms.CheckBox course_checkBox;
        private System.Windows.Forms.GroupBox course_groupBox;
        private System.Windows.Forms.RadioButton course_4_radioButton;
        private System.Windows.Forms.RadioButton course_3_radioButton;
        private System.Windows.Forms.RadioButton course_2_radioButton;
        private System.Windows.Forms.RadioButton course_1_radioButton;
        private System.Windows.Forms.CheckBox spec_checkBox;
        private System.Windows.Forms.GroupBox spec_groupBox;
        private System.Windows.Forms.RadioButton isit_radioButton;
        private System.Windows.Forms.RadioButton mobile_radioButton;
        private System.Windows.Forms.RadioButton design_radioButton;
        private System.Windows.Forms.RadioButton poit_radioButton;
        private System.Windows.Forms.Button button1;
    }
}