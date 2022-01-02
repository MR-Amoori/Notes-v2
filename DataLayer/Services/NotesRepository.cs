using System;
using System.Collections.Generic;
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
    }
}
