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
    public partial class frm_ShowNote : Form
    {
        public int ID
        {
            get;
            set;
        }
        public int Color
        {
            get;
            set;
        }
        public frm_ShowNote()
        {
            InitializeComponent();
        }

        private void ShowNote_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var note = db.NotesRepository.GetNoteById(ID);
                this.Text = note.Titel;
                textBox1.Text = note.Note;
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
