// google-login.service.ts
import { Injectable } from '@angular/core';
import {OAuthService} from "angular-oauth2-oidc";

const oAuthConfig =
  {
    // Url of the Identity Provider
    issuer: 'https://accounts.google.com',

    // strict discovery document disallows urls which not start with issuers url
    strictDiscoveryDocumentValidation: false,

    // URL of the SPA to redirect the user to after login
    redirectUri: window.location.origin,

    // The SPA's id. The SPA is registerd with this id at the auth-server
    // clientId: 'server.code',
    clientId: '1032558872733-v9evv1snk6l8es598b637nbo2bg1kqd0.apps.googleusercontent.com',

    // set the scope for the permissions the client should request
    scope: 'openid profile email https://www.googleapis.com/auth/gmail.readonly',

    showDebugInformation: true,
  }

@Injectable({
  providedIn: 'root',
})
export class GoogleLoginService {

  constructor(private readonly  oAuthService: OAuthService) {
  oAuthService.configure(oAuthConfig);
  oAuthService.loadDiscoveryDocument().then(()=>
  {
    oAuthService.tryLoginImplicitFlow().then(()=>
    {
      if(!oAuthService.hasValidAccessToken())
      {
        oAuthService.initLoginFlow();
      }
      else {
        oAuthService.loadUserProfile().then((userProfile)=>
        {
          console.log(JSON.stringify(userProfile))
        })

      }

    })
  })

  }

  signOut() {

  }
}
