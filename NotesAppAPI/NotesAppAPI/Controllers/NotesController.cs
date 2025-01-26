namespace NotesAppAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;
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
    }
}
