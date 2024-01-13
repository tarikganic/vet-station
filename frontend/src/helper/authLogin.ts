import {inject, Injectable} from "@angular/core";
import {ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot} from "@angular/router";
import {MyAuthService} from "../app/services/MyAuth";


@Injectable({
  providedIn: 'root',
})
export class AuthorizationGuard implements CanActivate {

  constructor(private router: Router, private myAuthService: MyAuthService) {
    this.router = inject(Router);

  }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {

      //let isStudent = this.myAuthService.isCustomer(); //@e.g. customer cannot access routes that vet can

      if (this.myAuthService.IsLogged())
      {
      return true;
    }
      else  //temporary
      {
    // not logged in so redirect to login page with the return url
    this.router.navigate([''],{ queryParams: { povratniUrl: state.url }} );
    return false;
      }
  }
}
