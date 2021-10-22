
namespace LPLab02
{
    partial class OutputForm
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
            this.components = new System.ComponentModel.Container();
            this.items = new System.Windows.Forms.ListView();
            this.fullName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spec = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.course = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.averageMark = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Search_StripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.FullName_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Specialization_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пОИТToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дЭиВИToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иСИТToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пОИБМСToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Course_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.AverageMark_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdvanceSearch_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поФамилииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеРожденияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поСпециальностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКурсуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.about_StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вклВыклИнструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripMenuItem();
            this.sort_tool = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.status = new System.Windows.Forms.StatusStrip();
            this.status_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.time_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.tools.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // items
            // 
            this.items.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.items.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fullName,
            this.age,
            this.spec,
            this.birth,
            this.course,
            this.group,
            this.averageMark,
            this.gender,
            this.address});
            this.items.HideSelection = false;
            this.items.Location = new System.Drawing.Point(0, 31);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(1000, 400);
            this.items.TabIndex = 0;
            this.items.UseCompatibleStateImageBehavior = false;
            this.items.View = System.Windows.Forms.View.Details;
            // 
            // fullName
            // 
            this.fullName.Text = "ФИО";
            this.fullName.Width = 150;
            // 
            // age
            // 
            this.age.Text = "Возраст";
            // 
            // spec
            // 
            this.spec.Text = "Спец.";
            // 
            // birth
            // 
            this.birth.Text = "Д.р.";
            this.birth.Width = 90;
            // 
            // course
            // 
            this.course.Text = "Курс";
            this.course.Width = 45;
            // 
            // group
            // 
            this.group.Text = "Гр.";
            this.group.Width = 50;
            // 
            // averageMark
            // 
            this.averageMark.Text = "Ср.Б.";
            // 
            // gender
            // 
            this.gender.Text = "Пол";
            this.gender.Width = 40;
            // 
            // address
            // 
            this.address.Text = "Адрес";
            this.address.Width = 190;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Search_StripMenu,
            this.сортировкаToolStripMenuItem,
            this.Save_ToolStripMenuItem,
            this.about_StripMenuItem,
            this.вклВыклИнструментыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1029, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Search_StripMenu
            // 
            this.Search_StripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FullName_ToolStripMenuItem,
            this.Specialization_ToolStripMenuItem,
            this.Course_ToolStripMenuItem,
            this.AverageMark_ToolStripMenuItem,
            this.AdvanceSearch_ToolStripMenuItem});
            this.Search_StripMenu.Name = "Search_StripMenu";
            this.Search_StripMenu.Size = new System.Drawing.Size(66, 24);
            this.Search_StripMenu.Text = "Поиск";
            // 
            // FullName_ToolStripMenuItem
            // 
            this.FullName_ToolStripMenuItem.Name = "FullName_ToolStripMenuItem";
            this.FullName_ToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.FullName_ToolStripMenuItem.Text = "ФИО";
            this.FullName_ToolStripMenuItem.Click += new System.EventHandler(this.SearchInfo);
            // 
            // Specialization_ToolStripMenuItem
            // 
            this.Specialization_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пОИТToolStripMenuItem,
            this.дЭиВИToolStripMenuItem,
            this.иСИТToolStripMenuItem,
            this.пОИБМСToolStripMenuItem});
            this.Specialization_ToolStripMenuItem.Name = "Specialization_ToolStripMenuItem";
            this.Specialization_ToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.Specialization_ToolStripMenuItem.Text = "Специальность";
            // 
            // пОИТToolStripMenuItem
            // 
            this.пОИТToolStripMenuItem.Name = "пОИТToolStripMenuItem";
            this.пОИТToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.пОИТToolStripMenuItem.Text = "ПОИТ";
            this.пОИТToolStripMenuItem.Click += new System.EventHandler(this.SearchInfo);
            // 
            // дЭиВИToolStripMenuItem
            // 
            this.дЭиВИToolStripMenuItem.Name = "дЭиВИToolStripMenuItem";
            this.дЭиВИToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.дЭиВИToolStripMenuItem.Text = "ДЭиВИ";
            this.дЭиВИToolStripMenuItem.Click += new System.EventHandler(this.SearchInfo);
            // 
            // иСИТToolStripMenuItem
            // 
            this.иСИТToolStripMenuItem.Name = "иСИТToolStripMenuItem";
            this.иСИТToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.иСИТToolStripMenuItem.Text = "ИСИТ";
            this.иСИТToolStripMenuItem.Click += new System.EventHandler(this.SearchInfo);
            // 
            // пОИБМСToolStripMenuItem
            // 
            this.пОИБМСToolStripMenuItem.Name = "пОИБМСToolStripMenuItem";
            this.пОИБМСToolStripMenuItem.Size = new System.Drawing.Size(156, 26);
            this.пОИБМСToolStripMenuItem.Text = "ПОИБМС";
            this.пОИБМСToolStripMenuItem.Click += new System.EventHandler(this.SearchInfo);
            // 
            // Course_ToolStripMenuItem
            // 
            this.Course_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.Course_ToolStripMenuItem.Name = "Course_ToolStripMenuItem";
            this.Course_ToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.Course_ToolStripMenuItem.Text = "Курс";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem2.Text = "1";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.SearchInfo);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem3.Text = "2";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.SearchInfo);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem4.Text = "3";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.SearchInfo);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem5.Text = "4";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.SearchInfo);
            // 
            // AverageMark_ToolStripMenuItem
            // 
            this.AverageMark_ToolStripMenuItem.Name = "AverageMark_ToolStripMenuItem";
            this.AverageMark_ToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.AverageMark_ToolStripMenuItem.Text = "Ср. Балл";
            this.AverageMark_ToolStripMenuItem.Click += new System.EventHandler(this.SearchInfo);
            // 
            // AdvanceSearch_ToolStripMenuItem
            // 
            this.AdvanceSearch_ToolStripMenuItem.Name = "AdvanceSearch_ToolStripMenuItem";
            this.AdvanceSearch_ToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.AdvanceSearch_ToolStripMenuItem.Text = "Настроить..";
            this.AdvanceSearch_ToolStripMenuItem.Click += new System.EventHandler(this.SearchInfo);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поФамилииToolStripMenuItem,
            this.поДатеРожденияToolStripMenuItem,
            this.поСпециальностиToolStripMenuItem,
            this.поКурсуToolStripMenuItem});
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            // 
            // поФамилииToolStripMenuItem
            // 
            this.поФамилииToolStripMenuItem.Name = "поФамилииToolStripMenuItem";
            this.поФамилииToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.поФамилииToolStripMenuItem.Text = "по ФИО";
            this.поФамилииToolStripMenuItem.Click += new System.EventHandler(this.SortSelectedList);
            // 
            // поДатеРожденияToolStripMenuItem
            // 
            this.поДатеРожденияToolStripMenuItem.Name = "поДатеРожденияToolStripMenuItem";
            this.поДатеРожденияToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.поДатеРожденияToolStripMenuItem.Text = "по дате рождения";
            this.поДатеРожденияToolStripMenuItem.Click += new System.EventHandler(this.SortSelectedList);
            // 
            // поСпециальностиToolStripMenuItem
            // 
            this.поСпециальностиToolStripMenuItem.Name = "поСпециальностиToolStripMenuItem";
            this.поСпециальностиToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.поСпециальностиToolStripMenuItem.Text = "по специальности";
            this.поСпециальностиToolStripMenuItem.Click += new System.EventHandler(this.SortSelectedList);
            // 
            // поКурсуToolStripMenuItem
            // 
            this.поКурсуToolStripMenuItem.Name = "поКурсуToolStripMenuItem";
            this.поКурсуToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.поКурсуToolStripMenuItem.Text = "по курсу";
            this.поКурсуToolStripMenuItem.Click += new System.EventHandler(this.SortSelectedList);
            // 
            // Save_ToolStripMenuItem
            // 
            this.Save_ToolStripMenuItem.Name = "Save_ToolStripMenuItem";
            this.Save_ToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.Save_ToolStripMenuItem.Text = "Сохранить";
            this.Save_ToolStripMenuItem.Click += new System.EventHandler(this.Save_ToolStripMenuItem_Click);
            // 
            // about_StripMenuItem
            // 
            this.about_StripMenuItem.Name = "about_StripMenuItem";
            this.about_StripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.about_StripMenuItem.Text = "О программе";
            this.about_StripMenuItem.Click += new System.EventHandler(this.About_StripMenuItem_Click);
            // 
            // вклВыклИнструментыToolStripMenuItem
            // 
            this.вклВыклИнструментыToolStripMenuItem.Name = "вклВыклИнструментыToolStripMenuItem";
            this.вклВыклИнструментыToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.вклВыклИнструментыToolStripMenuItem.Text = "Вкл/Выкл инструменты";
            this.вклВыклИнструментыToolStripMenuItem.Click += new System.EventHandler(this.turnOnOffTools_ToolStripMenuItem_Click);
            // 
            // tools
            // 
            this.tools.Dock = System.Windows.Forms.DockStyle.Right;
            this.tools.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.sort_tool,
            this.toolStripButton2,
            this.toolStripButton3});
            this.tools.Location = new System.Drawing.Point(994, 28);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(35, 425);
            this.tools.Stretch = true;
            this.tools.TabIndex = 3;
            this.tools.Text = "Инструменты";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem6,
            this.toolStripMenuItem11,
            this.toolStripMenuItem16,
            this.toolStripMenuItem17});
            this.toolStripButton1.Image = global::LPLab02.Properties.Resources.Search_24x24;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(32, 24);
            this.toolStripButton1.Text = "Поиск";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(199, 26);
            this.toolStripMenuItem1.Text = "ФИО";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.SearchInfo);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8,
            this.toolStripMenuItem9,
            this.toolStripMenuItem10});
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(199, 26);
            this.toolStripMenuItem6.Text = "Специальность";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.SearchInfo);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(156, 26);
            this.toolStripMenuItem7.Text = "ПОИТ";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.SearchInfo);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(156, 26);
            this.toolStripMenuItem8.Text = "ДЭиВИ";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.SearchInfo);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(156, 26);
            this.toolStripMenuItem9.Text = "ИСИТ";
            this.toolStripMenuItem9.Click += new System.EventHandler(this.SearchInfo);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(156, 26);
            this.toolStripMenuItem10.Text = "ПОИБМС";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.SearchInfo);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.toolStripMenuItem13,
            this.toolStripMenuItem14,
            this.toolStripMenuItem15});
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(199, 26);
            this.toolStripMenuItem11.Text = "Курс";
            this.toolStripMenuItem11.Click += new System.EventHandler(this.SearchInfo);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem12.Text = "1";
            this.toolStripMenuItem12.Click += new System.EventHandler(this.SearchInfo);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem13.Text = "2";
            this.toolStripMenuItem13.Click += new System.EventHandler(this.SearchInfo);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem14.Text = "3";
            this.toolStripMenuItem14.Click += new System.EventHandler(this.SearchInfo);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(100, 26);
            this.toolStripMenuItem15.Text = "4";
            this.toolStripMenuItem15.Click += new System.EventHandler(this.SearchInfo);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(199, 26);
            this.toolStripMenuItem16.Text = "Ср. Балл";
            this.toolStripMenuItem16.Click += new System.EventHandler(this.SearchInfo);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(199, 26);
            this.toolStripMenuItem17.Text = "Настроить..";
            this.toolStripMenuItem17.Click += new System.EventHandler(this.SearchInfo);
            // 
            // sort_tool
            // 
            this.sort_tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sort_tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem18,
            this.toolStripMenuItem19,
            this.toolStripMenuItem20,
            this.toolStripMenuItem21});
            this.sort_tool.Image = global::LPLab02.Properties.Resources.Refresh_24x24;
            this.sort_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.sort_tool.Name = "sort_tool";
            this.sort_tool.Size = new System.Drawing.Size(32, 24);
            this.sort_tool.Text = "Сортировка";
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(220, 26);
            this.toolStripMenuItem18.Text = "по ФИО";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.SortSelectedList);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(220, 26);
            this.toolStripMenuItem19.Text = "по дате рождения";
            this.toolStripMenuItem19.Click += new System.EventHandler(this.SortSelectedList);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(220, 26);
            this.toolStripMenuItem20.Text = "по специальности";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.SortSelectedList);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(220, 26);
            this.toolStripMenuItem21.Text = "по курсу";
            this.toolStripMenuItem21.Click += new System.EventHandler(this.SortSelectedList);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::LPLab02.Properties.Resources.Information_24x24;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(32, 24);
            this.toolStripButton2.Text = "Информация";
            this.toolStripButton2.Click += new System.EventHandler(this.About_StripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::LPLab02.Properties.Resources.Save_24x24;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(32, 24);
            this.toolStripButton3.Text = "Сохранить выборку";
            this.toolStripButton3.Click += new System.EventHandler(this.Save_ToolStripMenuItem_Click);
            // 
            // status
            // 
            this.status.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_label,
            this.time_label});
            this.status.Location = new System.Drawing.Point(0, 427);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(994, 26);
            this.status.TabIndex = 4;
            this.status.Text = "statusStrip1";
            // 
            // status_label
            // 
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(52, 20);
            this.status_label.Text = "Статус";
            // 
            // time_label
            // 
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(21, 20);
            this.time_label.Text = "   ";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // OutputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 453);
            this.Controls.Add(this.status);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.items);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1047, 500);
            this.Name = "OutputForm";
            this.Text = "Output";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView items;
        private System.Windows.Forms.ColumnHeader fullName;
        private System.Windows.Forms.ColumnHeader age;
        private System.Windows.Forms.ColumnHeader spec;
        private System.Windows.Forms.ColumnHeader birth;
        private System.Windows.Forms.ColumnHeader course;
        private System.Windows.Forms.ColumnHeader gender;
        private System.Windows.Forms.ColumnHeader group;
        private System.Windows.Forms.ColumnHeader averageMark;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Search_StripMenu;
        private System.Windows.Forms.ToolStripMenuItem FullName_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Specialization_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пОИТToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дЭиВИToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иСИТToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пОИБМСToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Course_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem AverageMark_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поФамилииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поДатеРожденияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поСпециальностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поКурсуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Save_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem about_StripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdvanceSearch_ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripDropDownButton toolStripButton1;
        private System.Windows.Forms.ToolStripDropDownButton sort_tool;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem16;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem17;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem18;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem19;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem20;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem вклВыклИнструментыToolStripMenuItem;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel status_label;
        private System.Windows.Forms.ToolStripStatusLabel time_label;
        private System.Windows.Forms.Timer timer;
    }
}