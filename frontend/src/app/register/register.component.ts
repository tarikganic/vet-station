import { Component } from '@angular/core';
import {faApple, faFacebook, faGoogle, faMicrosoft} from "@fortawesome/free-brands-svg-icons";
import {FaIconComponent} from "@fortawesome/angular-fontawesome";

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [
    FaIconComponent
  ],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent {

    protected readonly faApple = faApple;
    protected readonly faFacebook = faFacebook;
    protected readonly faGmail = faGoogle;
    protected readonly faMicrosoft = faMicrosoft;
}
