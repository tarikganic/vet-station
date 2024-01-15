import {Routes} from '@angular/router';
import {LoginComponent} from "./components/login/login.component";
import {HomePageComponent} from "./components/home-page/home-page.component";
import {AuthorizationGuard} from "../helper/authLogin";
import { VetStationHomePageComponent } from './components/vet-station-home-page/vet-station-home-page.component';

export const routes: Routes = [{ path: '', component: LoginComponent},
  { path: 'home-page', component: HomePageComponent, canActivate: [AuthorizationGuard] },
  { path: 'vet-station-home', component: VetStationHomePageComponent, canActivate: [AuthorizationGuard] },


]

