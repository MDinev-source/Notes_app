namespace NotesAppAPI.Services.Contracts
{
    using NotesAppAPI.Models;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    public interface INotesService
    {
        Task<IEnumerable<Notes>> GetNotes();
        Task<Notes> GetNote(int id);
        Task<Notes> CreateNote(Notes note);
        Task EditNote(int id, Notes note);
        Task DeleteNote(int id);
    }
}
