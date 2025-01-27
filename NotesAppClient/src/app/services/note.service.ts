import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { Note } from "../models/Note";
import { Observable } from "rxjs";

@Injectable({
    providedIn: 'root',
  })
  export class NoteService {
    private apiUrl = 'https://localhost:5001/api/notes';

    constructor(private http: HttpClient) {}

     getNotes(): Observable<Note[]> {
        return this.http.get<Note[]>(this.apiUrl);
      }
    
      addNote(note: Note): Observable<Note> {
        return this.http.post<Note>(this.apiUrl, note);
      }
    
      deleteNote(id: number): Observable<void> {
        return this.http.delete<void>(`${this.apiUrl}/${id}`);
      }
  }