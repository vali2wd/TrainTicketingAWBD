import { Component, inject } from '@angular/core';
import { NgIcon, provideIcons } from '@ng-icons/core';
import { MatMenuModule } from '@angular/material/menu';
import { MatButtonModule } from '@angular/material/button';
import { MatDividerModule } from '@angular/material/divider';

import {
  bootstrapList,
  bootstrapHouse,
  bootstrapTrainFront,
  bootstrapQuestion,
  bootstrapMegaphone,
  bootstrapDoorClosed,
  bootstrapNewspaper,
} from '@ng-icons/bootstrap-icons';
import { RouterLink } from '@angular/router';
import { AuthService } from '../../services/auth.service';
import { AsyncPipe } from '@angular/common';

@Component({
  selector: 'app-navbar',
  imports: [NgIcon, MatButtonModule, MatMenuModule, RouterLink, MatDividerModule, AsyncPipe],
  providers: [
    provideIcons({
      bootstrapList,
      bootstrapHouse,
      bootstrapTrainFront,
      bootstrapQuestion,
      bootstrapNewspaper,
      bootstrapMegaphone,
      bootstrapDoorClosed
    }),
  ],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css',
})
export class NavbarComponent {
  showFiller = false;
  public authService = inject(AuthService);

  onLogout() {
    this.authService.logout();
  }
}
