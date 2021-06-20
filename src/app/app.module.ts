import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { NewscatFormComponent } from './Component/newscat-form/newscat-form.component';
import { NewscatDetailComponent } from './Component/newscat-detail/newscat-detail.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { NewsCatServiceService } from './Service/news-cat-service.service';
import { SubscribersComponent } from './Components/subscribers/subscribers.component';

@NgModule({
  declarations: [
    AppComponent,
    NewscatFormComponent,
    NewscatDetailComponent,
    SubscribersComponent
  ],
  imports: [
    BrowserModule,
    NgbModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,

  ],
  providers: [NewsCatServiceService],
  bootstrap: [AppComponent]
})
export class AppModule { }
