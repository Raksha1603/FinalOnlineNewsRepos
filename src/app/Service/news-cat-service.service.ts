import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';
import { NewsCategory } from '../Interface/news-category';

@Injectable({
  providedIn: 'root'
})
export class NewsCatServiceService {

  constructor(private http : HttpClient) { }
  readonly baseurl = "https://localhost:44364/api/NewsCategory"
  formdata: NewsCategory = new NewsCategory();
  list : NewsCategory[];
  postnews()
  {
    return this.http.post(this.baseurl, this.formdata);
  }

  putnews() {
    return this.http.put(this.baseurl+'/'+this.formdata.CategoryID,this.formdata);
  }
  deletenews(id: number) {
    return this.http.delete(this.baseurl+'/'+this.formdata.CategoryID);
  }

  refreshList() {
    this.http.get(this.baseurl)
      .toPromise()
      .then(res =>this.list = res as NewsCategory[]);
  }
}