import { HttpParams } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Show } from '../models/show';
import { ShowService } from '../services/show.service';

@Component({
  selector: 'app-show-list',
  templateUrl: './show-list.component.html',
  styleUrls: ['./show-list.component.scss']
})
export class ShowListComponent implements OnInit {
  currentPage: number;
  pageSize: number;
  totalCount: number;
  totalPages: number;
  searchKeyword: string = '';
  show: Show[];
  constructor(private showService: ShowService) { }

  ngOnInit(): void {
    this.getShow();
  }

  getShow(params?: HttpParams){
    this.showService.getShow(params).subscribe(
      data=>{
        this.show = data.body.payload;
      });
  }

  loadData() {
    const params = new HttpParams()
      .set('pageNumber', this.currentPage.toString())
      .set('pageSize', this.pageSize.toString())
      .set('searchQuery', this.searchKeyword);

    this.getShow(params);
  }

  loadMore(){
  }

}
