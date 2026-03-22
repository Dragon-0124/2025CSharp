namespace PanelEx251118
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelFirst = new Panel();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            button1 = new Button();
            label1 = new Label();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            label2 = new Label();
            panelFirst.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panelFirst
            // 
            panelFirst.Controls.Add(checkBox4);
            panelFirst.Controls.Add(checkBox3);
            panelFirst.Controls.Add(label2);
            panelFirst.Controls.Add(label1);
            panelFirst.Controls.Add(button1);
            panelFirst.Controls.Add(groupBox1);
            panelFirst.Location = new Point(2, 0);
            panelFirst.Name = "panelFirst";
            panelFirst.Size = new Size(1075, 677);
            panelFirst.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(61, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(319, 485);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(108, 343);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(93, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "OKNoCancle";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(108, 92);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(41, 19);
            radioButton2.TabIndex = 0;
            radioButton2.TabStop = true;
            radioButton2.Text = "OK";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(108, 219);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(77, 19);
            radioButton3.TabIndex = 0;
            radioButton3.TabStop = true;
            radioButton3.Text = "OKCancle";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(639, 145);
            button1.Name = "button1";
            button1.Size = new Size(209, 84);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(639, 251);
            label1.Name = "label1";
            label1.Size = new Size(209, 29);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(639, 304);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(50, 19);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "남성";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(764, 304);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(50, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "여성";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Location = new Point(639, 355);
            label2.Name = "label2";
            label2.Size = new Size(209, 216);
            label2.TabIndex = 2;
            label2.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 677);
            Controls.Add(panelFirst);
            Name = "Form1";
            Text = "Form1";
            panelFirst.ResumeLayout(false);
            panelFirst.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelFirst;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}
