namespace LTIAdminDesktop.Forms
{
    partial class AdminsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddAdmin = new System.Windows.Forms.Button();
            this.AdminList = new System.Windows.Forms.DataGridView();
            this.DeleteAdmin = new System.Windows.Forms.Button();
            this.CloseForm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AdminList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administradores";
            // 
            // AddAdmin
            // 
            this.AddAdmin.BackColor = System.Drawing.Color.Brown;
            this.AddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAdmin.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAdmin.ForeColor = System.Drawing.Color.White;
            this.AddAdmin.Location = new System.Drawing.Point(723, 406);
            this.AddAdmin.Name = "AddAdmin";
            this.AddAdmin.Size = new System.Drawing.Size(96, 36);
            this.AddAdmin.TabIndex = 11;
            this.AddAdmin.Text = "Añadir";
            this.AddAdmin.UseVisualStyleBackColor = false;
            this.AddAdmin.Click += new System.EventHandler(this.AddAdmin_Click);
            // 
            // AdminList
            // 
            this.AdminList.AllowUserToAddRows = false;
            this.AdminList.AllowUserToDeleteRows = false;
            this.AdminList.AllowUserToResizeRows = false;
            this.AdminList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AdminList.BackgroundColor = System.Drawing.Color.White;
            this.AdminList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AdminList.GridColor = System.Drawing.Color.DarkRed;
            this.AdminList.Location = new System.Drawing.Point(20, 60);
            this.AdminList.MultiSelect = false;
            this.AdminList.Name = "AdminList";
            this.AdminList.ReadOnly = true;
            this.AdminList.Size = new System.Drawing.Size(799, 340);
            this.AdminList.TabIndex = 13;
            this.AdminList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdminList_CellContentClick);
            // 
            // DeleteAdmin
            // 
            this.DeleteAdmin.BackColor = System.Drawing.Color.DarkRed;
            this.DeleteAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAdmin.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAdmin.ForeColor = System.Drawing.Color.White;
            this.DeleteAdmin.Location = new System.Drawing.Point(621, 406);
            this.DeleteAdmin.Name = "DeleteAdmin";
            this.DeleteAdmin.Size = new System.Drawing.Size(96, 36);
            this.DeleteAdmin.TabIndex = 15;
            this.DeleteAdmin.Text = "Eliminar";
            this.DeleteAdmin.UseVisualStyleBackColor = false;
            this.DeleteAdmin.Click += new System.EventHandler(this.DeleteAdmin_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CloseForm);
            this.panel1.Controls.Add(this.AdminList);
            this.panel1.Controls.Add(this.DeleteAdmin);
            this.panel1.Controls.Add(this.AddAdmin);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 455);
            this.panel1.TabIndex = 17;
            // 
            // AdminsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(851, 470);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AdminsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminsForm";
            this.Load += new System.EventHandler(this.AdminsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AdminList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddAdmin;
        private System.Windows.Forms.DataGridView AdminList;
        private System.Windows.Forms.Button DeleteAdmin;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Panel panel1;
    }
}