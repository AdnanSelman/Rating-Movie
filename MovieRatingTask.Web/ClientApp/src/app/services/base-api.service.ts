import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams, HttpEvent } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export abstract class BaseApiService {
  constructor(readonly http: HttpClient) { }

  public get<TResponse>(url: string, headers?: HttpHeaders, params?: HttpParams): Observable<HttpEvent<TResponse>> {
    return this.http.get<TResponse>(url, { headers, params, observe: 'response' });
  }

  public post<TResponse>(
    url: string,
    body: any,
    headers?: HttpHeaders,
  ): Observable<TResponse> {
    return this.http.post<TResponse>(url, body, { headers });
  }

  public put<TResponse>(
    url: string,
    body?: any,
    headers?: HttpHeaders,
  ): Observable<TResponse> {
    return this.http.put<TResponse>(url, body, { headers });
  }

  public delete<TResponse>(
    url: string,
    headers?: HttpHeaders,
  ): Observable<TResponse> {
    return this.http.delete<TResponse>(url, { headers });
  }
}