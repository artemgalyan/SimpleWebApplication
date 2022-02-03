import {Component, Inject} from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
  
  public people: IPerson[] = [];
  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<IPerson[]>(baseUrl + 'person').subscribe(result => {
      this.people = result; console.log(result);
    }, error => console.error(error));
  }
}

interface IPerson {
  phoneNumber: string;
  name: string;
  id: number;
}
