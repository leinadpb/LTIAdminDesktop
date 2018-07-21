namespace LTIAdminDesktop.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPantallaPrincipal = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SecondNavBack = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdminsControl = new System.Windows.Forms.Button();
            this.DashControl = new System.Windows.Forms.Button();
            this.ExitControl = new System.Windows.Forms.Button();
            this.ConfigControl = new System.Windows.Forms.Button();
            this.SurveyControl = new System.Windows.Forms.Button();
            this.TermsControl = new System.Windows.Forms.Button();
            this.ConfigurationPanel = new System.Windows.Forms.Panel();
            this.SelectTeacherSubject = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ReminderText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.OpenTeacherSurveyFullscreen = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SurveyLinkTeacher = new System.Windows.Forms.TextBox();
            this.OpenStudentSurveyFullscreen = new System.Windows.Forms.CheckBox();
            this.SurveyLink = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ActivateSurveyTeacher = new System.Windows.Forms.CheckBox();
            this.ShowRulesReminder = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AcceptTermsPeriod = new System.Windows.Forms.CheckBox();
            this.ActivateSurvey = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TermsPanel = new System.Windows.Forms.Panel();
            this.ActivateFilter = new System.Windows.Forms.CheckBox();
            this.results = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GenerateReport = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ListSubjects = new System.Windows.Forms.ComboBox();
            this.ListTeachers = new System.Windows.Forms.ComboBox();
            this.ListTrimestres = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.PrintReport = new System.Windows.Forms.Button();
            this.SaveReport = new System.Windows.Forms.Button();
            this.ReportBox = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.TrimestresBtn = new System.Windows.Forms.Button();
            this.NormasBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ConfigurationPanel.SuspendLayout();
            this.TermsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.lbPantallaPrincipal);
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.SecondNavBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1147, 100);
            this.panel1.TabIndex = 0;
            // 
            // lbPantallaPrincipal
            // 
            this.lbPantallaPrincipal.AutoSize = true;
            this.lbPantallaPrincipal.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPantallaPrincipal.ForeColor = System.Drawing.Color.White;
            this.lbPantallaPrincipal.Location = new System.Drawing.Point(197, 24);
            this.lbPantallaPrincipal.Name = "lbPantallaPrincipal";
            this.lbPantallaPrincipal.Size = new System.Drawing.Size(227, 35);
            this.lbPantallaPrincipal.TabIndex = 2;
            this.lbPantallaPrincipal.Text = "Pantalla Principal";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Trebuchet MS", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTitle.Location = new System.Drawing.Point(34, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(127, 84);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "LTI";
            // 
            // SecondNavBack
            // 
            this.SecondNavBack.BackColor = System.Drawing.Color.DarkRed;
            this.SecondNavBack.Location = new System.Drawing.Point(200, 71);
            this.SecondNavBack.Name = "SecondNavBack";
            this.SecondNavBack.Size = new System.Drawing.Size(947, 29);
            this.SecondNavBack.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.NormasBtn);
            this.panel2.Controls.Add(this.TrimestresBtn);
            this.panel2.Controls.Add(this.AdminsControl);
            this.panel2.Controls.Add(this.DashControl);
            this.panel2.Controls.Add(this.ExitControl);
            this.panel2.Controls.Add(this.ConfigControl);
            this.panel2.Controls.Add(this.SurveyControl);
            this.panel2.Controls.Add(this.TermsControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 586);
            this.panel2.TabIndex = 1;
            // 
            // AdminsControl
            // 
            this.AdminsControl.BackColor = System.Drawing.Color.White;
            this.AdminsControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminsControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminsControl.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminsControl.ForeColor = System.Drawing.Color.DarkRed;
            this.AdminsControl.Location = new System.Drawing.Point(6, 123);
            this.AdminsControl.Name = "AdminsControl";
            this.AdminsControl.Size = new System.Drawing.Size(188, 32);
            this.AdminsControl.TabIndex = 5;
            this.AdminsControl.Text = "Administradores";
            this.AdminsControl.UseVisualStyleBackColor = false;
            this.AdminsControl.Click += new System.EventHandler(this.AdminsControl_Click);
            // 
            // DashControl
            // 
            this.DashControl.BackColor = System.Drawing.Color.White;
            this.DashControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DashControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashControl.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashControl.ForeColor = System.Drawing.Color.DarkRed;
            this.DashControl.Location = new System.Drawing.Point(6, 9);
            this.DashControl.Name = "DashControl";
            this.DashControl.Size = new System.Drawing.Size(188, 32);
            this.DashControl.TabIndex = 4;
            this.DashControl.Text = "Pantalla Principal";
            this.DashControl.UseVisualStyleBackColor = false;
            this.DashControl.Click += new System.EventHandler(this.DashControl_Click);
            // 
            // ExitControl
            // 
            this.ExitControl.BackColor = System.Drawing.Color.White;
            this.ExitControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitControl.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitControl.ForeColor = System.Drawing.Color.DarkRed;
            this.ExitControl.Location = new System.Drawing.Point(6, 538);
            this.ExitControl.Name = "ExitControl";
            this.ExitControl.Size = new System.Drawing.Size(188, 32);
            this.ExitControl.TabIndex = 3;
            this.ExitControl.Text = "Salir";
            this.ExitControl.UseVisualStyleBackColor = false;
            this.ExitControl.Click += new System.EventHandler(this.ExitControl_Click);
            // 
            // ConfigControl
            // 
            this.ConfigControl.BackColor = System.Drawing.Color.White;
            this.ConfigControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfigControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigControl.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigControl.ForeColor = System.Drawing.Color.DarkRed;
            this.ConfigControl.Location = new System.Drawing.Point(6, 237);
            this.ConfigControl.Name = "ConfigControl";
            this.ConfigControl.Size = new System.Drawing.Size(188, 32);
            this.ConfigControl.TabIndex = 2;
            this.ConfigControl.Text = "Configuraciones";
            this.ConfigControl.UseVisualStyleBackColor = false;
            this.ConfigControl.Click += new System.EventHandler(this.ConfigControl_Click);
            // 
            // SurveyControl
            // 
            this.SurveyControl.BackColor = System.Drawing.Color.White;
            this.SurveyControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SurveyControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SurveyControl.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurveyControl.ForeColor = System.Drawing.Color.DarkRed;
            this.SurveyControl.Location = new System.Drawing.Point(6, 85);
            this.SurveyControl.Name = "SurveyControl";
            this.SurveyControl.Size = new System.Drawing.Size(188, 32);
            this.SurveyControl.TabIndex = 1;
            this.SurveyControl.Text = "Control de Encuestas";
            this.SurveyControl.UseVisualStyleBackColor = false;
            this.SurveyControl.Click += new System.EventHandler(this.SurveyControl_Click);
            // 
            // TermsControl
            // 
            this.TermsControl.BackColor = System.Drawing.Color.White;
            this.TermsControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TermsControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TermsControl.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TermsControl.ForeColor = System.Drawing.Color.DarkRed;
            this.TermsControl.Location = new System.Drawing.Point(6, 47);
            this.TermsControl.Name = "TermsControl";
            this.TermsControl.Size = new System.Drawing.Size(188, 32);
            this.TermsControl.TabIndex = 0;
            this.TermsControl.Text = "Control de Normas";
            this.TermsControl.UseVisualStyleBackColor = false;
            this.TermsControl.Click += new System.EventHandler(this.TermsControl_Click);
            // 
            // ConfigurationPanel
            // 
            this.ConfigurationPanel.BackColor = System.Drawing.Color.White;
            this.ConfigurationPanel.Controls.Add(this.SelectTeacherSubject);
            this.ConfigurationPanel.Controls.Add(this.label11);
            this.ConfigurationPanel.Controls.Add(this.ReminderText);
            this.ConfigurationPanel.Controls.Add(this.button1);
            this.ConfigurationPanel.Controls.Add(this.OpenTeacherSurveyFullscreen);
            this.ConfigurationPanel.Controls.Add(this.label2);
            this.ConfigurationPanel.Controls.Add(this.label3);
            this.ConfigurationPanel.Controls.Add(this.SurveyLinkTeacher);
            this.ConfigurationPanel.Controls.Add(this.OpenStudentSurveyFullscreen);
            this.ConfigurationPanel.Controls.Add(this.SurveyLink);
            this.ConfigurationPanel.Controls.Add(this.label4);
            this.ConfigurationPanel.Controls.Add(this.ActivateSurveyTeacher);
            this.ConfigurationPanel.Controls.Add(this.ShowRulesReminder);
            this.ConfigurationPanel.Controls.Add(this.label1);
            this.ConfigurationPanel.Controls.Add(this.AcceptTermsPeriod);
            this.ConfigurationPanel.Controls.Add(this.ActivateSurvey);
            this.ConfigurationPanel.Controls.Add(this.label5);
            this.ConfigurationPanel.Location = new System.Drawing.Point(206, 109);
            this.ConfigurationPanel.Name = "ConfigurationPanel";
            this.ConfigurationPanel.Size = new System.Drawing.Size(941, 577);
            this.ConfigurationPanel.TabIndex = 2;
            // 
            // SelectTeacherSubject
            // 
            this.SelectTeacherSubject.AutoSize = true;
            this.SelectTeacherSubject.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectTeacherSubject.Location = new System.Drawing.Point(54, 190);
            this.SelectTeacherSubject.Name = "SelectTeacherSubject";
            this.SelectTeacherSubject.Size = new System.Drawing.Size(328, 24);
            this.SelectTeacherSubject.TabIndex = 15;
            this.SelectTeacherSubject.Text = "Permitir seleccionar asignatura y/o profesor.";
            this.SelectTeacherSubject.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(51, 296);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(153, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Texto en el recordatorio:";
            // 
            // ReminderText
            // 
            this.ReminderText.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReminderText.Location = new System.Drawing.Point(54, 317);
            this.ReminderText.Name = "ReminderText";
            this.ReminderText.Size = new System.Drawing.Size(364, 23);
            this.ReminderText.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(767, 520);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar cambios";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenTeacherSurveyFullscreen
            // 
            this.OpenTeacherSurveyFullscreen.AutoSize = true;
            this.OpenTeacherSurveyFullscreen.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTeacherSurveyFullscreen.Location = new System.Drawing.Point(651, 378);
            this.OpenTeacherSurveyFullscreen.Name = "OpenTeacherSurveyFullscreen";
            this.OpenTeacherSurveyFullscreen.Size = new System.Drawing.Size(178, 22);
            this.OpenTeacherSurveyFullscreen.TabIndex = 9;
            this.OpenTeacherSurveyFullscreen.Text = "Abrir en pantalla completa.";
            this.OpenTeacherSurveyFullscreen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(537, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Link de la encuesta para estudiantes.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(540, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Link de la encuesta para profesores.";
            // 
            // SurveyLinkTeacher
            // 
            this.SurveyLinkTeacher.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurveyLinkTeacher.Location = new System.Drawing.Point(540, 349);
            this.SurveyLinkTeacher.Name = "SurveyLinkTeacher";
            this.SurveyLinkTeacher.Size = new System.Drawing.Size(364, 23);
            this.SurveyLinkTeacher.TabIndex = 6;
            // 
            // OpenStudentSurveyFullscreen
            // 
            this.OpenStudentSurveyFullscreen.AutoSize = true;
            this.OpenStudentSurveyFullscreen.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenStudentSurveyFullscreen.Location = new System.Drawing.Point(651, 231);
            this.OpenStudentSurveyFullscreen.Name = "OpenStudentSurveyFullscreen";
            this.OpenStudentSurveyFullscreen.Size = new System.Drawing.Size(178, 22);
            this.OpenStudentSurveyFullscreen.TabIndex = 8;
            this.OpenStudentSurveyFullscreen.Text = "Abrir en pantalla completa.";
            this.OpenStudentSurveyFullscreen.UseVisualStyleBackColor = true;
            // 
            // SurveyLink
            // 
            this.SurveyLink.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurveyLink.Location = new System.Drawing.Point(540, 202);
            this.SurveyLink.Name = "SurveyLink";
            this.SurveyLink.Size = new System.Drawing.Size(364, 23);
            this.SurveyLink.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(671, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Encuestas";
            // 
            // ActivateSurveyTeacher
            // 
            this.ActivateSurveyTeacher.AutoSize = true;
            this.ActivateSurveyTeacher.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateSurveyTeacher.Location = new System.Drawing.Point(543, 299);
            this.ActivateSurveyTeacher.Name = "ActivateSurveyTeacher";
            this.ActivateSurveyTeacher.Size = new System.Drawing.Size(353, 24);
            this.ActivateSurveyTeacher.TabIndex = 5;
            this.ActivateSurveyTeacher.Text = "Activar encuesta de satisfacción para profesores";
            this.ActivateSurveyTeacher.UseVisualStyleBackColor = true;
            this.ActivateSurveyTeacher.CheckedChanged += new System.EventHandler(this.ActivateSurveyTeacher_CheckedChanged);
            // 
            // ShowRulesReminder
            // 
            this.ShowRulesReminder.AutoSize = true;
            this.ShowRulesReminder.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRulesReminder.Location = new System.Drawing.Point(54, 231);
            this.ShowRulesReminder.Name = "ShowRulesReminder";
            this.ShowRulesReminder.Size = new System.Drawing.Size(386, 44);
            this.ShowRulesReminder.TabIndex = 12;
            this.ShowRulesReminder.Text = "Mostrar el recordatorio de las tres normas principales\r\nal iniciar sesión en cual" +
    "quier computador.";
            this.ShowRulesReminder.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 27);
            this.label1.TabIndex = 0;
            // 
            // AcceptTermsPeriod
            // 
            this.AcceptTermsPeriod.AutoSize = true;
            this.AcceptTermsPeriod.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptTermsPeriod.Location = new System.Drawing.Point(54, 149);
            this.AcceptTermsPeriod.Name = "AcceptTermsPeriod";
            this.AcceptTermsPeriod.Size = new System.Drawing.Size(327, 24);
            this.AcceptTermsPeriod.TabIndex = 11;
            this.AcceptTermsPeriod.Text = "Permitir aceptar las normas del Laboratorio.";
            this.AcceptTermsPeriod.UseVisualStyleBackColor = true;
            // 
            // ActivateSurvey
            // 
            this.ActivateSurvey.AutoSize = true;
            this.ActivateSurvey.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateSurvey.Location = new System.Drawing.Point(539, 149);
            this.ActivateSurvey.Name = "ActivateSurvey";
            this.ActivateSurvey.Size = new System.Drawing.Size(365, 24);
            this.ActivateSurvey.TabIndex = 1;
            this.ActivateSurvey.Text = "Activar encuesta de satisfacción para estudiantes.";
            this.ActivateSurvey.UseVisualStyleBackColor = true;
            this.ActivateSurvey.CheckedChanged += new System.EventHandler(this.ActivateSurvey_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(174, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Normas";
            // 
            // TermsPanel
            // 
            this.TermsPanel.BackColor = System.Drawing.Color.White;
            this.TermsPanel.Controls.Add(this.ActivateFilter);
            this.TermsPanel.Controls.Add(this.results);
            this.TermsPanel.Controls.Add(this.label10);
            this.TermsPanel.Controls.Add(this.textBox1);
            this.TermsPanel.Controls.Add(this.GenerateReport);
            this.TermsPanel.Controls.Add(this.label9);
            this.TermsPanel.Controls.Add(this.label8);
            this.TermsPanel.Controls.Add(this.label7);
            this.TermsPanel.Controls.Add(this.ListSubjects);
            this.TermsPanel.Controls.Add(this.ListTeachers);
            this.TermsPanel.Controls.Add(this.ListTrimestres);
            this.TermsPanel.Controls.Add(this.label6);
            this.TermsPanel.Controls.Add(this.PrintReport);
            this.TermsPanel.Controls.Add(this.SaveReport);
            this.TermsPanel.Controls.Add(this.ReportBox);
            this.TermsPanel.Location = new System.Drawing.Point(206, 109);
            this.TermsPanel.Name = "TermsPanel";
            this.TermsPanel.Size = new System.Drawing.Size(941, 577);
            this.TermsPanel.TabIndex = 3;
            // 
            // ActivateFilter
            // 
            this.ActivateFilter.AutoSize = true;
            this.ActivateFilter.Location = new System.Drawing.Point(19, 35);
            this.ActivateFilter.Name = "ActivateFilter";
            this.ActivateFilter.Size = new System.Drawing.Size(15, 14);
            this.ActivateFilter.TabIndex = 14;
            this.ActivateFilter.UseVisualStyleBackColor = true;
            this.ActivateFilter.CheckedChanged += new System.EventHandler(this.ActivateFilter_CheckedChanged);
            // 
            // results
            // 
            this.results.AutoSize = true;
            this.results.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(384, 523);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(166, 18);
            this.results.TabIndex = 13;
            this.results.Text = "13 resultados encontrados.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(689, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Buscar por Nombre / ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(690, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 25);
            this.textBox1.TabIndex = 11;
            // 
            // GenerateReport
            // 
            this.GenerateReport.BackColor = System.Drawing.Color.Brown;
            this.GenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateReport.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateReport.ForeColor = System.Drawing.Color.White;
            this.GenerateReport.Location = new System.Drawing.Point(836, 523);
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Size = new System.Drawing.Size(96, 36);
            this.GenerateReport.TabIndex = 10;
            this.GenerateReport.Text = "Generar";
            this.GenerateReport.UseVisualStyleBackColor = false;
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(485, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Asignatura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(277, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Profesor/a";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(75, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trimestre";
            // 
            // ListSubjects
            // 
            this.ListSubjects.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListSubjects.FormattingEnabled = true;
            this.ListSubjects.Location = new System.Drawing.Point(485, 24);
            this.ListSubjects.Name = "ListSubjects";
            this.ListSubjects.Size = new System.Drawing.Size(199, 28);
            this.ListSubjects.TabIndex = 6;
            // 
            // ListTeachers
            // 
            this.ListTeachers.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTeachers.FormattingEnabled = true;
            this.ListTeachers.Location = new System.Drawing.Point(280, 24);
            this.ListTeachers.Name = "ListTeachers";
            this.ListTeachers.Size = new System.Drawing.Size(199, 28);
            this.ListTeachers.TabIndex = 5;
            // 
            // ListTrimestres
            // 
            this.ListTrimestres.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListTrimestres.FormattingEnabled = true;
            this.ListTrimestres.Location = new System.Drawing.Point(75, 24);
            this.ListTrimestres.Name = "ListTrimestres";
            this.ListTrimestres.Size = new System.Drawing.Size(199, 28);
            this.ListTrimestres.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Filtrar:";
            // 
            // PrintReport
            // 
            this.PrintReport.BackColor = System.Drawing.Color.DarkRed;
            this.PrintReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrintReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintReport.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintReport.ForeColor = System.Drawing.Color.White;
            this.PrintReport.Location = new System.Drawing.Point(6, 523);
            this.PrintReport.Name = "PrintReport";
            this.PrintReport.Size = new System.Drawing.Size(96, 36);
            this.PrintReport.TabIndex = 2;
            this.PrintReport.Text = "Imprimir";
            this.PrintReport.UseVisualStyleBackColor = false;
            // 
            // SaveReport
            // 
            this.SaveReport.BackColor = System.Drawing.Color.DarkRed;
            this.SaveReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveReport.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveReport.ForeColor = System.Drawing.Color.White;
            this.SaveReport.Location = new System.Drawing.Point(108, 523);
            this.SaveReport.Name = "SaveReport";
            this.SaveReport.Size = new System.Drawing.Size(96, 36);
            this.SaveReport.TabIndex = 1;
            this.SaveReport.Text = "Guardar";
            this.SaveReport.UseVisualStyleBackColor = false;
            // 
            // ReportBox
            // 
            this.ReportBox.AllowUserToAddRows = false;
            this.ReportBox.AllowUserToDeleteRows = false;
            this.ReportBox.AllowUserToResizeRows = false;
            this.ReportBox.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReportBox.BackgroundColor = System.Drawing.Color.White;
            this.ReportBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportBox.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReportBox.DefaultCellStyle = dataGridViewCellStyle1;
            this.ReportBox.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ReportBox.GridColor = System.Drawing.Color.DarkRed;
            this.ReportBox.Location = new System.Drawing.Point(6, 58);
            this.ReportBox.Name = "ReportBox";
            this.ReportBox.Size = new System.Drawing.Size(929, 454);
            this.ReportBox.TabIndex = 0;
            this.ReportBox.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReportBox_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(216, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "EN CONSTRUCCION...";
            // 
            // TrimestresBtn
            // 
            this.TrimestresBtn.BackColor = System.Drawing.Color.White;
            this.TrimestresBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrimestresBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TrimestresBtn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrimestresBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.TrimestresBtn.Location = new System.Drawing.Point(6, 161);
            this.TrimestresBtn.Name = "TrimestresBtn";
            this.TrimestresBtn.Size = new System.Drawing.Size(188, 32);
            this.TrimestresBtn.TabIndex = 6;
            this.TrimestresBtn.Text = "Trimestres";
            this.TrimestresBtn.UseVisualStyleBackColor = false;
            this.TrimestresBtn.Click += new System.EventHandler(this.TrimestresBtn_Click);
            // 
            // NormasBtn
            // 
            this.NormasBtn.BackColor = System.Drawing.Color.White;
            this.NormasBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NormasBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NormasBtn.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormasBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.NormasBtn.Location = new System.Drawing.Point(6, 199);
            this.NormasBtn.Name = "NormasBtn";
            this.NormasBtn.Size = new System.Drawing.Size(188, 32);
            this.NormasBtn.TabIndex = 7;
            this.NormasBtn.Text = "Normas";
            this.NormasBtn.UseVisualStyleBackColor = false;
            this.NormasBtn.Click += new System.EventHandler(this.NormasBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 686);
            this.Controls.Add(this.TermsPanel);
            this.Controls.Add(this.ConfigurationPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ConfigurationPanel.ResumeLayout(false);
            this.ConfigurationPanel.PerformLayout();
            this.TermsPanel.ResumeLayout(false);
            this.TermsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReportBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel ConfigurationPanel;
        private System.Windows.Forms.Button TermsControl;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel SecondNavBack;
        private System.Windows.Forms.Button ExitControl;
        private System.Windows.Forms.Button ConfigControl;
        private System.Windows.Forms.Button SurveyControl;
        private System.Windows.Forms.Label lbPantallaPrincipal;
        private System.Windows.Forms.Button DashControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SurveyLink;
        private System.Windows.Forms.CheckBox ActivateSurvey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox ShowRulesReminder;
        private System.Windows.Forms.CheckBox AcceptTermsPeriod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox OpenTeacherSurveyFullscreen;
        private System.Windows.Forms.CheckBox OpenStudentSurveyFullscreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SurveyLinkTeacher;
        private System.Windows.Forms.CheckBox ActivateSurveyTeacher;
        private System.Windows.Forms.Panel TermsPanel;
        private System.Windows.Forms.DataGridView ReportBox;
        private System.Windows.Forms.Button PrintReport;
        private System.Windows.Forms.Button SaveReport;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ListSubjects;
        private System.Windows.Forms.ComboBox ListTeachers;
        private System.Windows.Forms.ComboBox ListTrimestres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button GenerateReport;
        private System.Windows.Forms.Button AdminsControl;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.CheckBox ActivateFilter;
        private System.Windows.Forms.CheckBox SelectTeacherSubject;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ReminderText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button TrimestresBtn;
        private System.Windows.Forms.Button NormasBtn;
    }
}