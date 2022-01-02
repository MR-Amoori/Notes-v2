using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class NotesRepository : INotesRepository
    {
        Notes_DBEntities db;
        public NotesRepository(Notes_DBEntities Context)
        {
            db = Context;
        }

        /***********************/

        public List<Note_TB> GetNotes()
        {
            return db.Note_TB.ToList();
        }

        public Note_TB GetNoteById(int id)
        {
            return db.Note_TB.Find(id);
        }

        public bool Insert(Note_TB note)
        {
            try
            {
                db.Note_TB.Add(note);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Update(Note_TB note)
        {
            try
            {
                db.Entry(note).State = EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int noteId)
        {
            try
            {
                var Note = GetNoteById(noteId);
                Delete(Note);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int GetLastId()
        {
            return int.Parse(db.Note_TB.Max(n => n.ID).ToString());
        }

        public bool Delete(Note_TB note)
        {
            try
            {
                db.Entry(note).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
