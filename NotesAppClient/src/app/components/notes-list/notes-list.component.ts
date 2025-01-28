import { Component, OnInit } from '@angular/core';
import { Note } from 'src/app/models/Note';
import { NoteService } from 'src/app/services/note.service';

@Component({
  selector: 'app-notes-list',
  templateUrl: './notes-list.component.html',
  styleUrls: ['./notes-list.component.css']
})
export class NotesListComponent implements OnInit {
  notes: Note[] = [];
  newNote: Note = { id: 0, title: '', description: '' };

  constructor(private noteService: NoteService) {}

  ngOnInit(): void {
    this.loadNotes();
  }

  loadNotes() {
    this.noteService.getNotes().subscribe((data) => {
      this.notes = data;
    });
  }

  addNotes() {
    if (this.newNote.title && this.newNote.description) {
      this.noteService.addNote(this.newNote).subscribe((note) => {
        this.notes.push(note);
        this.newNote = { id: 0, title: '', description: '' };
      });
    }
  }

  deleteNote(id: number) {
    this.noteService.deleteNote(id).subscribe(() => {
      this.notes = this.notes.filter((note) => note.id !== id);
    });
  }
}
