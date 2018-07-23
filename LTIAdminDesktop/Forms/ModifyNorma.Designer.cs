namespace LTIAdminDesktop.Forms
{
    partial class ModifyNorma
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
            this.label3 = new System.Windows.Forms.Label();
            this.Content = new System.Windows.Forms.TextBox();
            this.CloseForm = new System.Windows.Forms.Button();
            this.SaveChanges = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NormaList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreatedBy = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CreatedBy);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Content);
            this.panel1.Controls.Add(this.CloseForm);
            this.panel1.Controls.Add(this.SaveChanges);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NormaList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 379);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contenido";
            // 
            // Content
            // 
            this.Content.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Content.Location = new System.Drawing.Point(64, 166);
            this.Content.Multiline = true;
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(438, 72);
            this.Content.TabIndex = 5;
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
            // SaveChanges
            // 
            this.SaveChanges.BackColor = System.Drawing.Color.Brown;
            this.SaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChanges.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveChanges.ForeColor = System.Drawing.Color.White;
            this.SaveChanges.Location = new System.Drawing.Point(416, 329);
            this.SaveChanges.Name = "SaveChanges";
            this.SaveChanges.Size = new System.Drawing.Size(144, 34);
            this.SaveChanges.TabIndex = 3;
            this.SaveChanges.Text = "Guardar cambios";
            this.SaveChanges.UseVisualStyleBackColor = false;
            this.SaveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione";
            // 
            // NormaList
            // 
            this.NormaList.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NormaList.FormattingEnabled = true;
            this.NormaList.Location = new System.Drawing.Point(64, 90);
            this.NormaList.Name = "NormaList";
            this.NormaList.Size = new System.Drawing.Size(438, 26);
            this.NormaList.TabIndex = 1;
            this.NormaList.SelectedIndexChanged += new System.EventHandler(this.NormaList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificar Norma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Creada por";
            // 
            // CreatedBy
            // 
            this.CreatedBy.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatedBy.Location = new System.Drawing.Point(64, 271);
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Size = new System.Drawing.Size(438, 23);
            this.CreatedBy.TabIndex = 8;
            // 
            // ModifyNorma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(599, 403);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyNorma";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifyNorma";
            this.Load += new System.EventHandler(this.ModifyNorma_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Content;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Button SaveChanges;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NormaList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CreatedBy;
        private System.Windows.Forms.Label label4;
    }
}