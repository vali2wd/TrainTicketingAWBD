import { Routes } from '@angular/router';
import { IssueTravelPermitsComponent } from './components/issue-travel-permits/issue-travel-permits.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { HomeComponent } from './components/home/home.component';
import { TravelRoutesComponent } from './components/travel-routes/travel-routes.component';
import { RouteTariffComponent } from './components/route-tariff/route-tariff.component';
import { RouteDetailComponent } from './components/route-details/route-detail/route-detail.component';

export const routes: Routes = [
  {
    path: '',
    component: HomeComponent,
    title: 'Acasa - Transferoviar Calatori',
  },
  {
    path: 'pentru-calatori/eliberarea-legitimatiilor-de-calatorie',
    component: IssueTravelPermitsComponent,
    title: 'Eliberarea legitimatiilor de calatorie',
  },
  {
    path: 'pentru-calatori/rute',
    component: TravelRoutesComponent,
    title: 'Rute de calatorie',
  },
  {
    path: 'pentru-calatori/tarif/:routeId',
    component: RouteTariffComponent,
    title: 'Tarife de calatorie',
  },
  {
    path: 'pentru-calatori/rute/:routeId',
    component: RouteDetailComponent,
    title: 'Tarife de calatorie',
  },
  {
    path: '**',
    component: NotFoundComponent,
  },
];
