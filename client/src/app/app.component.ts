import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'TrainApp';
  trains: any;

  constructor(private http: HttpClient) {

  }
  ngOnInit() {
    this.getTrains();
  }
  getTrains() {
    this.http.get('https://localhost:5001/api/trains').subscribe(reponse => {
      this.trains = reponse;
    }, error => {
      console.log(error);
    });
  }
}
