import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router'
import { NewscatDetailComponent } from './Component/newscat-detail/newscat-detail.component';
import { NewscatFormComponent } from './Component/newscat-form/newscat-form.component';


const routes: Routes = [
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})


export class AppRoutingModule { }

