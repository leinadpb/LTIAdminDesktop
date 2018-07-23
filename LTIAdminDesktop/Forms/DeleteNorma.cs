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
    public partial class DeleteNorma : Form
    {
        private LTIContext _context;

        public DeleteNorma(LTIContext ctx)
        {
            InitializeComponent();
            _context = ctx;
        }

        private void DeleteNorma_Load(object sender, EventArgs e)
        {
            var normas = _context.Normas.Select(n => n).ToList();
            normas.Insert(0, new Normas { NormaId = -1, NormaContent = "Seleccione ---", CreatedBy = "ADMIN" });

            NormaList.ValueMember = "NormaId";
            NormaList.DisplayMember = "NormaContent";
            NormaList.DataSource = normas;

            DeleteNormaBtn.Enabled = false;
        }

        private void NormaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedIndex > 0)
            {
                SetFieldsBehaviour(true);
                

            }
            else
            {
                SetFieldsBehaviour(false);
            }
        }
        private void SetFieldsBehaviour(bool v)
        {
            DeleteNormaBtn.Enabled = v;
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }

        private void DeleteNormaBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("¿Está seguro que desea eliminar esta norma de uso?", "LTI Administration", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmation == DialogResult.Yes)
            {

                int id = Int32.Parse(NormaList.SelectedValue.ToString());
                Normas norm = _context.Normas.Where(n => n.NormaId == id).FirstOrDefault();
                _context.Normas.Remove(norm);
                _context.SaveChanges();
                MessageBox.Show("La norma se ha eliminado con éxito.", "LTI Administration");
                this.Close();
            }
        }
    }
}
