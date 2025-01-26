namespace NotesAppAPI.Controllers
{
    using NotesAppAPI.Models;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using NotesAppAPI.Services.Contracts;

    [ApiController]
    [Route("[controller]")]
    public class NotesController : ControllerBase
    {
        private readonly INotesService notesService;
        public NotesController(INotesService notesService)
        {
            this.notesService = notesService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Notes note)
        {
            Notes noteCreate = await this.notesService.CreateNote(note);

            return Created(nameof(this.Create), noteCreate);
        }

        [HttpGet("{id}")]
        public async Task<Notes> GetNote(int id)
        {
            Notes noteGet = await this.notesService.GetNote(id);

            return noteGet;
        }

        [HttpGet]
        public async Task<IEnumerable<Notes>> GetNotes()
        {
            IEnumerable<Notes> noteGetAll = await this.notesService.GetNotes();

            return noteGetAll;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, Notes note)
        {
            await this.notesService.EditNote(id, note);

            return Ok(new { message = "Note updated successfully" });
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await this.notesService.DeleteNote(id);

            return Ok(new { message = "Note deleted successfully" });
        }
    }
}
