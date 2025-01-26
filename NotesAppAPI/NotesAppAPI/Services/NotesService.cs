namespace NotesAppAPI.Services
{
    using System.Linq;
    using NotesAppAPI.Data;
    using NotesAppAPI.Models;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    using NotesAppAPI.Services.Contracts;
    using Microsoft.EntityFrameworkCore;

    public class NotesService : INotesService
    {
        private readonly NotesDbContext data;

        public NotesService(NotesDbContext data)
        {
            this.data = data;
        }

        public async Task<Notes> CreateNote(Notes note)
        {
            Notes noteNew = new Notes
            {
                Title = note.Title,
                Description = note.Description
            };

            this.data.Notes.Add(noteNew);

            await this.data.SaveChangesAsync();

            return note;
        }

        public async Task DeleteNote(int id)
        {
            Notes noteDelete = this.data
                .Notes
                .FirstOrDefault(n => n.Id == id);

            this.data.Remove(noteDelete);
            await this.data.SaveChangesAsync();
        }

        public async Task EditNote(int id, Notes note)
        {
            Notes noteEdit = this.data.Notes
                .FirstOrDefault(n => n.Id == id);

            noteEdit.Title = note.Title;
            noteEdit.Description = note.Description;

            await this.data.SaveChangesAsync();
        }

        public async Task<Notes> GetNote(int id)
        {
            Notes noteGet = await this.data.Notes
                .FindAsync(id);

            return noteGet;
        }

        public async Task<IEnumerable<Notes>> GetNotes()
        {
            IEnumerable<Notes> notes = await data.Notes
                .ToListAsync();

            return notes;
        }
    }
}
