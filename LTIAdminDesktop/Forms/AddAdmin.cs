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
    public partial class AddAdmin : Form
    {
        private LTIContext _context;

        public AddAdmin(LTIContext ctx)
        {
            InitializeComponent();
            _context = ctx;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {
            var admins = _context.Teachers.OrderBy(t => t.DisplayName).Select(t => t);

            TeacherList.DisplayMember = "DisplayName";
            TeacherList.ValueMember = "TeacherID";
            TeacherList.DataSource = admins.ToArray();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(TeacherList.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un administrador.");
            }
            else
            {
                
                int TeacherID = Int32.Parse(TeacherList.SelectedValue.ToString());
                var loadAdmins = _context.Admins.Where(a => a.TeacherId == TeacherID);
                if (loadAdmins.ToList().Count > 0)
                {
                    MessageBox.Show("Este administrador ya existe.");
                    return;
                }
                Teachers Teach = _context.Teachers.Where(t => t.TeacherId == TeacherID).FirstOrDefault();
                Admins NewAdmin = new Admins() {
                    Teacher = Teach,
                    TeacherId = Teach.TeacherId
                };
                _context.Admins.Add(NewAdmin);
                try
                {
                    _context.SaveChanges();
                    MessageBox.Show("Administrador agregado exitosamente.");
                    this.Close();
                }
                catch (Exception exp)
                {
                    Console.WriteLine("Error: " + exp.Message);
                }
            }
        }
    }
}
