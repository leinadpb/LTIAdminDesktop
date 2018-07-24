namespace LTIAdminDesktop.Forms
{
    partial class NormasForm
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
            this.DeleteNorma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseForm = new System.Windows.Forms.Button();
            this.NormasList = new System.Windows.Forms.DataGridView();
            this.ModifyNorma = new System.Windows.Forms.Button();
            this.AddNorma = new System.Windows.Forms.Button();
            this.NormaID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NormasList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.NormaID);
            this.panel1.Controls.Add(this.DeleteNorma);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseForm);
            this.panel1.Controls.Add(this.NormasList);
            this.panel1.Controls.Add(this.ModifyNorma);
            this.panel1.Controls.Add(this.AddNorma);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 455);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DeleteNorma
            // 
            this.DeleteNorma.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteNorma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteNorma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNorma.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteNorma.ForeColor = System.Drawing.Color.White;
            this.DeleteNorma.Location = new System.Drawing.Point(519, 407);
            this.DeleteNorma.Name = "DeleteNorma";
            this.DeleteNorma.Size = new System.Drawing.Size(96, 36);
            this.DeleteNorma.TabIndex = 17;
            this.DeleteNorma.Text = "Eliminar";
            this.DeleteNorma.UseVisualStyleBackColor = false;
            this.DeleteNorma.Click += new System.EventHandler(this.DeleteNorma_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Normas";
            // 
            // CloseForm
            // 
            this.CloseForm.BackColor = System.Drawing.Color.DarkRed;
            this.CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseForm.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseForm.ForeColor = System.Drawing.Color.White;
            this.CloseForm.Location = new System.Drawing.Point(785, 13);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(33, 29);
            this.CloseForm.TabIndex = 16;
            this.CloseForm.Text = "X";
            this.CloseForm.UseVisualStyleBackColor = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // NormasList
            // 
            this.NormasList.AllowUserToAddRows = false;
            this.NormasList.AllowUserToDeleteRows = false;
            this.NormasList.AllowUserToResizeRows = false;
            this.NormasList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.NormasList.BackgroundColor = System.Drawing.Color.White;
            this.NormasList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NormasList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NormasList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.NormasList.GridColor = System.Drawing.Color.DarkRed;
            this.NormasList.Location = new System.Drawing.Point(20, 60);
            this.NormasList.MultiSelect = false;
            this.NormasList.Name = "NormasList";
            this.NormasList.ReadOnly = true;
            this.NormasList.Size = new System.Drawing.Size(799, 340);
            this.NormasList.TabIndex = 13;
            this.NormasList.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.NormasList_RowEnter);
            // 
            // ModifyNorma
            // 
            this.ModifyNorma.BackColor = System.Drawing.Color.DarkRed;
            this.ModifyNorma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ModifyNorma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyNorma.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyNorma.ForeColor = System.Drawing.Color.White;
            this.ModifyNorma.Location = new System.Drawing.Point(621, 407);
            this.ModifyNorma.Name = "ModifyNorma";
            this.ModifyNorma.Size = new System.Drawing.Size(96, 36);
            this.ModifyNorma.TabIndex = 15;
            this.ModifyNorma.Text = "Modificar";
            this.ModifyNorma.UseVisualStyleBackColor = false;
            this.ModifyNorma.Click += new System.EventHandler(this.ModifyNorma_Click);
            // 
            // AddNorma
            // 
            this.AddNorma.BackColor = System.Drawing.Color.Brown;
            this.AddNorma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddNorma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNorma.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNorma.ForeColor = System.Drawing.Color.White;
            this.AddNorma.Location = new System.Drawing.Point(723, 407);
            this.AddNorma.Name = "AddNorma";
            this.AddNorma.Size = new System.Drawing.Size(96, 36);
            this.AddNorma.TabIndex = 11;
            this.AddNorma.Text = "Añadir";
            this.AddNorma.UseVisualStyleBackColor = false;
            this.AddNorma.Click += new System.EventHandler(this.AddNorma_Click);
            // 
            // NormaID
            // 
            this.NormaID.AutoSize = true;
            this.NormaID.Location = new System.Drawing.Point(20, 407);
            this.NormaID.Name = "NormaID";
            this.NormaID.Size = new System.Drawing.Size(0, 13);
            this.NormaID.TabIndex = 18;
            // 
            // NormasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(859, 479);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NormasForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NormasForm";
            this.Load += new System.EventHandler(this.NormasForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NormasList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button DeleteNorma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.DataGridView NormasList;
        private System.Windows.Forms.Button ModifyNorma;
        private System.Windows.Forms.Button AddNorma;
        private System.Windows.Forms.Label NormaID;
    }
}