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
    public partial class ModifyNorma : Form
    {
        private LTIContext _context;

        public ModifyNorma(LTIContext ctx)
        {
            InitializeComponent();
            _context = ctx;
        }

        private void ModifyNorma_Load(object sender, EventArgs e)
        {
            var normas = _context.Normas.Select(n => n).ToList();
            normas.Insert(0, new Normas { NormaId = -1, NormaContent = "Seleccione ---", CreatedBy = "ADMIN" });

            NormaList.ValueMember = "NormaId";
            NormaList.DisplayMember = "NormaContent";
            NormaList.DataSource = normas;

            SetFieldsBehaviour(false);

        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NormaList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if(cb.SelectedIndex > 0)
            {
                SetFieldsBehaviour(true);
                int id = Int32.Parse(cb.SelectedValue.ToString());
                Normas norm = _context.Normas.Where(n => n.NormaId == id).FirstOrDefault();
                Content.Text = norm.NormaContent;
                CreatedBy.Text = norm.CreatedBy;

            }
            else
            {
                SetFieldsBehaviour(false);
            }
        }

        private void SetFieldsBehaviour(bool v)
        {
            Content.Enabled = v;
            CreatedBy.Enabled = v;
            SaveChanges.Enabled = v;
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(NormaList.SelectedValue.ToString());
            Normas norm = _context.Normas.Where(n => n.NormaId == id).FirstOrDefault();
            norm.NormaContent = Content.Text;
            norm.CreatedBy = CreatedBy.Text;
            _context.SaveChanges();
            MessageBox.Show("Los cambios se han guardado con éxito.");
            this.Close();
        }
    }
}
