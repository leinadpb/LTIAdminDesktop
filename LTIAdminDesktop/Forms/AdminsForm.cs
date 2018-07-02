using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LTIAdminDesktop.Forms;
using LTIAdminDesktop.Models;

namespace LTIAdminDesktop.Forms
{
    public partial class AdminsForm : Form
    {
        private LTIContext _context;
        private string[] columns = { "ID", "Nombre", "Dominio", "Fecha Registro" };

        public AdminsForm(LTIContext ctx)
        {
            InitializeComponent();
            _context = ctx;
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopulateList()
        {
            var admins = _context.Admins.OrderBy(a => a.Teacher.DisplayName).Select(a => a);
            AdminList.Columns.Clear();
            for (int i = 0; i < columns.Length; i++)
            {
                AdminList.Columns.Add(columns[i], columns[i]);
            }
            foreach (var adm in admins)
            {
                //MessageBox.Show(adm.TeacherId.ToString() + ": " + adm.AdminId.ToString());
                Teachers te = _context.Teachers.Where(t => t.TeacherId == adm.TeacherId).FirstOrDefault();
                if(te != null)
                {
                    AdminList.Rows.Add(te.LoginName, te.DisplayName, te.Domain, te.RegisteredDate);
                }
                
            }
        }

        private void AdminsForm_Load(object sender, EventArgs e)
        {
            PopulateList();

        }

        private void AdminList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddAdmin_Click(object sender, EventArgs e)
        {
            AddAdmin Add = new AddAdmin(_context);
            Add.ShowDialog();
            PopulateList();
        }

        private void DeleteAdmin_Click(object sender, EventArgs e)
        {
            DeleteAdmin Delete = new DeleteAdmin(_context);
            Delete.ShowDialog();
            PopulateList();
        }
    }
}
