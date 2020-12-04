namespace SchoolApp.StudentManagementForms
{
    partial class frmAddStudent
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
            this.txtBrojIndeksa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImeOca = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pbSlikaStudenta = new System.Windows.Forms.PictureBox();
            this.btnOdaberiSliku = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.btnSaveStudent = new System.Windows.Forms.Button();
            this.cmbGodinaStudija = new System.Windows.Forms.ComboBox();
            this.cmbGodine = new System.Windows.Forms.ComboBox();
            this.ofdOdabirSlike = new System.Windows.Forms.OpenFileDialog();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtmDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaStudenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(97, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj indeksa:";
            // 
            // txtBrojIndeksa
            // 
            this.txtBrojIndeksa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.txtBrojIndeksa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrojIndeksa.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrojIndeksa.Location = new System.Drawing.Point(219, 45);
            this.txtBrojIndeksa.Name = "txtBrojIndeksa";
            this.txtBrojIndeksa.ReadOnly = true;
            this.txtBrojIndeksa.Size = new System.Drawing.Size(161, 21);
            this.txtBrojIndeksa.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(219, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 2);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(219, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 2);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIme.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.Location = new System.Drawing.Point(219, 82);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(161, 21);
            this.txtIme.TabIndex = 0;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(161, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ime:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(219, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 2);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(71, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Datum Rodjenja:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(219, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 2);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // txtPrezime
            // 
            this.txtPrezime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.txtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrezime.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrezime.Location = new System.Drawing.Point(219, 119);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(161, 21);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(135, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "Prezime:";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(219, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 2);
            this.label9.TabIndex = 14;
            this.label9.Text = "label9";
            // 
            // txtImeOca
            // 
            this.txtImeOca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.txtImeOca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtImeOca.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImeOca.Location = new System.Drawing.Point(219, 193);
            this.txtImeOca.Name = "txtImeOca";
            this.txtImeOca.Size = new System.Drawing.Size(161, 21);
            this.txtImeOca.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(133, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ime oca:";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(219, 253);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 2);
            this.label11.TabIndex = 17;
            this.label11.Text = "label11";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(219, 231);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(161, 21);
            this.txtEmail.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(156, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 23);
            this.label12.TabIndex = 15;
            this.label12.Text = "Email:";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(218, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 2);
            this.label13.TabIndex = 20;
            this.label13.Text = "label13";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(145, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 23);
            this.label14.TabIndex = 18;
            this.label14.Text = "Godine:";
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(219, 331);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(161, 2);
            this.label15.TabIndex = 23;
            this.label15.Text = "label15";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(84, 310);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 23);
            this.label16.TabIndex = 21;
            this.label16.Text = "Godina Studija:";
            // 
            // pbSlikaStudenta
            // 
            this.pbSlikaStudenta.BackColor = System.Drawing.Color.Transparent;
            this.pbSlikaStudenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSlikaStudenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSlikaStudenta.Location = new System.Drawing.Point(506, 65);
            this.pbSlikaStudenta.Name = "pbSlikaStudenta";
            this.pbSlikaStudenta.Size = new System.Drawing.Size(229, 210);
            this.pbSlikaStudenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlikaStudenta.TabIndex = 24;
            this.pbSlikaStudenta.TabStop = false;
            // 
            // btnOdaberiSliku
            // 
            this.btnOdaberiSliku.BackColor = System.Drawing.Color.Black;
            this.btnOdaberiSliku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdaberiSliku.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdaberiSliku.ForeColor = System.Drawing.Color.White;
            this.btnOdaberiSliku.Location = new System.Drawing.Point(506, 281);
            this.btnOdaberiSliku.Name = "btnOdaberiSliku";
            this.btnOdaberiSliku.Size = new System.Drawing.Size(228, 34);
            this.btnOdaberiSliku.TabIndex = 8;
            this.btnOdaberiSliku.Text = "Choose photo";
            this.btnOdaberiSliku.UseVisualStyleBackColor = false;
            this.btnOdaberiSliku.Click += new System.EventHandler(this.btnOdaberiSliku_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(161, 351);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 23);
            this.label18.TabIndex = 26;
            this.label18.Text = "Spol:";
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.BackColor = System.Drawing.Color.Transparent;
            this.rbMale.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMale.Location = new System.Drawing.Point(217, 351);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(65, 23);
            this.rbMale.TabIndex = 6;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Musko";
            this.rbMale.UseVisualStyleBackColor = false;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.BackColor = System.Drawing.Color.Transparent;
            this.rbFemale.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemale.Location = new System.Drawing.Point(280, 351);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(70, 23);
            this.rbFemale.TabIndex = 7;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Zensko";
            this.rbFemale.UseVisualStyleBackColor = false;
            // 
            // btnSaveStudent
            // 
            this.btnSaveStudent.BackColor = System.Drawing.Color.Black;
            this.btnSaveStudent.FlatAppearance.BorderSize = 2;
            this.btnSaveStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveStudent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStudent.ForeColor = System.Drawing.Color.White;
            this.btnSaveStudent.Location = new System.Drawing.Point(101, 415);
            this.btnSaveStudent.Name = "btnSaveStudent";
            this.btnSaveStudent.Size = new System.Drawing.Size(305, 34);
            this.btnSaveStudent.TabIndex = 9;
            this.btnSaveStudent.Text = "Save student";
            this.btnSaveStudent.UseVisualStyleBackColor = false;
            this.btnSaveStudent.Click += new System.EventHandler(this.btnSaveStudent_Click);
            // 
            // cmbGodinaStudija
            // 
            this.cmbGodinaStudija.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.cmbGodinaStudija.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGodinaStudija.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGodinaStudija.FormattingEnabled = true;
            this.cmbGodinaStudija.Location = new System.Drawing.Point(219, 307);
            this.cmbGodinaStudija.Name = "cmbGodinaStudija";
            this.cmbGodinaStudija.Size = new System.Drawing.Size(176, 24);
            this.cmbGodinaStudija.TabIndex = 5;
            // 
            // cmbGodine
            // 
            this.cmbGodine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.cmbGodine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGodine.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGodine.FormattingEnabled = true;
            this.cmbGodine.Items.AddRange(new object[] {
            "Prva godina",
            "Druga godina",
            "Treca godina",
            "Cetvrta godina",
            "Master"});
            this.cmbGodine.Location = new System.Drawing.Point(218, 267);
            this.cmbGodine.Name = "cmbGodine";
            this.cmbGodine.Size = new System.Drawing.Size(57, 24);
            this.cmbGodine.TabIndex = 4;
            // 
            // ofdOdabirSlike
            // 
            this.ofdOdabirSlike.FileName = "openFileDialog1";
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // dtmDatumRodjenja
            // 
            this.dtmDatumRodjenja.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDatumRodjenja.Location = new System.Drawing.Point(218, 158);
            this.dtmDatumRodjenja.Name = "dtmDatumRodjenja";
            this.dtmDatumRodjenja.Size = new System.Drawing.Size(162, 24);
            this.dtmDatumRodjenja.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(699, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 27;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(232)))), ((int)(((byte)(229)))));
            this.BackgroundImage = global::SchoolApp.Properties.Resources.Screenshot__169_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(746, 491);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtmDatumRodjenja);
            this.Controls.Add(this.cmbGodine);
            this.Controls.Add(this.cmbGodinaStudija);
            this.Controls.Add(this.btnSaveStudent);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.btnOdaberiSliku);
            this.Controls.Add(this.pbSlikaStudenta);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtImeOca);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBrojIndeksa);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student Here";
            this.Load += new System.EventHandler(this.frmAddStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlikaStudenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrojIndeksa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImeOca;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pbSlikaStudenta;
        private System.Windows.Forms.Button btnOdaberiSliku;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.Button btnSaveStudent;
        private System.Windows.Forms.ComboBox cmbGodinaStudija;
        private System.Windows.Forms.ComboBox cmbGodine;
        private System.Windows.Forms.OpenFileDialog ofdOdabirSlike;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.DateTimePicker dtmDatumRodjenja;
        private System.Windows.Forms.Button button1;
    }
}