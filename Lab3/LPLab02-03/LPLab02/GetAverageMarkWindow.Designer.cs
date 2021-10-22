
namespace LPLab02
{
    partial class GetAverageMarkWindow
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
            this.maskedTextBox_averageMark = new System.Windows.Forms.MaskedTextBox();
            this.button_ok = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTextBox_averageMark
            // 
            this.maskedTextBox_averageMark.Location = new System.Drawing.Point(82, 53);
            this.maskedTextBox_averageMark.Mask = "9.99";
            this.maskedTextBox_averageMark.Name = "maskedTextBox_averageMark";
            this.maskedTextBox_averageMark.Size = new System.Drawing.Size(33, 22);
            this.maskedTextBox_averageMark.TabIndex = 19;
            this.maskedTextBox_averageMark.Tag = false;
            // 
            // button_ok
            // 
            this.button_ok.Location = new System.Drawing.Point(152, 52);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(70, 23);
            this.button_ok.TabIndex = 21;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(88, 19);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(117, 17);
            this.label_name.TabIndex = 20;
            this.label_name.Text = "Введите данные";
            // 
            // GetAverageMarkWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 93);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.maskedTextBox_averageMark);
            this.MaximumSize = new System.Drawing.Size(312, 140);
            this.MinimumSize = new System.Drawing.Size(312, 140);
            this.Name = "GetAverageMarkWindow";
            this.Text = "GetAverageMarkWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox_averageMark;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Label label_name;
    }
}