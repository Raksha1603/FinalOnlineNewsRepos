import { Component, OnInit } from '@angular/core';
import { NewsCategory } from 'src/app/Interface/news-category';
import { NewsCatServiceService } from 'src/app/Service/news-cat-service.service';
import { NewscatFormComponent } from '../newscat-form/newscat-form.component';

@Component({
  selector: 'app-newscat-detail',
  templateUrl: './newscat-detail.component.html',
  styleUrls: ['./newscat-detail.component.css']
})
export class NewscatDetailComponent implements OnInit {

  constructor(public service : NewsCatServiceService) { }

  ngOnInit(): void {
    this.service.refreshList();
  }

  populateForm(pd : NewsCategory){
    this.service.formdata = Object.assign({},pd);
  }
  onDelete(pd : NewsCategory)
  {
    this.populateForm(pd);
    this.service.deletenews(pd.CategoryID).subscribe(res =>{
      this.service.formdata = new NewsCategory();
      this.service.refreshList();
    }
      )
  }
    
}
