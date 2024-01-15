import {Component, OnInit} from '@angular/core';
import { CommonModule } from '@angular/common';
import {Router, RouterOutlet} from '@angular/router';
import {LoginComponent} from "./components/login/login.component";
import {NavbarComponent} from "./navbar/navbar.component";
import {MyAuthService} from "./services/MyAuth";
import { VetCardComponent } from './vet-card/vet-card.component';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, RouterOutlet, LoginComponent, NavbarComponent, VetCardComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
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
