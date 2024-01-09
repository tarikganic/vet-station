import { Component } from '@angular/core';
import {FaIconComponent} from "@fortawesome/angular-fontawesome";
import {faFilter} from "@fortawesome/free-solid-svg-icons";

@Component({
  selector: 'app-input',
  standalone: true,
  imports: [
    FaIconComponent
  ],
  templateUrl: './input.component.html',
  styleUrl: './input.component.css'
})
export class InputComponent {

  protected readonly faFilter = faFilter;
}
