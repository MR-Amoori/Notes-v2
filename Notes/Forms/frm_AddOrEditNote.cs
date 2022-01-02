using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DataLayer;

namespace Notes.Forms
{
    public partial class frm_AddOrEditNote : Form
    {
        public int ID;
        public int LastID;
        public frm_AddOrEditNote()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                Note_TB note = new Note_TB();
                note.ID = LastID + 1;
                note.Titel = txtTitel.Text;
                note.Note = txtNote.Text;
                db.NotesRepository.Insert(note);
                db.Saves();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
