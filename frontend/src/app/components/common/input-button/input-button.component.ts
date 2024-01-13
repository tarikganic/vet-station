import {Component, EventEmitter, Input, Output} from '@angular/core';
import {FormsModule} from "@angular/forms";

@Component({
  selector: 'app-input-button',
  standalone: true,
  imports: [
    FormsModule
  ],
  templateUrl: './input-button.component.html',
  styleUrl: './input-button.component.css'
})
export class InputButtonComponent {
  @Input() content?: string;
  @Output() handleChange:EventEmitter<boolean> = new EventEmitter<boolean>();
  @Input() isChecked: boolean = false;




}
