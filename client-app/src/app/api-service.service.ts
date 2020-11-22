import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Job } from './model/job';
import { RoomSummary } from './model/room-summary';

@Injectable({
  providedIn: 'root'
})
export class ApiServiceService {
  private url: string = 'https://localhost:44352/api/main';

  httpOptions = {
    headers: new HttpHeaders({'Content-Type': 'application/json'})
  };

  constructor(private http: HttpClient) { }

  getJobs() : Observable<any> {
    return this.http.get<Job[]>(this.url)
  }

  getStats() : Observable<any> {
    return this.http.get<RoomSummary[]>(`${this.url}/stats`);
  }

  markAsComplete(id: string): Observable<any> {
    let obj = { id: id };
    return this.http.put(`${this.url}/${id}`, obj, this.httpOptions);
  }
}
