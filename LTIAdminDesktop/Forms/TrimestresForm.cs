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
    public partial class TrimestresForm : Form
    {
        private LTIContext _context;
        private string[] columns = { "Trimestre", "Fecha Inicio", "Fecha Fin", "Activo"};

        public TrimestresForm(LTIContext ctx)
        {
            InitializeComponent();
            _context = ctx;
        }

        private void TrimestresForm_Load(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void PopulateList()
        {
            var tris = _context.Trimestres.OrderBy(t => t.TrimestreId).Select(t => t);
            TrimestresList.Columns.Clear();
            for (int i = 0; i < columns.Length; i++)
            {
                TrimestresList.Columns.Add(columns[i], columns[i]);
            }
            string active = "";
            foreach (var t in tris)
            {
                active = "SI";
                if (t.Active == 0) active = "NO";
                TrimestresList.Rows.Add(t.Name, t.StartDate, t.EndDate, active);

            }
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyTrimestre_Click(object sender, EventArgs e)
        {
            ModifyTrimestre MForm = new ModifyTrimestre(_context);
            MForm.ShowDialog();
            PopulateList();
        }

        private void AddTrimestre_Click(object sender, EventArgs e)
        {
            AddTrimestre AForm = new AddTrimestre(_context);
            AForm.ShowDialog();
            PopulateList();
        }
    }
}
