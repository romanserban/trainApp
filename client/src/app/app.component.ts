import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'TrainApp';
  id: any;
  day: any;
  trains: any;
  cars: any;
  seats: any;
  trainById: any;
  emptySeats: any;


  constructor(private http: HttpClient) {

  }
  ngOnInit() {
    this.getTrains();
    this.getCars();
    this.getSeats();

  }
  getTrains() {
    this.http.get('https://localhost:5001/api/trains').subscribe(reponse => {
      this.trains = reponse;
    }, error => {
      console.log(error);
    });
  }
  getCars() {
    this.http.get('https://localhost:5001/api/cars').subscribe(reponse => {
      this.cars = reponse;
    }, error => {
      console.log(error);
    });
  }
  getSeats() {
    this.http.get('https://localhost:5001/api/seats').subscribe(reponse => {
      this.seats = reponse;
    }, error => {
      console.log(error);
    });
  }
  dayWeekMode(event: string) {
    this.day = event;
  }
  getTrain(id: any) {
    this.http.get(`https://localhost:5001/api/trains/${id}`).subscribe(reponse => {
      this.trainById = reponse;
    }, error => {
      console.log(error);
    });
  }


}
