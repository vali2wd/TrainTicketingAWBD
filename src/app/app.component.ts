import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { TopbarComponent } from "./shared/topbar/topbar.component";
import { MatIcon, MatIconRegistry } from '@angular/material/icon';
import { DomSanitizer } from '@angular/platform-browser';
import {MatIconModule} from '@angular/material/icon';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, TopbarComponent, MatIconModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'train-ticketing';

    // constructor(iconRegistry: MatIconRegistry, sanitizer: DomSanitizer) {
    //   iconRegistry.addSvgIcon(
    //     "instagram-logo",
    //     sanitizer.bypassSecurityTrustResourceUrl("/assets/instagram-logo.svg")
    //   );
    // }

}
