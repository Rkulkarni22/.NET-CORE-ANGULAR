import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { RouterOutlet } from '@angular/router';
import { error } from 'console';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  template:`<p>{{message}}</p> `
})
export class AppComponent implements OnInit{
  title = 'The Dating App';
  users:any;
  
  message="Inside ngonintit";


  constructor(private http: HttpClient)
  { 
    this.message="Inside constructor"
  }
  ngOnInit() {

    //this.getUsers();
   
  }

  // getUsers()
  // {
  //   this.message="Inside ngonintit";
  //   this.http.get('https://localhost:5002/api/getusers').subscribe(response => {
  //     this.users=response;

  //   },  error=> 
  //   {
  //     console.log(error);
  //   })
  // }

}

