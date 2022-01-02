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
        public int ID = 0;
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
                if (ID == 0) // Insert
                {
                    Note_TB note = new Note_TB();
                    note.ID = LastID + 1;
                    note.Titel = txtTitel.Text;
                    note.Note = txtNote.Text;
                    db.NotesRepository.Insert(note);
                    db.Saves();
                    DialogResult = DialogResult.OK;
                }

                else // Update
                {
                    Note_TB note = new Note_TB();
                    note.ID = ID;
                    note.Titel = txtTitel.Text;
                    note.Note = txtNote.Text;
                    db.NotesRepository.Update(note);
                    db.Saves();
                    DialogResult = DialogResult.OK;
                }
            }
        }

        private void frm_AddOrEditNote_Load(object sender, EventArgs e)
        {
            if (ID!=0)
            {
                panel1.TabIndex = 0;
                using (UnitOfWork db = new UnitOfWork())
                {
                    var note = db.NotesRepository.GetNoteById(ID);
                    txtNote.Text = note.Note;
                    txtTitel.Text = note.Titel;
                }
            }

        }
    }
}
