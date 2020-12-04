namespace SchoolApp.ChildForms
{
    partial class frmStudents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudents));
            this.lbViewOf = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.Numberofindex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fathername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.pbCurrentUser = new System.Windows.Forms.PictureBox();
            this.btnCheckDetails = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.rbPoIndeksu = new System.Windows.Forms.RadioButton();
            this.rbPoImenu = new System.Windows.Forms.RadioButton();
            this.rbPoGodiniStudija = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancelSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lbViewOf
            // 
            this.lbViewOf.BackColor = System.Drawing.Color.White;
            this.lbViewOf.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViewOf.ForeColor = System.Drawing.Color.Black;
            this.lbViewOf.Location = new System.Drawing.Point(755, 9);
            this.lbViewOf.Name = "lbViewOf";
            this.lbViewOf.Size = new System.Drawing.Size(125, 24);
            this.lbViewOf.TabIndex = 2;
            this.lbViewOf.Text = "View of:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Add Student";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Check Details";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(140)))), ((int)(((byte)(219)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(0, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(937, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Student List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvStudents
            // 
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvStudents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(140)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(140)))), ((int)(((byte)(219)))));
            this.dgvStudents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudents.ColumnHeadersHeight = 45;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numberofindex,
            this.Firstname,
            this.Lastname,
            this.Fathername,
            this.Gender,
            this.Age,
            this.Dateofbirth});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudents.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudents.GridColor = System.Drawing.Color.White;
            this.dgvStudents.Location = new System.Drawing.Point(12, 327);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(140)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStudents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(911, 246);
            this.dgvStudents.TabIndex = 8;
            // 
            // Numberofindex
            // 
            this.Numberofindex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Numberofindex.DataPropertyName = "BrojIndeksa";
            this.Numberofindex.HeaderText = "Index Code";
            this.Numberofindex.Name = "Numberofindex";
            this.Numberofindex.ReadOnly = true;
            // 
            // Firstname
            // 
            this.Firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Firstname.DataPropertyName = "Ime";
            this.Firstname.HeaderText = "First Name";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Lastname
            // 
            this.Lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lastname.DataPropertyName = "Prezime";
            this.Lastname.HeaderText = "Last Name";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            // 
            // Fathername
            // 
            this.Fathername.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fathername.DataPropertyName = "ImeOca";
            this.Fathername.HeaderText = "Father Name";
            this.Fathername.Name = "Fathername";
            this.Fathername.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Gender.DataPropertyName = "Spol";
            this.Gender.HeaderText = "Gender";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Age
            // 
            this.Age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Age.DataPropertyName = "Godine";
            this.Age.HeaderText = "Age";
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            // 
            // Dateofbirth
            // 
            this.Dateofbirth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dateofbirth.DataPropertyName = "DatumRodjenja";
            this.Dateofbirth.HeaderText = "Date of Birth";
            this.Dateofbirth.Name = "Dateofbirth";
            this.Dateofbirth.ReadOnly = true;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Comic Sans MS", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(143, 398);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(715, 48);
            this.lblMessage.TabIndex = 9;
            this.lblMessage.Text = "No students available yet,please add one!";
            // 
            // txtFilter
            // 
            this.txtFilter.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilter.Location = new System.Drawing.Point(490, 293);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(326, 28);
            this.txtFilter.TabIndex = 11;
            this.txtFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFilter_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::SchoolApp.Properties.Resources.lupa3;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::SchoolApp.Properties.Resources.lupa3;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.Location = new System.Drawing.Point(822, 293);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 28);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pbCurrentUser
            // 
            this.pbCurrentUser.Image = global::SchoolApp.Properties.Resources.SLIKA;
            this.pbCurrentUser.Location = new System.Drawing.Point(886, 9);
            this.pbCurrentUser.Name = "pbCurrentUser";
            this.pbCurrentUser.Size = new System.Drawing.Size(28, 24);
            this.pbCurrentUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrentUser.TabIndex = 10;
            this.pbCurrentUser.TabStop = false;
            // 
            // btnCheckDetails
            // 
            this.btnCheckDetails.BackColor = System.Drawing.Color.White;
            this.btnCheckDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckDetails.BackgroundImage")));
            this.btnCheckDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCheckDetails.FlatAppearance.BorderSize = 2;
            this.btnCheckDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckDetails.Location = new System.Drawing.Point(469, 52);
            this.btnCheckDetails.Name = "btnCheckDetails";
            this.btnCheckDetails.Padding = new System.Windows.Forms.Padding(10);
            this.btnCheckDetails.Size = new System.Drawing.Size(160, 110);
            this.btnCheckDetails.TabIndex = 4;
            this.btnCheckDetails.UseVisualStyleBackColor = false;
            this.btnCheckDetails.Click += new System.EventHandler(this.btnCheckDetails_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(140)))), ((int)(((byte)(219)))));
            this.btnAddStudent.BackgroundImage = global::SchoolApp.Properties.Resources.student2;
            this.btnAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddStudent.FlatAppearance.BorderSize = 2;
            this.btnAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStudent.Location = new System.Drawing.Point(297, 52);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(154, 110);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // rbPoIndeksu
            // 
            this.rbPoIndeksu.AutoSize = true;
            this.rbPoIndeksu.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPoIndeksu.Location = new System.Drawing.Point(185, 296);
            this.rbPoIndeksu.Name = "rbPoIndeksu";
            this.rbPoIndeksu.Size = new System.Drawing.Size(91, 20);
            this.rbPoIndeksu.TabIndex = 13;
            this.rbPoIndeksu.TabStop = true;
            this.rbPoIndeksu.Text = "Index code";
            this.rbPoIndeksu.UseVisualStyleBackColor = true;
            this.rbPoIndeksu.CheckedChanged += new System.EventHandler(this.rbPoIndeksu_CheckedChanged);
            // 
            // rbPoImenu
            // 
            this.rbPoImenu.AutoSize = true;
            this.rbPoImenu.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPoImenu.Location = new System.Drawing.Point(283, 297);
            this.rbPoImenu.Name = "rbPoImenu";
            this.rbPoImenu.Size = new System.Drawing.Size(88, 20);
            this.rbPoImenu.TabIndex = 14;
            this.rbPoImenu.TabStop = true;
            this.rbPoImenu.Text = "First name";
            this.rbPoImenu.UseVisualStyleBackColor = true;
            this.rbPoImenu.CheckedChanged += new System.EventHandler(this.rbPoImenu_CheckedChanged);
            // 
            // rbPoGodiniStudija
            // 
            this.rbPoGodiniStudija.AutoSize = true;
            this.rbPoGodiniStudija.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPoGodiniStudija.Location = new System.Drawing.Point(375, 298);
            this.rbPoGodiniStudija.Name = "rbPoGodiniStudija";
            this.rbPoGodiniStudija.Size = new System.Drawing.Size(108, 20);
            this.rbPoGodiniStudija.TabIndex = 15;
            this.rbPoGodiniStudija.TabStop = true;
            this.rbPoGodiniStudija.Text = "Year of study";
            this.rbPoGodiniStudija.UseVisualStyleBackColor = true;
            this.rbPoGodiniStudija.CheckedChanged += new System.EventHandler(this.rbPoGodiniStudija_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Search by:";
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.BackColor = System.Drawing.Color.Red;
            this.btnCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSearch.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSearch.Location = new System.Drawing.Point(871, 295);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new System.Drawing.Size(54, 23);
            this.btnCancelSearch.TabIndex = 17;
            this.btnCancelSearch.Text = "Cancel";
            this.btnCancelSearch.UseVisualStyleBackColor = false;
            this.btnCancelSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // frmStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(937, 585);
            this.Controls.Add(this.btnCancelSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbPoGodiniStudija);
            this.Controls.Add(this.rbPoImenu);
            this.Controls.Add(this.rbPoIndeksu);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.pbCurrentUser);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCheckDetails);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.lbViewOf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStudents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.Load += new System.EventHandler(this.frmStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbViewOf;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnCheckDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numberofindex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fathername;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dateofbirth;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pbCurrentUser;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rbPoIndeksu;
        private System.Windows.Forms.RadioButton rbPoImenu;
        private System.Windows.Forms.RadioButton rbPoGodiniStudija;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancelSearch;
    }
}