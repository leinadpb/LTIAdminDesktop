using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTIAdminDesktop.Models;

namespace LTIAdminDesktop.Forms
{
    public partial class AddNorma : Form
    {
        private LTIContext _context;
        String displayName = System.DirectoryServices.AccountManagement.UserPrincipal.Current.DisplayName;

        public AddNorma(LTIContext ctx)
        {
            InitializeComponent();
            _context = ctx;
        }

        private void AddNorma_Load(object sender, EventArgs e)
        {
            CreatedBy.Text = displayName;
            CreatedBy.Enabled = false;
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            if(Content.Text.Equals("") || CreatedBy.Text.Equals(""))
            {
                MessageBox.Show("Por favor, llene los campos obligatorios, marcados con un *.");
            }
            else
            {
                Normas norm = new Normas();
                norm.CreatedBy = displayName;
                norm.NormaContent = Content.Text;
                _context.Normas.Add(norm);
                _context.SaveChanges();
                MessageBox.Show("La norma de uso ha sido agregada con éxito.");
                this.Close();
            }
        }
    }
}
