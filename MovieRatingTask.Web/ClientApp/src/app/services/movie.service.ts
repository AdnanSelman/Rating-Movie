import { HttpParams, HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { tap } from 'rxjs/operators';
import { Movie } from '../models/movie';
import { BaseApiService } from './base-api.service';

@Injectable({
  providedIn: 'root'
})
export class MovieService extends BaseApiService {
 baseUrl: string = environment.baseUrl;

  constructor(http: HttpClient) {
    super(http);
   }

  getMovie(params?: HttpParams):Observable<any>{
    return this.get(`${this.baseUrl}movies`, null, params);
  }
}
