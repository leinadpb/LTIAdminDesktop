namespace LTIAdminDesktop.Forms
{
    partial class TrimestresForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.CloseForm = new System.Windows.Forms.Button();
            this.TrimestresList = new System.Windows.Forms.DataGridView();
            this.ModifyTrimestre = new System.Windows.Forms.Button();
            this.AddTrimestre = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrimestresList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseForm);
            this.panel1.Controls.Add(this.TrimestresList);
            this.panel1.Controls.Add(this.ModifyTrimestre);
            this.panel1.Controls.Add(this.AddTrimestre);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 455);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trimestres";
            // 
            // CloseForm
            // 
            this.CloseForm.BackColor = System.Drawing.Color.DarkRed;
            this.CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseForm.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseForm.ForeColor = System.Drawing.Color.White;
            this.CloseForm.Location = new System.Drawing.Point(791, 12);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(28, 27);
            this.CloseForm.TabIndex = 16;
            this.CloseForm.Text = "X";
            this.CloseForm.UseVisualStyleBackColor = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // TrimestresList
            // 
            this.TrimestresList.AllowUserToAddRows = false;
            this.TrimestresList.AllowUserToDeleteRows = false;
            this.TrimestresList.AllowUserToResizeRows = false;
            this.TrimestresList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TrimestresList.BackgroundColor = System.Drawing.Color.White;
            this.TrimestresList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrimestresList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TrimestresList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.TrimestresList.GridColor = System.Drawing.Color.DarkRed;
            this.TrimestresList.Location = new System.Drawing.Point(20, 60);
            this.TrimestresList.MultiSelect = false;
            this.TrimestresList.Name = "TrimestresList";
            this.TrimestresList.ReadOnly = true;
            this.TrimestresList.Size = new System.Drawing.Size(799, 340);
            this.TrimestresList.TabIndex = 13;
            // 
            // ModifyTrimestre
            // 
            this.ModifyTrimestre.BackColor = System.Drawing.Color.DarkRed;
            this.ModifyTrimestre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModifyTrimestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyTrimestre.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyTrimestre.ForeColor = System.Drawing.Color.White;
            this.ModifyTrimestre.Location = new System.Drawing.Point(621, 406);
            this.ModifyTrimestre.Name = "ModifyTrimestre";
            this.ModifyTrimestre.Size = new System.Drawing.Size(96, 36);
            this.ModifyTrimestre.TabIndex = 15;
            this.ModifyTrimestre.Text = "Modificar";
            this.ModifyTrimestre.UseVisualStyleBackColor = false;
            this.ModifyTrimestre.Click += new System.EventHandler(this.ModifyTrimestre_Click);
            // 
            // AddTrimestre
            // 
            this.AddTrimestre.BackColor = System.Drawing.Color.Brown;
            this.AddTrimestre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTrimestre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTrimestre.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTrimestre.ForeColor = System.Drawing.Color.White;
            this.AddTrimestre.Location = new System.Drawing.Point(723, 406);
            this.AddTrimestre.Name = "AddTrimestre";
            this.AddTrimestre.Size = new System.Drawing.Size(96, 36);
            this.AddTrimestre.TabIndex = 11;
            this.AddTrimestre.Text = "Añadir";
            this.AddTrimestre.UseVisualStyleBackColor = false;
            this.AddTrimestre.Click += new System.EventHandler(this.AddTrimestre_Click);
            // 
            // TrimestresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(853, 472);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TrimestresForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrimestresForm";
            this.Load += new System.EventHandler(this.TrimestresForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrimestresList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.DataGridView TrimestresList;
        private System.Windows.Forms.Button ModifyTrimestre;
        private System.Windows.Forms.Button AddTrimestre;
    }
}