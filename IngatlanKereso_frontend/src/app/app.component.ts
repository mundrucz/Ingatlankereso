import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  public estates?: Estate[];

  constructor(http: HttpClient) {
    http.get<Estate[]>("api/Estates").subscribe(result => {
      this.estates = result;
    }, error => console.error(error));
  }

  title = 'IngatlanKereso_frontend';
}

interface Estate {
  
  userName : string;
}
