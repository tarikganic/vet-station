import { Component } from '@angular/core';
import {FaIconComponent} from "@fortawesome/angular-fontawesome";
import { faWifi } from '@fortawesome/free-solid-svg-icons';
import { faWheelchair } from '@fortawesome/free-solid-svg-icons';
import { faP } from '@fortawesome/free-solid-svg-icons';
@Component({
  selector: 'app-vet-card',
  standalone: true,
  imports: [FaIconComponent],
  templateUrl: './vet-card.component.html',
  styleUrl: './vet-card.component.css'
})
export class VetCardComponent {
  public readonly faWifi = faWifi;
  public readonly faWheelchair = faWheelchair;
  public readonly faP = faP;

}
