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
    public partial class DeleteAdmin : Form
    {
        private LTIContext _context;
        public DeleteAdmin(LTIContext ctx)
        {
            InitializeComponent();
            _context = ctx;
        }

        private void DeleteAdmin_Load(object sender, EventArgs e)
        {
            var admins = _context.Admins.OrderBy(a => a.Teacher.DisplayName).Select(a => a);
            List<Teachers> adms = new List<Teachers>();
            foreach(var a in admins)
            {
                if(a.Teacher != null)
                {
                    adms.Add(a.Teacher);
                }
                
            }
            TeacherList.DisplayMember = "DisplayName";
            TeacherList.ValueMember = "TeacherID";
            TeacherList.DataSource = adms;
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (TeacherList.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un administrador.");
            }
            else
            {
                int AdminID = Int32.Parse(TeacherList.SelectedValue.ToString());
                Admins adm = _context.Admins.Where(a => a.TeacherId == AdminID).FirstOrDefault();
                _context.Admins.Remove(adm);
                try
                {
                    _context.SaveChanges();
                    MessageBox.Show("Administrador eliminado exitosamente.");
                    this.Close();
                }
                catch (Exception exp)
                {
                    Console.WriteLine("Error: " +exp.Message);
                }
            }
        }
    }
}
