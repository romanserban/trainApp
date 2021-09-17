import { Component, OnInit, Output,EventEmitter } from '@angular/core';


@Component({
  selector: 'app-calendar',
  templateUrl: './calendar.component.html',
  styleUrls: ['./calendar.component.css']
})
export class CalendarComponent implements OnInit {
  day: any;
  @Output() dayWeek = new EventEmitter<string>();
  constructor() { }

  ngOnInit(): void {
  }

  submit() {
    var d = new Date(this.day)
    var weekday = new Array(7);
    weekday[0] = "Sunday";
    weekday[1] = "Monday";
    weekday[2] = "Tuesday";
    weekday[3] = "Wednesday";
    weekday[4] = "Thursday";
    weekday[5] = "Friday";
    weekday[6] = "Saturday";

    var n = weekday[d.getDay()];
    this.dayWeek.emit(n);

  }


}
