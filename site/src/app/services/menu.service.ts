import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/internal/Observable';
import { Menu } from '../models/Menu';

const url = 'https://localhost:7058/v1/Menu';

@Injectable({
  providedIn: 'root'
})
export class MenuService {

  constructor(private httpClient: HttpClient) { }

  listar(): Observable<Menu[]> {
    return this.httpClient.get<Menu[]>(url);
  }
}
