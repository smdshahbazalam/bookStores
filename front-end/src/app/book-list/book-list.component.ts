import { Component, OnInit } from '@angular/core';
import { Book } from '../models';

import { BookStoreService } from '../services/book.serviice';

@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css']
})
export class BookListComponent implements OnInit {

  bookList: Book[] = [];
  constructor(private bookStoreService: BookStoreService ) { }

  ngOnInit(): void {
    this.bookStoreService.getBookList().subscribe(_ => {
      this.bookList = _;
    });
  }

}
