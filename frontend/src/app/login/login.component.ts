import { Component } from '@angular/core';
import {FaIconComponent} from "@fortawesome/angular-fontawesome";
import {faGoogle} from "@fortawesome/free-brands-svg-icons";
import {faMicrosoft} from "@fortawesome/free-brands-svg-icons";
import {faFacebook} from "@fortawesome/free-brands-svg-icons";
import {faApple} from "@fortawesome/free-brands-svg-icons";

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [ FaIconComponent],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {
faGmail = faGoogle
  faMicrosoft = faMicrosoft
  faFacebook= faFacebook
  faApple = faApple
}
