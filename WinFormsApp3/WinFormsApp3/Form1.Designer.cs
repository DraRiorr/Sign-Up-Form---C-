namespace WinFormsApp3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lbl_Name = new Label();
            lbl_LastName = new Label();
            lbl_FatherName = new Label();
            Lbl_Code = new Label();
            btn = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(181, 23);
            textBox1.TabIndex = 0;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 168);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(181, 23);
            textBox2.TabIndex = 1;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(87, 214);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(181, 23);
            textBox3.TabIndex = 2;
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(87, 261);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(181, 23);
            textBox4.TabIndex = 3;
            textBox4.Enter += textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(283, 120);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(39, 15);
            lbl_Name.TabIndex = 4;
            lbl_Name.Text = "Name";
            lbl_Name.Click += label1_Click;
            // 
            // lbl_LastName
            // 
            lbl_LastName.AutoSize = true;
            lbl_LastName.Location = new Point(283, 171);
            lbl_LastName.Name = "lbl_LastName";
            lbl_LastName.Size = new Size(60, 15);
            lbl_LastName.TabIndex = 5;
            lbl_LastName.Text = "LastName";
            // 
            // lbl_FatherName
            // 
            lbl_FatherName.AutoSize = true;
            lbl_FatherName.Location = new Point(283, 217);
            lbl_FatherName.Name = "lbl_FatherName";
            lbl_FatherName.Size = new Size(72, 15);
            lbl_FatherName.TabIndex = 6;
            lbl_FatherName.Text = "FatherName";
            // 
            // Lbl_Code
            // 
            Lbl_Code.AutoSize = true;
            Lbl_Code.Location = new Point(283, 269);
            Lbl_Code.Name = "Lbl_Code";
            Lbl_Code.Size = new Size(35, 15);
            Lbl_Code.TabIndex = 7;
            Lbl_Code.Text = "Code";
            // 
            // btn
            // 
            btn.Location = new Point(138, 352);
            btn.Name = "btn";
            btn.Size = new Size(102, 41);
            btn.TabIndex = 8;
            btn.Text = "Signup";
            btn.UseVisualStyleBackColor = true;
            btn.Click += btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(391, 442);
            Controls.Add(btn);
            Controls.Add(Lbl_Code);
            Controls.Add(lbl_FatherName);
            Controls.Add(lbl_LastName);
            Controls.Add(lbl_Name);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lbl_Name;
        private Label lbl_LastName;
        private Label lbl_FatherName;
        private Label Lbl_Code;
        private Button btn;
    }
}
