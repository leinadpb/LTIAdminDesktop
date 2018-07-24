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
        string[] columns = { "No.", "Norma", "Creada por", "NormaID"};
        public NormasForm(LTIContext ctx)
        {
            InitializeComponent();
            _context = ctx;
        }

        private void NormasForm_Load(object sender, EventArgs e)
        {
            PopulatList();
            NormaID.Text = "-1";
            NormaID.Visible = false;
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
                NormasList.Rows.Add(num.ToString(), norm.NormaContent, norm.CreatedBy, norm.NormaId);
                num++;
            }
            NormasList.Columns["NormaID"].Visible = false;
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
            int id = -1;
            if (!NormaID.Equals("-1") && NormaID != null) {
                id = Int32.Parse(NormaID.Text);
                Normas norm = _context.Normas.Where(n => n.NormaId == id).FirstOrDefault();
                if (norm != null)
                {
                    var confirmation = MessageBox.Show("¿Estás seguro/a que quieres eliminar esta nroma de uso: " + norm.NormaContent + "?", "LTI Administration", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == confirmation)
                    {
                        _context.Normas.Remove(norm);
                        _context.SaveChanges();
                        MessageBox.Show("La norma ha sido eliminada exitosamente.", "LTI Administration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PopulatList();
                    }

                }
                else
                {
                    MessageBox.Show("Error: No se pudo obtener la norma seleccionada. Selecione la fila completa haciendo clic en la fila correspondiente de la primera columna (que no tiene nombre de columna).", "LTI Administration", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: No se pudo obtener la norma seleccionada. Selecione la fila completa haciendo clic en la fila correspondiente de la primera columna (que no tiene nombre de columna).", "LTI Administration", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NormasList_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            var row = dgv.SelectedRows;
            foreach(DataGridViewRow r in row)
            {
                int row_id = r.Index;
                string norma_id = NormasList.Rows[row_id].Cells["NormaID"].Value.ToString();
                NormaID.Text = norma_id;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
