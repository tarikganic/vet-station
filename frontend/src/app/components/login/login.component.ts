import {Component, OnInit} from '@angular/core';
import {FaIconComponent} from "@fortawesome/angular-fontawesome";
import {NgClass, NgForOf} from "@angular/common";
import {FormsModule} from "@angular/forms";
import {SignInInputComponent} from "../sign-in-input/sign-in-input.component";
import {OtherSignUpMethodsComponent} from "../other-sign-up-methods/other-sign-up-methods.component";
import axios from "axios";
import {Router, RouterLink} from "@angular/router";
import {MyAuthService} from "../../services/MyAuth";
import { Config } from '../../config';
@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FaIconComponent, NgClass, FormsModule, SignInInputComponent, FormsModule, OtherSignUpMethodsComponent, RouterLink, NgForOf],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent implements OnInit{

  constructor(private router:Router,private myAuthService:MyAuthService) {

  }
ngOnInit() {  
   if (this.myAuthService.IsLogged())
      this.router.navigate(['home-page']);
}

  public usernameOrEmail = "";
  public password = "";

placeholder:any
emailRegex = new RegExp('^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$');
passwordRegex = new RegExp('^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[^\\da-zA-Z]).{8,}$');
checkBox:boolean = false;
token :any;
isError:boolean = false;

  signIn = () => {


    this.myAuthService.loginValue!.usernameOrEmail = this.usernameOrEmail;
    this.myAuthService.loginValue!.password = this.password
    if (this.emailRegex.test(this.usernameOrEmail) || this.passwordRegex.test(this.password) )
    {
      let link = Config.address + "LoginAuth/Post";

       axios.post(link, this.myAuthService.loginValue,{headers:{
          'my-auth-token': (this.myAuthService.rememberMe ?
            window.localStorage.getItem('my-auth-token'):window.sessionStorage.getItem('my-auth-token'))
        }}).then(x=> {
        this.myAuthService.rememberMe ?
        window.localStorage.setItem('my-auth-token',x.data):window.sessionStorage.setItem('my-auth-token',x.data)
        console.log(x.data);
         this.router.navigate(["home-page"]);

      }).catch(err=>console.log(err.error));

      this.isError = false;

    }
   else
    {
    this.isError=true;
     window.alert("Pogresan unos korisnickog imena ili emaila")
    }
  }
  handleValueChanged($event:string, obj:string) {
    //@ts-ignore
    this[obj] = $event;
  }

  keepMeSigned()
  {
    this.myAuthService.rememberMe = !this.myAuthService.rememberMe;
    this.checkBox = this.myAuthService.rememberMe;
  }

}

