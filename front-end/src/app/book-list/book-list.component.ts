import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { Book } from '../models';

import { BookStoreService } from '../services/book.serviice';

@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css']
})
export class BookListComponent implements OnInit {

  searchform: FormGroup = new FormGroup({
    search: new FormControl(''),
  });


  bookList: Book[] = [];

  onSearch(){
    this.bookStoreService.searchBook(this.searchform.value.search).subscribe(_ => {
      this.bookList = _;
    });;
  }

  clearSearch(){
    this.searchform.reset();
    this.loadBookResult();
  }

  loadBookResult(){
    this.bookStoreService.getBookList().subscribe(_ => {
      this.bookList = _;
    });
  }

  trackByFn(item: any) {
    return item.activityFeedRecordId;
  }

  constructor(private bookStoreService: BookStoreService ) { }

  ngOnInit(): void {
   this.loadBookResult();
  }

}
