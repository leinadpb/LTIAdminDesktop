namespace LTIAdminDesktop.Forms
{
    partial class DeleteNorma
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
            this.CloseForm = new System.Windows.Forms.Button();
            this.DeleteNormaBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NormaList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CloseForm);
            this.panel1.Controls.Add(this.DeleteNormaBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NormaList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 198);
            this.panel1.TabIndex = 3;
            // 
            // CloseForm
            // 
            this.CloseForm.BackColor = System.Drawing.Color.DarkRed;
            this.CloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseForm.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseForm.ForeColor = System.Drawing.Color.White;
            this.CloseForm.Location = new System.Drawing.Point(523, 11);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(37, 32);
            this.CloseForm.TabIndex = 4;
            this.CloseForm.Text = "X";
            this.CloseForm.UseVisualStyleBackColor = false;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // DeleteNormaBtn
            // 
            this.DeleteNormaBtn.BackColor = System.Drawing.Color.Brown;
            this.DeleteNormaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNormaBtn.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteNormaBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteNormaBtn.Location = new System.Drawing.Point(198, 141);
            this.DeleteNormaBtn.Name = "DeleteNormaBtn";
            this.DeleteNormaBtn.Size = new System.Drawing.Size(144, 34);
            this.DeleteNormaBtn.TabIndex = 3;
            this.DeleteNormaBtn.Text = "Eliminar Norma";
            this.DeleteNormaBtn.UseVisualStyleBackColor = false;
            this.DeleteNormaBtn.Click += new System.EventHandler(this.DeleteNormaBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione";
            // 
            // NormaList
            // 
            this.NormaList.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormaList.FormattingEnabled = true;
            this.NormaList.Location = new System.Drawing.Point(34, 90);
            this.NormaList.Name = "NormaList";
            this.NormaList.Size = new System.Drawing.Size(511, 26);
            this.NormaList.TabIndex = 1;
            this.NormaList.SelectedIndexChanged += new System.EventHandler(this.NormaList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eliminar Norma";
            // 
            // DeleteNorma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(593, 214);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteNorma";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteNorma";
            this.Load += new System.EventHandler(this.DeleteNorma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Button DeleteNormaBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NormaList;
        private System.Windows.Forms.Label label1;
    }
}