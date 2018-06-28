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
            this.panel2 = new System.Windows.Forms.Panel();
            this.TermsControl = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SurveyControl = new System.Windows.Forms.Button();
            this.ConfigControl = new System.Windows.Forms.Button();
            this.ExitControl = new System.Windows.Forms.Button();
            this.SecondNavBack = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbPantallaPrincipal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
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
            // TermsControl
            // 
            this.TermsControl.BackColor = System.Drawing.Color.White;
            this.TermsControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TermsControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TermsControl.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TermsControl.ForeColor = System.Drawing.Color.DarkRed;
            this.TermsControl.Location = new System.Drawing.Point(6, 6);
            this.TermsControl.Name = "TermsControl";
            this.TermsControl.Size = new System.Drawing.Size(188, 32);
            this.TermsControl.TabIndex = 0;
            this.TermsControl.Text = "Control de Normas";
            this.TermsControl.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(947, 570);
            this.panel3.TabIndex = 2;
            // 
            // SurveyControl
            // 
            this.SurveyControl.BackColor = System.Drawing.Color.White;
            this.SurveyControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SurveyControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SurveyControl.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurveyControl.ForeColor = System.Drawing.Color.DarkRed;
            this.SurveyControl.Location = new System.Drawing.Point(6, 44);
            this.SurveyControl.Name = "SurveyControl";
            this.SurveyControl.Size = new System.Drawing.Size(188, 32);
            this.SurveyControl.TabIndex = 1;
            this.SurveyControl.Text = "Control de Encuestas";
            this.SurveyControl.UseVisualStyleBackColor = false;
            // 
            // ConfigControl
            // 
            this.ConfigControl.BackColor = System.Drawing.Color.White;
            this.ConfigControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfigControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfigControl.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfigControl.ForeColor = System.Drawing.Color.DarkRed;
            this.ConfigControl.Location = new System.Drawing.Point(6, 82);
            this.ConfigControl.Name = "ConfigControl";
            this.ConfigControl.Size = new System.Drawing.Size(188, 32);
            this.ConfigControl.TabIndex = 2;
            this.ConfigControl.Text = "Configuraciones";
            this.ConfigControl.UseVisualStyleBackColor = false;
            this.ConfigControl.Click += new System.EventHandler(this.ConfigControl_Click);
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
            // 
            // SecondNavBack
            // 
            this.SecondNavBack.BackColor = System.Drawing.Color.DarkRed;
            this.SecondNavBack.Location = new System.Drawing.Point(200, 71);
            this.SecondNavBack.Name = "SecondNavBack";
            this.SecondNavBack.Size = new System.Drawing.Size(947, 29);
            this.SecondNavBack.TabIndex = 0;
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
            // lbPantallaPrincipal
            // 
            this.lbPantallaPrincipal.AutoSize = true;
            this.lbPantallaPrincipal.Font = new System.Drawing.Font("Tempus Sans ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPantallaPrincipal.ForeColor = System.Drawing.Color.White;
            this.lbPantallaPrincipal.Location = new System.Drawing.Point(537, 15);
            this.lbPantallaPrincipal.Name = "lbPantallaPrincipal";
            this.lbPantallaPrincipal.Size = new System.Drawing.Size(269, 46);
            this.lbPantallaPrincipal.TabIndex = 2;
            this.lbPantallaPrincipal.Text = "Pantalla Principal";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 670);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button TermsControl;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel SecondNavBack;
        private System.Windows.Forms.Button ExitControl;
        private System.Windows.Forms.Button ConfigControl;
        private System.Windows.Forms.Button SurveyControl;
        private System.Windows.Forms.Label lbPantallaPrincipal;
    }
}