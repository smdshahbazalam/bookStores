import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Book } from '../models';

@Injectable()
export class BookStoreService {

  apiUrl: string;

  constructor(private http: HttpClient) {
    this.apiUrl = "http://localhost:2000/api";
  }

  getBookList(): Observable<Book[]> {
    return this.http.get<Book[]>(`${this.apiUrl}/bookstore`);
  }

  searchBook(searchKey: string): Observable<Book[]> {
    return this.http.get<Book[]>(`${this.apiUrl}/bookstore/search/${searchKey}`);
  }
}
