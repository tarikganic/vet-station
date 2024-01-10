import {Component, HostListener} from '@angular/core';
import {FaIconComponent} from "@fortawesome/angular-fontawesome";
import {faFilter} from "@fortawesome/free-solid-svg-icons";
import {FormsModule} from "@angular/forms";
import {InputButtonComponent} from "../input-button/input-button.component";
import {NgForOf, NgIf} from "@angular/common";
import {ElementRef} from "@angular/core";

@Component({
  selector: 'app-input',
  standalone: true,
  imports: [
    FaIconComponent,
    FormsModule,
    InputButtonComponent,
    NgForOf,
    NgIf
  ],
  templateUrl: './input.component.html',
  styleUrl: './input.component.css'
})
export class InputComponent {

  protected readonly faFilter = faFilter;

  dropdown =
    [
      {
        "key": 0,
        "title":"Location",
  "children":[
{
  'key': 0,
  'name': 'Closest Station',
  'value': false,
}
    ]
      },
      {
        "key": 1,
        "title":"Service type",
        "children":[
          {
            'key': 0,
            'name': 'In Office',
            'value': false,
          },
          {
            'key': 1,
            'name':'On Field',
            'value': false,
          }

        ]
      },
      {
        "key": 2,
        "title":"Accommodation",
        "children":[
          {
            'key': 0,
            'name': 'Parking',
            'value': false,
          },
          {
            'key': 1,
            'name':'Wheelchair',
            'value': false,
          },
          {
            'key': 2,
            'name':'Wi-fi',
            'value': false,
          }

        ]
      }
    ]
  filterIsClicked: boolean = false;

constructor(private elementRef:ElementRef) {
}
  @HostListener('document:click', ['$event'])
  clickOutside(event: Event) {
    const target = event.target as HTMLElement;

    if (!this.elementRef.nativeElement.contains(target)) {
      this.filterIsClicked = false;
    }
  }
  handleChange(temp: boolean, i:number, j:number) {
    temp = !temp;
    this.dropdown[i].children[j].value = temp;
console.log(this.dropdown[i].children[j])
  }
}
