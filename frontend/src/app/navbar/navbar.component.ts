import {Component, OnInit} from '@angular/core';
import {NgIf} from "@angular/common";
import {FaIconComponent} from "@fortawesome/angular-fontawesome";
import {faHome,faEnvelope, faShop, faUser} from "@fortawesome/free-solid-svg-icons";

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
export class NavbarComponent implements OnInit{

  ngOnInit() {
  // document?.querySelector(".hamburger").addEventListener("click", () => {
  //     document?.querySelector(".wrapper").classList.toggle("side-panel-open");
  //   });
  }



  protected readonly faHome = faHome;
  protected readonly faUser = faUser;
  protected readonly faShop = faShop;
  protected readonly faEnvelope = faEnvelope;
}
