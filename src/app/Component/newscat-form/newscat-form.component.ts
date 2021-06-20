import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { NewsCategory } from 'src/app/Interface/news-category';
import { NewsCatServiceService } from 'src/app/Service/news-cat-service.service';

@Component({
  selector: 'app-newscat-form',
  templateUrl: './newscat-form.component.html',
  styleUrls: ['./newscat-form.component.css']
})
export class NewscatFormComponent implements OnInit {
  toastr: any;

  constructor(public service : NewsCatServiceService) { }

  ngOnInit(): void {
    
  }
  resetForm(form: NgForm)
  {
    form.form.reset();
    this.service.formdata = new NewsCategory();
  }
  insertRecord(form : NgForm)
  {
    this.service.postnews().subscribe(
      res=>{
        this.resetForm(form);
        this.service.refreshList();
      },
      err => {console.log(err);}
    );
  }
  updateRecord(form: NgForm)
  {
    this.service.putnews().subscribe(
      res=>{
        this.resetForm(form);
        this.service.refreshList();
      },
      err => {console.log(err);}
    );
  }
}
 
