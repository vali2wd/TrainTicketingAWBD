import { Component } from '@angular/core';
import { NgIcon, provideIcons } from '@ng-icons/core';
import {MatMenuModule} from '@angular/material/menu';
import {MatButtonModule} from '@angular/material/button';

import {
  bootstrapList,
  bootstrapHouse,
  bootstrapTrainFront,
  bootstrapQuestion,
  bootstrapMegaphone,
  bootstrapNewspaper,
} from '@ng-icons/bootstrap-icons';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-navbar',
  imports: [NgIcon, MatButtonModule, MatMenuModule, RouterLink],
  providers: [
    provideIcons({
      bootstrapList,
      bootstrapHouse,
      bootstrapTrainFront,
      bootstrapQuestion,
      bootstrapNewspaper,
      bootstrapMegaphone,
    }),
  ],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css',
})
export class NavbarComponent {
  showFiller = false;
}
