import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { groceryItem } from '../models/item.model';

@Injectable({
  providedIn: 'root'
})
export class ServicesService {

  private path = environment.apiUrl;

  constructor(private httpClient: HttpClient) { }

  getAllItems(): Observable<any> {
    return this.httpClient.get<any[]>(this.path + "/GroceryItem/GetGroceryItems");
  }

  editItem(item: groceryItem): any {
    const header = new HttpHeaders().set('Content-type', 'application/json');

    return this.httpClient.put(this.path + "/GroceryItem/Put", JSON.stringify(item), { headers: header })
  }

  createNewItem(item : groceryItem): any {
    const header = new HttpHeaders().set('Content-type', 'application/json');

    return this.httpClient.post(this.path + "/GroceryItem/Post", JSON.stringify(item), { headers: header })
  }

  deleteItem(item: groceryItem): any {
    return this.httpClient.delete(this.path + "/GroceryItem/Delete/" + item.itemId)
  }

}