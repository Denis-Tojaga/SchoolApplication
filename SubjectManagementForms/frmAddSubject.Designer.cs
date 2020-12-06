namespace SchoolApp.SubjectManagementForms
{
    partial class frmAddSubject
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtAction = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProfessor = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtECTS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubjectCode = new System.Windows.Forms.TextBox();
            this.pbSyllabusPic = new System.Windows.Forms.PictureBox();
            this.btnImportSyllabus = new System.Windows.Forms.Button();
            this.ofdOdabirSlike = new System.Windows.Forms.OpenFileDialog();
            this.btnClose = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbYearOfStudy = new System.Windows.Forms.ComboBox();
            this.cmbLessonHours = new System.Windows.Forms.ComboBox();
            this.cmbPracticeHours = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSyllabusPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.cmbPracticeHours);
            this.panel1.Controls.Add(this.cmbLessonHours);
            this.panel1.Controls.Add(this.cmbYearOfStudy);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAddSubject);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.txtAction);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtProfessor);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtECTS);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtSubjectName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSubjectCode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(329, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 462);
            this.panel1.TabIndex = 5;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnAddSubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSubject.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnAddSubject.Location = new System.Drawing.Point(170, 376);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(221, 39);
            this.btnAddSubject.TabIndex = 8;
            this.btnAddSubject.Text = "Add subject";
            this.btnAddSubject.UseVisualStyleBackColor = false;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(343, 319);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(170, 1);
            this.label18.TabIndex = 34;
            this.label18.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label19.Location = new System.Drawing.Point(338, 275);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 18);
            this.label19.TabIndex = 33;
            this.label19.Text = "Exam action";
            // 
            // txtAction
            // 
            this.txtAction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtAction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAction.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAction.ForeColor = System.Drawing.Color.White;
            this.txtAction.Location = new System.Drawing.Point(342, 296);
            this.txtAction.Name = "txtAction";
            this.txtAction.Size = new System.Drawing.Size(171, 19);
            this.txtAction.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(343, 248);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(170, 1);
            this.label20.TabIndex = 31;
            this.label20.Text = "label20";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label21.Location = new System.Drawing.Point(339, 206);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(116, 18);
            this.label21.TabIndex = 30;
            this.label21.Text = "Pratice hours";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(61, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(170, 1);
            this.label10.TabIndex = 22;
            this.label10.Text = "label10";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label11.Location = new System.Drawing.Point(56, 277);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 18);
            this.label11.TabIndex = 21;
            this.label11.Text = "Professor";
            // 
            // txtProfessor
            // 
            this.txtProfessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtProfessor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProfessor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfessor.ForeColor = System.Drawing.Color.White;
            this.txtProfessor.Location = new System.Drawing.Point(60, 297);
            this.txtProfessor.Name = "txtProfessor";
            this.txtProfessor.Size = new System.Drawing.Size(171, 19);
            this.txtProfessor.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(61, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 1);
            this.label12.TabIndex = 19;
            this.label12.Text = "label12";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label13.Location = new System.Drawing.Point(57, 207);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 18);
            this.label13.TabIndex = 18;
            this.label13.Text = "Lesson hours";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(344, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 1);
            this.label6.TabIndex = 16;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label7.Location = new System.Drawing.Point(339, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "ECTS";
            // 
            // txtECTS
            // 
            this.txtECTS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtECTS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtECTS.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtECTS.ForeColor = System.Drawing.Color.White;
            this.txtECTS.Location = new System.Drawing.Point(343, 149);
            this.txtECTS.Name = "txtECTS";
            this.txtECTS.Size = new System.Drawing.Size(171, 19);
            this.txtECTS.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(344, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 1);
            this.label8.TabIndex = 13;
            this.label8.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label9.Location = new System.Drawing.Point(339, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 12;
            this.label9.Text = "Subject name";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtSubjectName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubjectName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectName.ForeColor = System.Drawing.Color.White;
            this.txtSubjectName.Location = new System.Drawing.Point(343, 82);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(171, 19);
            this.txtSubjectName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 1);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label5.Location = new System.Drawing.Point(56, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Year of Study";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 1);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.label2.Location = new System.Drawing.Point(57, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Subject code";
            // 
            // txtSubjectCode
            // 
            this.txtSubjectCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.txtSubjectCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubjectCode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubjectCode.ForeColor = System.Drawing.Color.White;
            this.txtSubjectCode.Location = new System.Drawing.Point(60, 81);
            this.txtSubjectCode.Name = "txtSubjectCode";
            this.txtSubjectCode.ReadOnly = true;
            this.txtSubjectCode.Size = new System.Drawing.Size(171, 19);
            this.txtSubjectCode.TabIndex = 0;
            // 
            // pbSyllabusPic
            // 
            this.pbSyllabusPic.BackColor = System.Drawing.Color.LightGray;
            this.pbSyllabusPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSyllabusPic.Location = new System.Drawing.Point(33, 16);
            this.pbSyllabusPic.Name = "pbSyllabusPic";
            this.pbSyllabusPic.Size = new System.Drawing.Size(263, 309);
            this.pbSyllabusPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSyllabusPic.TabIndex = 6;
            this.pbSyllabusPic.TabStop = false;
            // 
            // btnImportSyllabus
            // 
            this.btnImportSyllabus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.btnImportSyllabus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportSyllabus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportSyllabus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnImportSyllabus.Location = new System.Drawing.Point(53, 337);
            this.btnImportSyllabus.Name = "btnImportSyllabus";
            this.btnImportSyllabus.Size = new System.Drawing.Size(221, 34);
            this.btnImportSyllabus.TabIndex = 0;
            this.btnImportSyllabus.Text = "Import Syllabus";
            this.btnImportSyllabus.UseVisualStyleBackColor = false;
            this.btnImportSyllabus.Click += new System.EventHandler(this.btnImportSyllabus_Click);
            // 
            // ofdOdabirSlike
            // 
            this.ofdOdabirSlike.FileName = "openFileDialog1";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(523, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 32);
            this.btnClose.TabIndex = 35;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // err
            // 
            this.err.BlinkRate = 150;
            this.err.ContainerControl = this;
            // 
            // cmbYearOfStudy
            // 
            this.cmbYearOfStudy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.cmbYearOfStudy.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYearOfStudy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.cmbYearOfStudy.FormattingEnabled = true;
            this.cmbYearOfStudy.Items.AddRange(new object[] {
            "Prva godina",
            "Druga godina",
            "Treca godina",
            "Cetvrta godina",
            "Master"});
            this.cmbYearOfStudy.Location = new System.Drawing.Point(60, 151);
            this.cmbYearOfStudy.Name = "cmbYearOfStudy";
            this.cmbYearOfStudy.Size = new System.Drawing.Size(189, 24);
            this.cmbYearOfStudy.TabIndex = 36;
            // 
            // cmbLessonHours
            // 
            this.cmbLessonHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.cmbLessonHours.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLessonHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.cmbLessonHours.FormattingEnabled = true;
            this.cmbLessonHours.Items.AddRange(new object[] {
            "20",
            "30",
            "40",
            "50"});
            this.cmbLessonHours.Location = new System.Drawing.Point(59, 226);
            this.cmbLessonHours.Name = "cmbLessonHours";
            this.cmbLessonHours.Size = new System.Drawing.Size(189, 24);
            this.cmbLessonHours.TabIndex = 37;
            // 
            // cmbPracticeHours
            // 
            this.cmbPracticeHours.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.cmbPracticeHours.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPracticeHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.cmbPracticeHours.FormattingEnabled = true;
            this.cmbPracticeHours.Items.AddRange(new object[] {
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.cmbPracticeHours.Location = new System.Drawing.Point(341, 225);
            this.cmbPracticeHours.Name = "cmbPracticeHours";
            this.cmbPracticeHours.Size = new System.Drawing.Size(189, 24);
            this.cmbPracticeHours.TabIndex = 38;
            // 
            // frmAddSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(895, 462);
            this.Controls.Add(this.btnImportSyllabus);
            this.Controls.Add(this.pbSyllabusPic);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddSubject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Subject";
            this.Load += new System.EventHandler(this.frmAddSubject_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSyllabusPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtAction;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProfessor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtECTS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubjectCode;
        private System.Windows.Forms.PictureBox pbSyllabusPic;
        private System.Windows.Forms.Button btnImportSyllabus;
        private System.Windows.Forms.OpenFileDialog ofdOdabirSlike;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.ComboBox cmbPracticeHours;
        private System.Windows.Forms.ComboBox cmbLessonHours;
        private System.Windows.Forms.ComboBox cmbYearOfStudy;
    }
}