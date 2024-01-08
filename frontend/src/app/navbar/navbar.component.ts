import {Component, Input, OnChanges, OnInit, SimpleChanges} from '@angular/core';
import {NgIf} from "@angular/common";
import {FaIconComponent} from "@fortawesome/angular-fontawesome";
import {faHome, faEnvelope, faShop, faUser, faGear} from "@fortawesome/free-solid-svg-icons";
import {MyAuthService} from "../services/MyAuth";
import {ChangeDetection} from "@angular/cli/lib/config/workspace-schema";

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [
    NgIf,
    FaIconComponent
  ],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent implements OnChanges{

  @Input() public isLogged: boolean = false;
  constructor(public myAuthService: MyAuthService) {
  }
  ngOnChanges(changes:SimpleChanges) {
    this.isLogged = this.myAuthService.IsLogged();
    console.log(changes);
  }



  protected readonly faHome = faHome;
  protected readonly faUser = faUser;
  protected readonly faShop = faShop;
  protected readonly faEnvelope = faEnvelope;
  protected readonly faGear = faGear;
}
