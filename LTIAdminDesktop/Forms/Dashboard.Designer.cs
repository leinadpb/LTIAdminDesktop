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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPantallaPrincipal = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.SecondNavBack = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DashControl = new System.Windows.Forms.Button();
            this.ExitControl = new System.Windows.Forms.Button();
            this.ConfigControl = new System.Windows.Forms.Button();
            this.SurveyControl = new System.Windows.Forms.Button();
            this.TermsControl = new System.Windows.Forms.Button();
            this.ConfigurationPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DashBoardPanel = new System.Windows.Forms.Panel();
            this.ShowRulesReminder = new System.Windows.Forms.CheckBox();
            this.AcceptTermsPeriod = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OpenTeacherSurveyFullscreen = new System.Windows.Forms.CheckBox();
            this.SurveyLink = new System.Windows.Forms.TextBox();
            this.OpenStudentSurveyFullscreen = new System.Windows.Forms.CheckBox();
            this.ActivateSurvey = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SurveyLinkTeacher = new System.Windows.Forms.TextBox();
            this.ActivateSurveyTeacher = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ConfigurationPanel.SuspendLayout();
            this.DashBoardPanel.SuspendLayout();
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
            this.panel2.Controls.Add(this.DashControl);
            this.panel2.Controls.Add(this.ExitControl);
            this.panel2.Controls.Add(this.ConfigControl);
            this.panel2.Controls.Add(this.SurveyControl);
            this.panel2.Controls.Add(this.TermsControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 570);
            this.panel2.TabIndex = 1;
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
            this.ExitControl.Location = new System.Drawing.Point(6, 526);
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
            this.ConfigControl.Location = new System.Drawing.Point(6, 123);
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
            this.ConfigurationPanel.Controls.Add(this.label1);
            this.ConfigurationPanel.Controls.Add(this.DashBoardPanel);
            this.ConfigurationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfigurationPanel.Location = new System.Drawing.Point(200, 100);
            this.ConfigurationPanel.Name = "ConfigurationPanel";
            this.ConfigurationPanel.Size = new System.Drawing.Size(947, 570);
            this.ConfigurationPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Configuraciones";
            // 
            // DashBoardPanel
            // 
            this.DashBoardPanel.Controls.Add(this.ShowRulesReminder);
            this.DashBoardPanel.Controls.Add(this.AcceptTermsPeriod);
            this.DashBoardPanel.Controls.Add(this.label5);
            this.DashBoardPanel.Controls.Add(this.label4);
            this.DashBoardPanel.Controls.Add(this.label2);
            this.DashBoardPanel.Controls.Add(this.OpenTeacherSurveyFullscreen);
            this.DashBoardPanel.Controls.Add(this.SurveyLink);
            this.DashBoardPanel.Controls.Add(this.OpenStudentSurveyFullscreen);
            this.DashBoardPanel.Controls.Add(this.ActivateSurvey);
            this.DashBoardPanel.Controls.Add(this.label3);
            this.DashBoardPanel.Controls.Add(this.button1);
            this.DashBoardPanel.Controls.Add(this.SurveyLinkTeacher);
            this.DashBoardPanel.Controls.Add(this.ActivateSurveyTeacher);
            this.DashBoardPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DashBoardPanel.Location = new System.Drawing.Point(0, 0);
            this.DashBoardPanel.Name = "DashBoardPanel";
            this.DashBoardPanel.Size = new System.Drawing.Size(947, 570);
            this.DashBoardPanel.TabIndex = 4;
            // 
            // ShowRulesReminder
            // 
            this.ShowRulesReminder.AutoSize = true;
            this.ShowRulesReminder.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowRulesReminder.Location = new System.Drawing.Point(38, 201);
            this.ShowRulesReminder.Name = "ShowRulesReminder";
            this.ShowRulesReminder.Size = new System.Drawing.Size(386, 44);
            this.ShowRulesReminder.TabIndex = 12;
            this.ShowRulesReminder.Text = "Mostrar el recordatorio de las tres normas principales\r\nal iniciar sesión en cual" +
    "quier computador.";
            this.ShowRulesReminder.UseVisualStyleBackColor = true;
            // 
            // AcceptTermsPeriod
            // 
            this.AcceptTermsPeriod.AutoSize = true;
            this.AcceptTermsPeriod.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AcceptTermsPeriod.Location = new System.Drawing.Point(38, 152);
            this.AcceptTermsPeriod.Name = "AcceptTermsPeriod";
            this.AcceptTermsPeriod.Size = new System.Drawing.Size(327, 24);
            this.AcceptTermsPeriod.TabIndex = 11;
            this.AcceptTermsPeriod.Text = "Permitir aceptar las normas del Laboratorio.";
            this.AcceptTermsPeriod.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(140, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "Normas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(667, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Encuestas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Link de la encuesta para estudiantes.";
            // 
            // OpenTeacherSurveyFullscreen
            // 
            this.OpenTeacherSurveyFullscreen.AutoSize = true;
            this.OpenTeacherSurveyFullscreen.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenTeacherSurveyFullscreen.Location = new System.Drawing.Point(646, 395);
            this.OpenTeacherSurveyFullscreen.Name = "OpenTeacherSurveyFullscreen";
            this.OpenTeacherSurveyFullscreen.Size = new System.Drawing.Size(178, 22);
            this.OpenTeacherSurveyFullscreen.TabIndex = 9;
            this.OpenTeacherSurveyFullscreen.Text = "Abrir en pantalla completa.";
            this.OpenTeacherSurveyFullscreen.UseVisualStyleBackColor = true;
            // 
            // SurveyLink
            // 
            this.SurveyLink.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurveyLink.Location = new System.Drawing.Point(539, 211);
            this.SurveyLink.Name = "SurveyLink";
            this.SurveyLink.Size = new System.Drawing.Size(364, 23);
            this.SurveyLink.TabIndex = 2;
            // 
            // OpenStudentSurveyFullscreen
            // 
            this.OpenStudentSurveyFullscreen.AutoSize = true;
            this.OpenStudentSurveyFullscreen.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenStudentSurveyFullscreen.Location = new System.Drawing.Point(646, 240);
            this.OpenStudentSurveyFullscreen.Name = "OpenStudentSurveyFullscreen";
            this.OpenStudentSurveyFullscreen.Size = new System.Drawing.Size(178, 22);
            this.OpenStudentSurveyFullscreen.TabIndex = 8;
            this.OpenStudentSurveyFullscreen.Text = "Abrir en pantalla completa.";
            this.OpenStudentSurveyFullscreen.UseVisualStyleBackColor = true;
            // 
            // ActivateSurvey
            // 
            this.ActivateSurvey.AutoSize = true;
            this.ActivateSurvey.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateSurvey.Location = new System.Drawing.Point(538, 152);
            this.ActivateSurvey.Name = "ActivateSurvey";
            this.ActivateSurvey.Size = new System.Drawing.Size(365, 24);
            this.ActivateSurvey.TabIndex = 1;
            this.ActivateSurvey.Text = "Activar encuesta de satisfacción para estudiantes.";
            this.ActivateSurvey.UseVisualStyleBackColor = true;
            this.ActivateSurvey.CheckedChanged += new System.EventHandler(this.ActivateSurvey_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(548, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Link de la encuesta para profesores.";
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
            this.button1.Location = new System.Drawing.Point(784, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Guardar cambios";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SurveyLinkTeacher
            // 
            this.SurveyLinkTeacher.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurveyLinkTeacher.Location = new System.Drawing.Point(550, 366);
            this.SurveyLinkTeacher.Name = "SurveyLinkTeacher";
            this.SurveyLinkTeacher.Size = new System.Drawing.Size(364, 23);
            this.SurveyLinkTeacher.TabIndex = 6;
            // 
            // ActivateSurveyTeacher
            // 
            this.ActivateSurveyTeacher.AutoSize = true;
            this.ActivateSurveyTeacher.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActivateSurveyTeacher.Location = new System.Drawing.Point(549, 307);
            this.ActivateSurveyTeacher.Name = "ActivateSurveyTeacher";
            this.ActivateSurveyTeacher.Size = new System.Drawing.Size(353, 24);
            this.ActivateSurveyTeacher.TabIndex = 5;
            this.ActivateSurveyTeacher.Text = "Activar encuesta de satisfacción para profesores";
            this.ActivateSurveyTeacher.UseVisualStyleBackColor = true;
            this.ActivateSurveyTeacher.CheckedChanged += new System.EventHandler(this.ActivateSurveyTeacher_CheckedChanged);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 670);
            this.Controls.Add(this.ConfigurationPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
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
            this.DashBoardPanel.ResumeLayout(false);
            this.DashBoardPanel.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel DashBoardPanel;
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
    }
}