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
    public partial class ModifyTrimestre : Form
    {
        private LTIContext _context;
        public ModifyTrimestre(LTIContext ctx)
        {
            InitializeComponent();
            _context = ctx;
        }

        private void ModifyTrimestre_Load(object sender, EventArgs e)
        {
            var tris = _context.Trimestres.Select(t => t).ToList();
            tris.Insert(0, new Trimestres { TrimestreId = -1, Name = "Seleccione ---" });

            TrimestreList.DisplayMember = "Name";
            TrimestreList.ValueMember = "TrimestreID";
            //ListTrimestres.Items.Add(0, new Trimestres { } );
            TrimestreList.DataSource = tris;

            SetDefaultFields(false);   
        }

        private void SetDefaultFields(bool val)
        {
            tbName.Enabled = val;
            tbsDate.Enabled = val;
            tbeDate.Enabled = val;
            tbActive.Enabled = val;
            SaveChanges.Enabled = val;
        }

        private void TrimestreList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if(cb.SelectedIndex > 0)
            {
                SetDefaultFields(true);

                int id = Int32.Parse(TrimestreList.SelectedValue.ToString());
                Trimestres tr = _context.Trimestres.Where(t => t.TrimestreId == id).FirstOrDefault();
                if(tr != null)
                {
                    tbName.Text = tr.Name;
                    tbsDate.Value = tr.StartDate;
                    tbeDate.Value = tr.EndDate;
                    if(tr.Active == 1)
                    {
                        tbActive.Checked = true;
                    }
                    else
                    {
                        tbActive.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("El trimestre no existe.");
                }
            }
            else
            {
                SetDefaultFields(false);
            }
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(TrimestreList.SelectedValue.ToString());
            Trimestres tr = _context.Trimestres.Where(t => t.TrimestreId == id).FirstOrDefault();
            if (tbActive.Checked)
            {
                tr.Active = 1;
            }
            else
            {
                tr.Active = 0;
            }
            tr.Name = tbName.Text;
            tr.StartDate = tbsDate.Value;
            tr.EndDate = tbeDate.Value;

            _context.SaveChanges();

            MessageBox.Show("Se han guardado los cambios.");

            this.Close();

        }
    }
}
