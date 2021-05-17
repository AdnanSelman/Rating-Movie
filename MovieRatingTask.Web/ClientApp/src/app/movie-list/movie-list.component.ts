import { Component, OnInit } from '@angular/core';
import { MovieService } from '../services/movie.service';
import { Movie } from '../models/movie';
import { HttpParams } from '@angular/common/http';

@Component({
  selector: 'app-movie-list',
  templateUrl: './movie-list.component.html',
  styleUrls: ['./movie-list.component.scss']
})
export class MovieListComponent implements OnInit {
  currentPage: number;
  pageSize: number;
  totalCount: number;
  totalPages: number;
  searchKeyword: string = '';
  movie: Movie[];
  showRateMovie: boolean = false;
  constructor(private movieService: MovieService) { }

  ngOnInit(): void {
    this.getMovie();
  }

  getMovie(params?: HttpParams){
    this.movieService.getMovie(params).subscribe(
      data=>{
        this.movie = data.body.payload;
        console.log(this.movie)
      });
  }

  toggleShowRatemovie(){
    this.showRateMovie = !this.showRateMovie;
  }

  loadData() {
    const params = new HttpParams()
      .set('pageNumber', this.currentPage.toString())
      .set('pageSize', this.pageSize.toString())
      .set('searchQuery', this.searchKeyword);

    this.getMovie(params);
  }

  loadMore(){
  }

}
