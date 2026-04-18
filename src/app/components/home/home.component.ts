import { Component } from '@angular/core';
import { RouteSearchComponent } from "../route-search/route-search.component";

@Component({
  selector: 'app-home',
  imports: [RouteSearchComponent],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent {

}
