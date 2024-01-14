import { Component } from '@angular/core';
import { OtherSignUpMethodsComponent } from "../other-sign-up-methods/other-sign-up-methods.component";
import { SignInInputComponent } from "../sign-in-input/sign-in-input.component";

@Component({
    selector: 'app-register',
    standalone: true,
    templateUrl: './register.component.html',
    styleUrl: './register.component.css',
    imports: [
        OtherSignUpMethodsComponent,
        SignInInputComponent
    ]
})
export class RegisterComponent {


}
