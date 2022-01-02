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
            using (UnitOfWork db=new UnitOfWork())
            {
                dgvNotes.DataSource = db.NotesRepository.GetNotes();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

            if (RtlMessageBox.Show("آیا از بستن نرم افزار مطمئن هستید؟","توجه",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

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
            toolStrip1.BackColor = Color.SandyBrown;
            dgvNotes.BackgroundColor = Color.NavajoWhite;
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
    }
}
