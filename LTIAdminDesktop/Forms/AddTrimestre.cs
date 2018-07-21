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
    public partial class AddTrimestre : Form
    {
        private LTIContext _context;
        public AddTrimestre(LTIContext ctx)
        {
            InitializeComponent();
            _context = ctx;
        }

        private void AddTrimestre_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(tbeDate.Value > tbsDate.Value)
            {
                //okey...
                string name = tbsDate.Value.ToString("MMMM") + " - " + tbeDate.Value.ToString("MMMM") + "  " + tbeDate.Value.Year.ToString();
                int active = 1;

                if (tbActive.Checked)
                    active = 1;
                else
                    active = 0;

                Trimestres tri = new Trimestres() {
                    Name = name,
                    StartDate = tbsDate.Value,
                    EndDate = tbeDate.Value,
                    Active = active
                };
                //MessageBox.Show(name);
                _context.Trimestres.Add(tri);

                _context.SaveChanges();

                MessageBox.Show("El trimestre ha sido añadido con éxito.");

                this.Close();
            }
            else
            {
                MessageBox.Show("La fecha de término debe ser mayor a la fecha de inicio.");
            }
            
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
