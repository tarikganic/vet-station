import {Component, OnInit} from '@angular/core';
import { CommonModule } from '@angular/common';
import {Router, RouterOutlet} from '@angular/router';
import {LoginComponent} from "./components/login/login.component";
import {MyAuthService} from "./services/MyAuth";
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, LoginComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements  OnInit{
  title = 'frontend';

  constructor(public myAuthToken: MyAuthService,private router:Router) {

  }

  ngOnInit() {
    if (this.myAuthToken.IsLogged())
      this.router.navigate(['home-page']);

  }

  test(response:any)
  {
      console.log(response);
  }
}
