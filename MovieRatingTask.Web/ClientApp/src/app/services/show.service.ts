import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { BaseApiService } from './base-api.service';

@Injectable({
  providedIn: 'root'
})
export class ShowService extends BaseApiService  {
  baseUrl: string = environment.baseUrl;
  constructor(http: HttpClient) {
    super(http);
   }

  getShow(params?: HttpParams):Observable<any>{
    return this.get(`${this.baseUrl}shows`, null, params);
  }
}
