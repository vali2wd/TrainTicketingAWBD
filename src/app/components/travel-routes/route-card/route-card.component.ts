import { Component, Input } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import { MatCardModule } from '@angular/material/card';
import { IRoute } from '../../../models/route';
import { RouterLink } from '@angular/router';
@Component({
  selector: 'app-route-card',
  imports: [MatCardModule, MatButtonModule, RouterLink],
  templateUrl: './route-card.component.html',
  styleUrl: './route-card.component.css'
})
export class RouteCardComponent {
 @Input()
  route!: IRoute;
}
