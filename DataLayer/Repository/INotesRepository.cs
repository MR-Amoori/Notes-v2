using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    internal interface INotesRepository
    {
        List<Note_TB> GetNotes();
        Note_TB GetNoteById(int id);
        int GetLastId();
        bool Insert(Note_TB note);
        bool Update(Note_TB note);
        bool Delete(Note_TB note);
        bool Delete(int id);
    }
}
