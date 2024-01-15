import {Injectable} from "@angular/core";
import {Router} from "@angular/router";
import axios from "axios";
import {LoginRequest} from "../components/login/LoginRequest";
import { Config } from "../config";
@Injectable({providedIn:"root"})
export class MyAuthService
{
  rememberMe = false;

  loginValue: LoginRequest =
    {
      usernameOrEmail: "",
      password: ""
    };
  constructor(public router:Router) {
  }

  token:string|null = this.rememberMe?window.localStorage.getItem("my-auth-token"):window.sessionStorage.getItem("my-auth-token");
  IsLogged():boolean
  {
    this.token = window.localStorage.getItem("my-auth-token")??window.sessionStorage.getItem("my-auth-token");
    if (this.token != null)
    return this.token != " ";
    else return false;

  }
LogOut():void
{
  window.localStorage.removeItem("my-auth-token");
  window.sessionStorage.removeItem("my-auth-token");

  let link = Config.address + "api/LoginAuth/Delete/"
  axios.delete(link+this.token).catch(x=>console.log(x));

  this.router.navigate(["/"]);
}

   getAuthorizationToken ()  {


    let link = Config.address + "api/LoginAuth/Post";

    axios.post(link, this.loginValue,{headers:{
        'my-auth-token':  this.token
      }}).then(x=> {
      !this.rememberMe?window.localStorage.getItem('my-auth-token'):window.sessionStorage.getItem('my-auth-token')
      console.log(x.data);
    }).catch(err=>console.log(err.error));


    return (this.rememberMe?window.localStorage.getItem('my-auth-token'):window.sessionStorage.getItem('my-auth-token'))??" ";
  }
    //napravi dodavanje google tokena u bazu (preskoci generisanje tokena tj. prepusti google-u)

}
