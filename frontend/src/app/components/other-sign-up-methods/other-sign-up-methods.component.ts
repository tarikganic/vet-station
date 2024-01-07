import {Component, Input, OnInit} from '@angular/core';
import {faApple, faFacebook, faGoogle, faMicrosoft} from "@fortawesome/free-brands-svg-icons";
import {FaIconComponent} from "@fortawesome/angular-fontawesome";
import {NgSwitch, NgSwitchCase} from "@angular/common";
import {MyAuthService} from "../../services/MyAuth";
import {Router} from "@angular/router";

@Component({
  selector: 'app-other-sign-up-methods',
  standalone: true,
  imports: [
    FaIconComponent,
    NgSwitchCase,
    NgSwitch
  ],
  templateUrl: './other-sign-up-methods.component.html',
  styleUrl: './other-sign-up-methods.component.css'
})
export class OtherSignUpMethodsComponent implements OnInit{

  constructor(public myAuthService:MyAuthService, private router:Router) {
  }
  ngOnInit() {

  }

  @Input() isLogin:boolean = false;
//Icons
    protected readonly faGmail = faGoogle;
    protected readonly faMicrosoft = faMicrosoft;
    protected readonly faFacebook = faFacebook;
    protected readonly faApple = faApple;
}
