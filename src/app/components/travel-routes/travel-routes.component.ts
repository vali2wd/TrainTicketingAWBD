import { Component, OnInit, Output } from '@angular/core';
import { RouteCardComponent } from './route-card/route-card.component';
import { TravelRoutesService } from './travel-routes.service';
import { IRoute } from '../../models/route';

@Component({
  selector: 'app-travel-routes',
  imports: [RouteCardComponent],
  templateUrl: './travel-routes.component.html',
  styleUrl: './travel-routes.component.css'
})
export class TravelRoutesComponent implements OnInit {

  routes: IRoute[] = [];

  constructor(private travelRoutesService: TravelRoutesService){}

  async ngOnInit(): Promise<void> {
    this.routes = await this.travelRoutesService.getRoutes();
  }
}
