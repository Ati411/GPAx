namespace GPAx
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
            btnAdd = new Button();
            tbInputGPA = new TextBox();
            tbGPAx = new TextBox();
            label1 = new Label();
            label2 = new Label();
            tbMinGPA = new TextBox();
            tbMaxGPA = new TextBox();
            tbStudentCount = new TextBox();
            btnClear = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(338, 44);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 91);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add Data";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbInputGPA
            // 
            tbInputGPA.Location = new Point(203, 41);
            tbInputGPA.Name = "tbInputGPA";
            tbInputGPA.Size = new Size(100, 23);
            tbInputGPA.TabIndex = 1;
            // 
            // tbGPAx
            // 
            tbGPAx.Location = new Point(203, 82);
            tbGPAx.Name = "tbGPAx";
            tbGPAx.Size = new Size(100, 23);
            tbGPAx.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(125, 44);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 3;
            label1.Text = "คะแนน GPA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 85);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 4;
            label2.Text = "GPAx";
            // 
            // tbMinGPA
            // 
            tbMinGPA.Location = new Point(203, 161);
            tbMinGPA.Name = "tbMinGPA";
            tbMinGPA.Size = new Size(100, 23);
            tbMinGPA.TabIndex = 5;
            // 
            // tbMaxGPA
            // 
            tbMaxGPA.Location = new Point(203, 122);
            tbMaxGPA.Name = "tbMaxGPA";
            tbMaxGPA.Size = new Size(100, 23);
            tbMaxGPA.TabIndex = 6;
            // 
            // tbStudentCount
            // 
            tbStudentCount.Location = new Point(203, 200);
            tbStudentCount.Name = "tbStudentCount";
            tbStudentCount.Size = new Size(100, 23);
            tbStudentCount.TabIndex = 7;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(338, 160);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 58);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 125);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 9;
            label3.Text = "Max";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 164);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 10;
            label4.Text = "Min";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 203);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 11;
            label5.Text = "Student";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(558, 278);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnClear);
            Controls.Add(tbStudentCount);
            Controls.Add(tbMaxGPA);
            Controls.Add(tbMinGPA);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbGPAx);
            Controls.Add(tbInputGPA);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private TextBox tbInputGPA;
        private TextBox tbGPAx;
        private Label label1;
        private Label label2;
        private TextBox tbMinGPA;
        private TextBox tbMaxGPA;
        private TextBox tbStudentCount;
        private Button btnClear;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
