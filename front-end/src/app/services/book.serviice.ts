import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable()
export class BookStoreService {

  apiUrl: string;

  constructor(private http: HttpClient) {
    this.apiUrl = "http://localhost:5000/api";
  }

  getBookList(): Observable<any> {
    return this.http.post(`${this.apiUrl}/bookstore`, {});
  }
}
