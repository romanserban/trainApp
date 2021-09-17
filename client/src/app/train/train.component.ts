import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-train',
  templateUrl: './train.component.html',
  styleUrls: ['./train.component.css']
})
export class TrainComponent implements OnInit {
  id :any
  train:any;
  constructor(private http: HttpClient) {

  }

  ngOnInit(): void {
    
  }
  
  
}
