import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TopbarComponent } from "./shared/topbar/topbar.component";
import {MatIconModule} from '@angular/material/icon';
import { NavbarComponent } from "./shared/navbar/navbar.component";
import { RouteSearchService } from './components/route-search/route-search.service';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, TopbarComponent, MatIconModule, NavbarComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'train-ticketing';

  constructor(private routeSearchService: RouteSearchService) {
  }
}
