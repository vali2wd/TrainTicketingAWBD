import { Component } from '@angular/core';
import { NgIcon, provideIcons } from '@ng-icons/core';
import { bootstrapFacebook, bootstrapInstagram, bootstrapPhone} from '@ng-icons/bootstrap-icons';

@Component({
  selector: 'app-topbar',
  imports: [NgIcon],
  providers: [provideIcons({ bootstrapFacebook, bootstrapInstagram, bootstrapPhone })],
  templateUrl: './topbar.component.html',
  styleUrl: './topbar.component.css'
})
export class TopbarComponent {

}
