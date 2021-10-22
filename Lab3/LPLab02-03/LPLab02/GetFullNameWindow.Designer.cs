
namespace LPLab02
{
    partial class GetFullNameWindow
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
            this.textBox_fullname = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.button_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_fullname
            // 
            this.textBox_fullname.Location = new System.Drawing.Point(12, 44);
            this.textBox_fullname.MaxLength = 128;
            this.textBox_fullname.Name = "textBox_fullname";
            this.textBox_fullname.Size = new System.Drawing.Size(218, 22);
            this.textBox_fullname.TabIndex = 0;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(99, 9);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(117, 17);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Введите данные";
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(236, 43);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(70, 23);
            this.button_ok.TabIndex = 2;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // GetFullNameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 79);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.textBox_fullname);
            this.MaximumSize = new System.Drawing.Size(336, 126);
            this.MinimumSize = new System.Drawing.Size(336, 126);
            this.Name = "GetFullNameWindow";
            this.Text = "GetFullNameWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_fullname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Button button_ok;
    }
}