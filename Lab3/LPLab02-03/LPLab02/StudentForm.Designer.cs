
namespace LPLab02
{
    partial class StudentForm
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
            this.textbox_name = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.label_age = new System.Windows.Forms.Label();
            this.ageScrollBar = new System.Windows.Forms.HScrollBar();
            this.ageShow_label = new System.Windows.Forms.Label();
            this.radio_poit = new System.Windows.Forms.RadioButton();
            this.radio_poibams = new System.Windows.Forms.RadioButton();
            this.radio_designer = new System.Windows.Forms.RadioButton();
            this.radio_isit = new System.Windows.Forms.RadioButton();
            this.label_birthday = new System.Windows.Forms.Label();
            this.dateTimePicker_birthday = new System.Windows.Forms.DateTimePicker();
            this.groupBox_spec = new System.Windows.Forms.GroupBox();
            this.groupBox_course = new System.Windows.Forms.GroupBox();
            this.radioButton_course4 = new System.Windows.Forms.RadioButton();
            this.radioButton_course3 = new System.Windows.Forms.RadioButton();
            this.radioButton_course2 = new System.Windows.Forms.RadioButton();
            this.radioButton_course1 = new System.Windows.Forms.RadioButton();
            this.label_group = new System.Windows.Forms.Label();
            this.numericUpDown_group = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBox_averageMark = new System.Windows.Forms.MaskedTextBox();
            this.label_averageMark = new System.Windows.Forms.Label();
            this.groupBox_gender = new System.Windows.Forms.GroupBox();
            this.radioButton_female = new System.Windows.Forms.RadioButton();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.groupBox_adress = new System.Windows.Forms.GroupBox();
            this.textBox_flatNumber = new System.Windows.Forms.TextBox();
            this.label_flatNumber = new System.Windows.Forms.Label();
            this.numericUpDown_houseNumber = new System.Windows.Forms.NumericUpDown();
            this.label_houseNumber = new System.Windows.Forms.Label();
            this.textBox_street = new System.Windows.Forms.TextBox();
            this.label_street = new System.Windows.Forms.Label();
            this.maskedTextBox_index = new System.Windows.Forms.MaskedTextBox();
            this.label_index = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.label_city = new System.Windows.Forms.Label();
            this.button_send = new System.Windows.Forms.Button();
            this.button_get = new System.Windows.Forms.Button();
            this.groupBox_spec.SuspendLayout();
            this.groupBox_course.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_group)).BeginInit();
            this.groupBox_gender.SuspendLayout();
            this.groupBox_adress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_houseNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_name
            // 
            this.textbox_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textbox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textbox_name.Location = new System.Drawing.Point(124, 33);
            this.textbox_name.MaxLength = 64;
            this.textbox_name.Name = "textbox_name";
            this.textbox_name.Size = new System.Drawing.Size(333, 27);
            this.textbox_name.TabIndex = 0;
            this.textbox_name.Tag = false;
            this.textbox_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_name_KeyPress);
            this.textbox_name.Leave += new System.EventHandler(this.textbox_name_Leave);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.Location = new System.Drawing.Point(18, 33);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(49, 20);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "ФИО";
            // 
            // label_age
            // 
            this.label_age.AutoSize = true;
            this.label_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_age.Location = new System.Drawing.Point(10, 82);
            this.label_age.Name = "label_age";
            this.label_age.Size = new System.Drawing.Size(79, 20);
            this.label_age.TabIndex = 2;
            this.label_age.Text = "Возраст";
            // 
            // ageScrollBar
            // 
            this.ageScrollBar.Location = new System.Drawing.Point(124, 82);
            this.ageScrollBar.Minimum = 17;
            this.ageScrollBar.Name = "ageScrollBar";
            this.ageScrollBar.Size = new System.Drawing.Size(286, 21);
            this.ageScrollBar.TabIndex = 4;
            this.ageScrollBar.Tag = true;
            this.ageScrollBar.Value = 17;
            this.ageScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ageScrollBar_Scroll);
            // 
            // ageShow_label
            // 
            this.ageShow_label.AutoSize = true;
            this.ageShow_label.Location = new System.Drawing.Point(425, 82);
            this.ageShow_label.Name = "ageShow_label";
            this.ageShow_label.Size = new System.Drawing.Size(32, 17);
            this.ageShow_label.TabIndex = 5;
            this.ageShow_label.Text = "age";
            // 
            // radio_poit
            // 
            this.radio_poit.AutoSize = true;
            this.radio_poit.Checked = true;
            this.radio_poit.Location = new System.Drawing.Point(6, 51);
            this.radio_poit.Name = "radio_poit";
            this.radio_poit.Size = new System.Drawing.Size(74, 24);
            this.radio_poit.TabIndex = 7;
            this.radio_poit.TabStop = true;
            this.radio_poit.Text = "ПОИТ";
            this.radio_poit.UseVisualStyleBackColor = true;
            // 
            // radio_poibams
            // 
            this.radio_poibams.AutoSize = true;
            this.radio_poibams.Location = new System.Drawing.Point(270, 51);
            this.radio_poibams.Name = "radio_poibams";
            this.radio_poibams.Size = new System.Drawing.Size(98, 24);
            this.radio_poibams.TabIndex = 8;
            this.radio_poibams.Text = "ПОиБМС";
            this.radio_poibams.UseVisualStyleBackColor = true;
            // 
            // radio_designer
            // 
            this.radio_designer.AutoSize = true;
            this.radio_designer.Location = new System.Drawing.Point(175, 51);
            this.radio_designer.Name = "radio_designer";
            this.radio_designer.Size = new System.Drawing.Size(85, 24);
            this.radio_designer.TabIndex = 9;
            this.radio_designer.Text = "ДЭиВИ";
            this.radio_designer.UseVisualStyleBackColor = true;
            // 
            // radio_isit
            // 
            this.radio_isit.AutoSize = true;
            this.radio_isit.Location = new System.Drawing.Point(93, 51);
            this.radio_isit.Name = "radio_isit";
            this.radio_isit.Size = new System.Drawing.Size(72, 24);
            this.radio_isit.TabIndex = 10;
            this.radio_isit.Text = "ИСИТ";
            this.radio_isit.UseVisualStyleBackColor = true;
            // 
            // label_birthday
            // 
            this.label_birthday.AutoSize = true;
            this.label_birthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_birthday.Location = new System.Drawing.Point(12, 234);
            this.label_birthday.Name = "label_birthday";
            this.label_birthday.Size = new System.Drawing.Size(72, 20);
            this.label_birthday.TabIndex = 11;
            this.label_birthday.Text = "Дата Р.";
            // 
            // dateTimePicker_birthday
            // 
            this.dateTimePicker_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_birthday.Location = new System.Drawing.Point(124, 234);
            this.dateTimePicker_birthday.Name = "dateTimePicker_birthday";
            this.dateTimePicker_birthday.Size = new System.Drawing.Size(120, 22);
            this.dateTimePicker_birthday.TabIndex = 12;
            this.dateTimePicker_birthday.Tag = true;
            this.dateTimePicker_birthday.Leave += new System.EventHandler(this.dateTimePicker_birthday_Leave);
            // 
            // groupBox_spec
            // 
            this.groupBox_spec.Controls.Add(this.radio_poit);
            this.groupBox_spec.Controls.Add(this.radio_poibams);
            this.groupBox_spec.Controls.Add(this.radio_designer);
            this.groupBox_spec.Controls.Add(this.radio_isit);
            this.groupBox_spec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_spec.Location = new System.Drawing.Point(16, 118);
            this.groupBox_spec.Name = "groupBox_spec";
            this.groupBox_spec.Size = new System.Drawing.Size(441, 84);
            this.groupBox_spec.TabIndex = 14;
            this.groupBox_spec.TabStop = false;
            this.groupBox_spec.Tag = true;
            this.groupBox_spec.Text = "Специальность";
            // 
            // groupBox_course
            // 
            this.groupBox_course.Controls.Add(this.radioButton_course4);
            this.groupBox_course.Controls.Add(this.radioButton_course3);
            this.groupBox_course.Controls.Add(this.radioButton_course2);
            this.groupBox_course.Controls.Add(this.radioButton_course1);
            this.groupBox_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.1F);
            this.groupBox_course.Location = new System.Drawing.Point(14, 262);
            this.groupBox_course.Name = "groupBox_course";
            this.groupBox_course.Size = new System.Drawing.Size(443, 52);
            this.groupBox_course.TabIndex = 15;
            this.groupBox_course.TabStop = false;
            this.groupBox_course.Tag = true;
            this.groupBox_course.Text = "Курс";
            // 
            // radioButton_course4
            // 
            this.radioButton_course4.AutoSize = true;
            this.radioButton_course4.Location = new System.Drawing.Point(140, 21);
            this.radioButton_course4.Name = "radioButton_course4";
            this.radioButton_course4.Size = new System.Drawing.Size(39, 24);
            this.radioButton_course4.TabIndex = 3;
            this.radioButton_course4.Text = "4";
            this.radioButton_course4.UseVisualStyleBackColor = true;
            // 
            // radioButton_course3
            // 
            this.radioButton_course3.AutoSize = true;
            this.radioButton_course3.Location = new System.Drawing.Point(95, 21);
            this.radioButton_course3.Name = "radioButton_course3";
            this.radioButton_course3.Size = new System.Drawing.Size(39, 24);
            this.radioButton_course3.TabIndex = 2;
            this.radioButton_course3.Text = "3";
            this.radioButton_course3.UseVisualStyleBackColor = true;
            // 
            // radioButton_course2
            // 
            this.radioButton_course2.AutoSize = true;
            this.radioButton_course2.Location = new System.Drawing.Point(48, 21);
            this.radioButton_course2.Name = "radioButton_course2";
            this.radioButton_course2.Size = new System.Drawing.Size(39, 24);
            this.radioButton_course2.TabIndex = 1;
            this.radioButton_course2.Text = "2";
            this.radioButton_course2.UseVisualStyleBackColor = true;
            // 
            // radioButton_course1
            // 
            this.radioButton_course1.AutoSize = true;
            this.radioButton_course1.Checked = true;
            this.radioButton_course1.Location = new System.Drawing.Point(3, 21);
            this.radioButton_course1.Name = "radioButton_course1";
            this.radioButton_course1.Size = new System.Drawing.Size(39, 24);
            this.radioButton_course1.TabIndex = 0;
            this.radioButton_course1.TabStop = true;
            this.radioButton_course1.Text = "1";
            this.radioButton_course1.UseVisualStyleBackColor = true;
            // 
            // label_group
            // 
            this.label_group.AutoSize = true;
            this.label_group.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_group.Location = new System.Drawing.Point(10, 326);
            this.label_group.Name = "label_group";
            this.label_group.Size = new System.Drawing.Size(67, 20);
            this.label_group.TabIndex = 16;
            this.label_group.Text = "Группа";
            // 
            // numericUpDown_group
            // 
            this.numericUpDown_group.Location = new System.Drawing.Point(124, 326);
            this.numericUpDown_group.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.numericUpDown_group.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_group.Name = "numericUpDown_group";
            this.numericUpDown_group.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_group.TabIndex = 17;
            this.numericUpDown_group.Tag = true;
            this.numericUpDown_group.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maskedTextBox_averageMark
            // 
            this.maskedTextBox_averageMark.Location = new System.Drawing.Point(124, 365);
            this.maskedTextBox_averageMark.Mask = "9.99";
            this.maskedTextBox_averageMark.Name = "maskedTextBox_averageMark";
            this.maskedTextBox_averageMark.Size = new System.Drawing.Size(33, 22);
            this.maskedTextBox_averageMark.TabIndex = 18;
            this.maskedTextBox_averageMark.Tag = false;
            this.maskedTextBox_averageMark.Leave += new System.EventHandler(this.maskedTextBox_averageMark_Leave);
            // 
            // label_averageMark
            // 
            this.label_averageMark.AutoSize = true;
            this.label_averageMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_averageMark.Location = new System.Drawing.Point(12, 365);
            this.label_averageMark.Name = "label_averageMark";
            this.label_averageMark.Size = new System.Drawing.Size(77, 20);
            this.label_averageMark.TabIndex = 19;
            this.label_averageMark.Text = "Ср.Балл";
            // 
            // groupBox_gender
            // 
            this.groupBox_gender.Controls.Add(this.radioButton_female);
            this.groupBox_gender.Controls.Add(this.radioButton_male);
            this.groupBox_gender.Location = new System.Drawing.Point(12, 393);
            this.groupBox_gender.Name = "groupBox_gender";
            this.groupBox_gender.Size = new System.Drawing.Size(200, 53);
            this.groupBox_gender.TabIndex = 20;
            this.groupBox_gender.TabStop = false;
            this.groupBox_gender.Tag = true;
            this.groupBox_gender.Text = "Пол";
            // 
            // radioButton_female
            // 
            this.radioButton_female.AutoSize = true;
            this.radioButton_female.Location = new System.Drawing.Point(51, 21);
            this.radioButton_female.Name = "radioButton_female";
            this.radioButton_female.Size = new System.Drawing.Size(42, 21);
            this.radioButton_female.TabIndex = 5;
            this.radioButton_female.Text = "Ж";
            this.radioButton_female.UseVisualStyleBackColor = true;
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Checked = true;
            this.radioButton_male.Location = new System.Drawing.Point(6, 21);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(40, 21);
            this.radioButton_male.TabIndex = 4;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "М";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // groupBox_adress
            // 
            this.groupBox_adress.Controls.Add(this.textBox_flatNumber);
            this.groupBox_adress.Controls.Add(this.label_flatNumber);
            this.groupBox_adress.Controls.Add(this.numericUpDown_houseNumber);
            this.groupBox_adress.Controls.Add(this.label_houseNumber);
            this.groupBox_adress.Controls.Add(this.textBox_street);
            this.groupBox_adress.Controls.Add(this.label_street);
            this.groupBox_adress.Controls.Add(this.maskedTextBox_index);
            this.groupBox_adress.Controls.Add(this.label_index);
            this.groupBox_adress.Controls.Add(this.textBox_city);
            this.groupBox_adress.Controls.Add(this.label_city);
            this.groupBox_adress.Location = new System.Drawing.Point(517, 33);
            this.groupBox_adress.Name = "groupBox_adress";
            this.groupBox_adress.Size = new System.Drawing.Size(548, 281);
            this.groupBox_adress.TabIndex = 21;
            this.groupBox_adress.TabStop = false;
            this.groupBox_adress.Text = "Адрес";
            // 
            // textBox_flatNumber
            // 
            this.textBox_flatNumber.Location = new System.Drawing.Point(87, 186);
            this.textBox_flatNumber.MaxLength = 3;
            this.textBox_flatNumber.Name = "textBox_flatNumber";
            this.textBox_flatNumber.Size = new System.Drawing.Size(67, 22);
            this.textBox_flatNumber.TabIndex = 30;
            this.textBox_flatNumber.Tag = true;
            this.textBox_flatNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_flatNumber_KeyPress);
            this.textBox_flatNumber.Leave += new System.EventHandler(this.textBox_flatNumber_Leave);
            // 
            // label_flatNumber
            // 
            this.label_flatNumber.AutoSize = true;
            this.label_flatNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_flatNumber.Location = new System.Drawing.Point(6, 186);
            this.label_flatNumber.Name = "label_flatNumber";
            this.label_flatNumber.Size = new System.Drawing.Size(34, 20);
            this.label_flatNumber.TabIndex = 29;
            this.label_flatNumber.Text = "Кв.";
            // 
            // numericUpDown_houseNumber
            // 
            this.numericUpDown_houseNumber.Location = new System.Drawing.Point(87, 150);
            this.numericUpDown_houseNumber.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDown_houseNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_houseNumber.Name = "numericUpDown_houseNumber";
            this.numericUpDown_houseNumber.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_houseNumber.TabIndex = 22;
            this.numericUpDown_houseNumber.Tag = true;
            this.numericUpDown_houseNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_houseNumber.Leave += new System.EventHandler(this.numericUpDown_houseNumber_Leave);
            // 
            // label_houseNumber
            // 
            this.label_houseNumber.AutoSize = true;
            this.label_houseNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_houseNumber.Location = new System.Drawing.Point(6, 149);
            this.label_houseNumber.Name = "label_houseNumber";
            this.label_houseNumber.Size = new System.Drawing.Size(44, 20);
            this.label_houseNumber.TabIndex = 28;
            this.label_houseNumber.Text = "Дом";
            // 
            // textBox_street
            // 
            this.textBox_street.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_street.Location = new System.Drawing.Point(87, 119);
            this.textBox_street.MaxLength = 32;
            this.textBox_street.Name = "textBox_street";
            this.textBox_street.Size = new System.Drawing.Size(170, 22);
            this.textBox_street.TabIndex = 27;
            this.textBox_street.Tag = false;
            this.textBox_street.Leave += new System.EventHandler(this.textBox_street_Leave);
            // 
            // label_street
            // 
            this.label_street.AutoSize = true;
            this.label_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_street.Location = new System.Drawing.Point(6, 121);
            this.label_street.Name = "label_street";
            this.label_street.Size = new System.Drawing.Size(60, 20);
            this.label_street.TabIndex = 26;
            this.label_street.Text = "Улица";
            // 
            // maskedTextBox_index
            // 
            this.maskedTextBox_index.Location = new System.Drawing.Point(87, 85);
            this.maskedTextBox_index.Mask = "999999";
            this.maskedTextBox_index.Name = "maskedTextBox_index";
            this.maskedTextBox_index.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox_index.TabIndex = 25;
            this.maskedTextBox_index.Tag = false;
            this.maskedTextBox_index.Leave += new System.EventHandler(this.maskedTextBox_index_Leave);
            // 
            // label_index
            // 
            this.label_index.AutoSize = true;
            this.label_index.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_index.Location = new System.Drawing.Point(6, 85);
            this.label_index.Name = "label_index";
            this.label_index.Size = new System.Drawing.Size(70, 20);
            this.label_index.TabIndex = 24;
            this.label_index.Text = "Индекс";
            // 
            // textBox_city
            // 
            this.textBox_city.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_city.Location = new System.Drawing.Point(87, 48);
            this.textBox_city.MaxLength = 32;
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(170, 22);
            this.textBox_city.TabIndex = 23;
            this.textBox_city.Tag = false;
            this.textBox_city.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_city_KeyPress);
            this.textBox_city.Leave += new System.EventHandler(this.textBox_city_Leave);
            // 
            // label_city
            // 
            this.label_city.AutoSize = true;
            this.label_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_city.Location = new System.Drawing.Point(6, 46);
            this.label_city.Name = "label_city";
            this.label_city.Size = new System.Drawing.Size(61, 20);
            this.label_city.TabIndex = 22;
            this.label_city.Text = "Город";
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(928, 326);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(137, 39);
            this.button_send.TabIndex = 22;
            this.button_send.Text = "Отправить";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // button_get
            // 
            this.button_get.Location = new System.Drawing.Point(928, 393);
            this.button_get.Name = "button_get";
            this.button_get.Size = new System.Drawing.Size(137, 39);
            this.button_get.TabIndex = 23;
            this.button_get.Text = "Получить";
            this.button_get.UseVisualStyleBackColor = true;
            this.button_get.Click += new System.EventHandler(this.button_get_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 450);
            this.Controls.Add(this.button_get);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.groupBox_adress);
            this.Controls.Add(this.groupBox_gender);
            this.Controls.Add(this.label_averageMark);
            this.Controls.Add(this.maskedTextBox_averageMark);
            this.Controls.Add(this.numericUpDown_group);
            this.Controls.Add(this.label_group);
            this.Controls.Add(this.groupBox_course);
            this.Controls.Add(this.groupBox_spec);
            this.Controls.Add(this.dateTimePicker_birthday);
            this.Controls.Add(this.label_birthday);
            this.Controls.Add(this.ageShow_label);
            this.Controls.Add(this.ageScrollBar);
            this.Controls.Add(this.label_age);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textbox_name);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1095, 497);
            this.MinimumSize = new System.Drawing.Size(1095, 497);
            this.Name = "StudentForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.groupBox_spec.ResumeLayout(false);
            this.groupBox_spec.PerformLayout();
            this.groupBox_course.ResumeLayout(false);
            this.groupBox_course.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_group)).EndInit();
            this.groupBox_gender.ResumeLayout(false);
            this.groupBox_gender.PerformLayout();
            this.groupBox_adress.ResumeLayout(false);
            this.groupBox_adress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_houseNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_name;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_age;
        private System.Windows.Forms.HScrollBar ageScrollBar;
        private System.Windows.Forms.Label ageShow_label;
        private System.Windows.Forms.RadioButton radio_poit;
        private System.Windows.Forms.RadioButton radio_poibams;
        private System.Windows.Forms.RadioButton radio_designer;
        private System.Windows.Forms.RadioButton radio_isit;
        private System.Windows.Forms.Label label_birthday;
        private System.Windows.Forms.DateTimePicker dateTimePicker_birthday;
        private System.Windows.Forms.GroupBox groupBox_spec;
        private System.Windows.Forms.GroupBox groupBox_course;
        private System.Windows.Forms.RadioButton radioButton_course4;
        private System.Windows.Forms.RadioButton radioButton_course3;
        private System.Windows.Forms.RadioButton radioButton_course2;
        private System.Windows.Forms.RadioButton radioButton_course1;
        private System.Windows.Forms.Label label_group;
        private System.Windows.Forms.NumericUpDown numericUpDown_group;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_averageMark;
        private System.Windows.Forms.Label label_averageMark;
        private System.Windows.Forms.GroupBox groupBox_gender;
        private System.Windows.Forms.RadioButton radioButton_female;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.GroupBox groupBox_adress;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.Label label_city;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_index;
        private System.Windows.Forms.Label label_index;
        private System.Windows.Forms.NumericUpDown numericUpDown_houseNumber;
        private System.Windows.Forms.Label label_houseNumber;
        private System.Windows.Forms.TextBox textBox_street;
        private System.Windows.Forms.Label label_street;
        private System.Windows.Forms.TextBox textBox_flatNumber;
        private System.Windows.Forms.Label label_flatNumber;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Button button_get;
    }
}

