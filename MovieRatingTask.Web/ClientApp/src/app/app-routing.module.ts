import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MovieListComponent } from './movie-list/movie-list.component';
import { ShowListComponent } from './show-list/show-list.component';

const routes: Routes = [
  {
    path: 'movie',
    component: MovieListComponent
  },
  {
    path: 'show',
    component: ShowListComponent
  },
  {
    path: '**',
    component: MovieListComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }