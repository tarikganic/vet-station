import {Component, OnInit} from '@angular/core';
import { CommonModule } from '@angular/common';
import {Router, RouterOutlet} from '@angular/router';
import {LoginComponent} from "./components/login/login.component";
import {NavbarComponent} from "./navbar/navbar.component";
import {MyAuthService} from "./services/MyAuth";
import { VetCardComponent } from './components/vet-card/vet-card.component';
import { RegisterComponent } from "./components/register/register.component";
@Component({
    selector: 'app-root',
    standalone: true,
    templateUrl: './app.component.html',
    styleUrl: './app.component.css',
    imports: [CommonModule, RouterOutlet, LoginComponent, NavbarComponent, VetCardComponent, RegisterComponent]
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
