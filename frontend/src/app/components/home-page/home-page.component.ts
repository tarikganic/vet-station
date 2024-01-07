import {Component, OnInit} from '@angular/core';
import {MyAuthService} from "../../services/MyAuth";
import {ProfileService} from "../../services/ProfileService";

@Component({
  selector: 'app-home-page',
  standalone: true,
  imports: [],
  templateUrl: './home-page.component.html',
  styleUrl: './home-page.component.css'
})
export class HomePageComponent implements OnInit{

  ngOnInit() {
this.profileService.getUserContent();
  }

  constructor(public myAuthService:MyAuthService,public profileService:ProfileService) {

}
}
