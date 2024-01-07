// google-login.service.ts
import { Injectable } from '@angular/core';
import {UserProfile} from "./UserProfile";
import axios from "axios";
import {MyAuthService} from "./MyAuth";


@Injectable({
  providedIn: 'root',
})
export class ProfileService {

  userProfile:UserProfile|null = null;

  constructor(private myAuthService:MyAuthService) {
  }

 async getUserContent()
  {
    var link = "https://localhost:44308/api/ProfileEndpoint/GetUserInfo/"
    await axios.get(link + this.myAuthService.token,{headers:{'my-auth-token': this.myAuthService.token}}).then(x=> {
      this.userProfile = x.data
      console.log(this.userProfile);
    }).catch(x=>console.log(x));
  }



}
