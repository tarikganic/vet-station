import {Component, OnInit} from '@angular/core';
import { CommonModule } from '@angular/common';
import {Router, RouterOutlet} from '@angular/router';
import {LoginComponent} from "./components/login/login.component";
import {NavbarComponent} from "./navbar/navbar.component";
import {MyAuthService} from "./services/MyAuth";
import { RegisterComponent } from './components/register/register.component';
import { VetCardComponent } from './vet-card/vet-card.component';
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
 

  }

  test(response:any)
  {
      console.log(response);
  }
}
