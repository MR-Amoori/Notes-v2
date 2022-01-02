using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class UnitOfWork : IDisposable
    {
        Notes_DBEntities db = new Notes_DBEntities(); //بانک

        private NotesRepository _notesRepository;
        public NotesRepository NotesRepository
        {
            get
            {
                if (_notesRepository == null)
                {
                    _notesRepository = new NotesRepository(db);
                }
                return _notesRepository;
            }
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
