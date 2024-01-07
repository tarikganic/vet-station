import { Component } from '@angular/core';
import {MyAuthService} from "../../services/MyAuth";

@Component({
  selector: 'app-home-page',
  standalone: true,
  imports: [],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.css'
})
export class HomePageComponent {
constructor(public myAuthService:MyAuthService) {
}
}
