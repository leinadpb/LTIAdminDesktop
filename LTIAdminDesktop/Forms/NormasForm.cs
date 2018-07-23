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
    public partial class NormasForm : Form
    {
        private LTIContext _context;
        string[] columns = { "No.", "Norma", "Creada por"};
        public NormasForm(LTIContext ctx)
        {
            InitializeComponent();
            _context = ctx;
        }

        private void NormasForm_Load(object sender, EventArgs e)
        {
            PopulatList();
        }

        private void PopulatList()
        {
            var normas = _context.Normas.Select(n => n);
            int num = 1;
            NormasList.Columns.Clear();
            for(int i = 0; i < columns.Length; i++)
            {
                NormasList.Columns.Add(columns[i], columns[i]);
            }
            
            foreach(Normas norm in normas)
            {
                NormasList.Rows.Add(num.ToString(), norm.NormaContent, norm.CreatedBy);
                num++;
            }
        }

        private void AddNorma_Click(object sender, EventArgs e)
        {
            AddNorma ANorma = new AddNorma(_context);
            ANorma.ShowDialog();
            PopulatList();
        }

        private void ModifyNorma_Click(object sender, EventArgs e)
        {
            ModifyNorma MNorma = new ModifyNorma(_context);
            MNorma.ShowDialog();
            PopulatList();
        }

        private void DeleteNorma_Click(object sender, EventArgs e)
        {
            DeleteNorma DNorma = new DeleteNorma(_context);
            DNorma.ShowDialog();
            PopulatList();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
