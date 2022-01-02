using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;

namespace Notes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvNotes.AutoGenerateColumns = false;
            BindGrid();
        }

        private void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvNotes.DataSource = db.NotesRepository.GetNotes();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

        }

        private void dgvNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_ShowNote frm=new frm_ShowNote();
            frm.ID = (int)dgvNotes.CurrentRow.Cells[0].Value;
            frm.ShowDialog();
        }
      
        /**********************************/
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            dgvNotes.AutoGenerateColumns = false;
            BindGrid();
        }

        void Them_Blue()
        {
            groupPanel1.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Default;
            toolStrip1.BackColor = Color.LightBlue;
            dgvNotes.BackgroundColor = Color.SteelBlue;
        }

        void Them_Orange()
        {
            groupPanel1.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Orange;
            toolStrip1.BackColor = Color.PeachPuff;
            dgvNotes.BackgroundColor = Color.DarkOrange;
        }
        void Them_Magenta()
        {
            groupPanel1.ColorTable = DevComponents.DotNetBar.Controls.ePanelColorTable.Magenta;
            toolStrip1.BackColor = Color.Orchid;
            dgvNotes.BackgroundColor = Color.Thistle;
        }

        private void آبیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Them_Blue();
        }

        private void نلرنجیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Them_Orange();
        }

        private void صورتیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Them_Magenta();
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            Forms.frm_AddOrEditNote frm = new Forms.frm_AddOrEditNote();
            frm.Text = "افزودن یادداشت";
            using (UnitOfWork db=new UnitOfWork())
            {
                frm.LastID =db.NotesRepository.GetLastId();
            }
            
                if (frm.ShowDialog()==DialogResult.OK)
            {
                BindGrid();
            }
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RtlMessageBox.Show("آیا از بستن نرم افزار مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_DeleteNote_Click(object sender, EventArgs e)
        {
            string nameNote=dgvNotes.CurrentRow.Cells[1].Value.ToString();
            int idNote = int.Parse(dgvNotes.CurrentRow.Cells[0].Value.ToString());
            if (RtlMessageBox.Show($"آیا از حذف {nameNote} مطمعن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (UnitOfWork db=new UnitOfWork())
                {
                    db.NotesRepository.Delete(idNote);
                    db.Saves();
                    BindGrid();
                }
            }
        }

        private void btn_EditNote_Click(object sender, EventArgs e)
        {
            Forms.frm_AddOrEditNote frm = new Forms.frm_AddOrEditNote();
            frm.Text = "ویرایش یادداشت";
            frm.ID = int.Parse(dgvNotes.CurrentRow.Cells[0].Value.ToString());
            if (frm.ShowDialog()==DialogResult.OK)
            {
                BindGrid();
            }
        }
    }
}
