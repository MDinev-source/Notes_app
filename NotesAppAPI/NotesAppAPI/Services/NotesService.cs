namespace NotesAppAPI.Services
{
    using NotesAppAPI.Data;
    using NotesAppAPI.Models;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using NotesAppAPI.Services.Contracts;

    public class NotesService : INotesService
    {
        private readonly NotesDbContext data;

        public NotesService(NotesDbContext data)
        {
            this.data = data;
        }

        public Task<Notes> CreateNote(Notes note)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task EditNote(int id, Notes note)
        {
            throw new System.NotImplementedException();
        }

        public Task<Notes> GetNote(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Notes>> GetNotes()
        {
            throw new System.NotImplementedException();
        }
    }
}
