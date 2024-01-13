import {Component, OnInit} from '@angular/core';
import {MyAuthService} from "../../services/MyAuth";
import {ProfileService} from "../../services/ProfileService";
import {NgForOf} from "@angular/common";
import {FaIconComponent} from "@fortawesome/angular-fontawesome";
import {faStar} from "@fortawesome/free-solid-svg-icons";
import {VetCardComponent} from "../vet-card/vet-card.component";
import {InputComponent} from "../common/input/input.component";

@Component({
  selector: 'app-home-page',
  standalone: true,
  imports: [
    NgForOf,
    FaIconComponent,
    VetCardComponent,
    InputComponent
  ],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.css'
})
export class HomePageComponent implements OnInit{
  tempList= [1,2,3,4,5,6,7,8,9,10];

  ngOnInit() {
this.profileService.getUserContent();
  }

  constructor(public myAuthService:MyAuthService,public profileService:ProfileService) {

}

  protected readonly faStar = faStar;
}
