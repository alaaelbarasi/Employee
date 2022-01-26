namespace emploee
{
    partial class Emploee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.no = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.ComboBox();
            this.job = new System.Windows.Forms.ComboBox();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.countTitle = new System.Windows.Forms.Label();
            this.totalTitle = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateToday = new System.Windows.Forms.Label();
            this.now = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(898, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الموظف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(753, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم الموظف";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "الدرجة الوظيفية";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(439, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "الراتب الاساسي";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "تاريخ الميلاد";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "الوظيفة";
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(862, 83);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(120, 22);
            this.no.TabIndex = 6;
            this.no.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.no_KeyPress);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(717, 83);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(120, 22);
            this.name.TabIndex = 7;
            this.name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.name_KeyPress);
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(407, 81);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(120, 22);
            this.salary.TabIndex = 8;
            this.salary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.salary_KeyPress);
            // 
            // grade
            // 
            this.grade.FormattingEnabled = true;
            this.grade.Items.AddRange(new object[] {
            "أولى ",
            "ثانية",
            "ثالثة"});
            this.grade.Location = new System.Drawing.Point(570, 79);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(121, 24);
            this.grade.TabIndex = 9;
            this.grade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.grade_KeyPress);
            // 
            // job
            // 
            this.job.FormattingEnabled = true;
            this.job.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.job.Items.AddRange(new object[] {
            "محاضر",
            "مساعد محاضر "});
            this.job.Location = new System.Drawing.Point(64, 81);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(121, 24);
            this.job.TabIndex = 11;
            this.job.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.job_KeyPress);
            // 
            // birthDate
            // 
            this.birthDate.AllowDrop = true;
            this.birthDate.Location = new System.Drawing.Point(235, 81);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(139, 22);
            this.birthDate.TabIndex = 12;
            this.birthDate.Value = new System.DateTime(2022, 1, 26, 0, 0, 0, 0);
            this.birthDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.birthDate_KeyPress);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(862, 152);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 388);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(717, 152);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 388);
            this.listBox2.TabIndex = 14;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(570, 152);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 388);
            this.listBox3.TabIndex = 15;
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(407, 152);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(120, 388);
            this.listBox4.TabIndex = 16;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(235, 152);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(139, 388);
            this.listBox5.TabIndex = 17;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 16;
            this.listBox6.Location = new System.Drawing.Point(64, 152);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(121, 388);
            this.listBox6.TabIndex = 18;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(862, 568);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(114, 36);
            this.add.TabIndex = 19;
            this.add.Text = "إضافة موظف";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(717, 568);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(120, 36);
            this.delete.TabIndex = 20;
            this.delete.Text = "حذف موظف";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(570, 568);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(121, 36);
            this.count.TabIndex = 21;
            this.count.Text = "عدد الموظفين";
            this.count.UseVisualStyleBackColor = true;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(73, 568);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 22;
            this.button4.Text = "خروج";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // countTitle
            // 
            this.countTitle.AutoSize = true;
            this.countTitle.Location = new System.Drawing.Point(603, 607);
            this.countTitle.Name = "countTitle";
            this.countTitle.Size = new System.Drawing.Size(45, 17);
            this.countTitle.TabIndex = 23;
            this.countTitle.Text = "Count";
            // 
            // totalTitle
            // 
            this.totalTitle.AutoSize = true;
            this.totalTitle.Location = new System.Drawing.Point(449, 607);
            this.totalTitle.Name = "totalTitle";
            this.totalTitle.Size = new System.Drawing.Size(40, 17);
            this.totalTitle.TabIndex = 24;
            this.totalTitle.Text = "Total";
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(407, 568);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(121, 36);
            this.total.TabIndex = 25;
            this.total.Text = "مجموع المرتبات";
            this.total.UseVisualStyleBackColor = true;
            this.total.Click += new System.EventHandler(this.total_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(232, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Date:";
            // 
            // dateToday
            // 
            this.dateToday.AutoSize = true;
            this.dateToday.Location = new System.Drawing.Point(109, 9);
            this.dateToday.Name = "dateToday";
            this.dateToday.Size = new System.Drawing.Size(76, 17);
            this.dateToday.TabIndex = 28;
            this.dateToday.Text = "dateToday";
            // 
            // now
            // 
            this.now.AutoSize = true;
            this.now.Location = new System.Drawing.Point(286, 9);
            this.now.Name = "now";
            this.now.Size = new System.Drawing.Size(33, 17);
            this.now.TabIndex = 29;
            this.now.Text = "now";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Emploee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1030, 646);
            this.Controls.Add(this.now);
            this.Controls.Add(this.dateToday);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.total);
            this.Controls.Add(this.totalTitle);
            this.Controls.Add(this.countTitle);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.count);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.job);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.name);
            this.Controls.Add(this.no);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Emploee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.TransparencyKey = System.Drawing.SystemColors.ButtonFace;
            this.Load += new System.EventHandler(this.Emploee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox no;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.ComboBox job;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.ListBox listBox6;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label countTitle;
        private System.Windows.Forms.Label totalTitle;
        private System.Windows.Forms.Button total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label dateToday;
        private System.Windows.Forms.Label now;
        private System.Windows.Forms.Timer timer1;
    }
}

