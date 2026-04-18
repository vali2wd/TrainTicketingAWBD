import { Component } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MatChipsModule } from '@angular/material/chips';
import { OnInit } from '@angular/core';
import { FormControl, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatInputModule } from '@angular/material/input';
import { MatFormFieldModule } from '@angular/material/form-field';
import { CommonModule } from '@angular/common';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { provideNativeDateAdapter } from '@angular/material/core';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon';
import { RouteSearchService } from './route-search.service';
import { IStation } from '../../models/station';
@Component({
  selector: 'app-route-search',
  imports: [
    MatCardModule,
    MatChipsModule,
    FormsModule,
    ReactiveFormsModule,
    MatAutocompleteModule,
    MatInputModule,
    MatFormFieldModule,
    CommonModule,
    MatFormFieldModule,
    MatInputModule,
    MatDatepickerModule,
    MatButtonModule,
    MatIconModule,
  ],
  providers: [provideNativeDateAdapter()],
  templateUrl: './route-search.component.html',
  styleUrl: './route-search.component.css',
})
export class RouteSearchComponent implements OnInit {
  departureControl = new FormControl('');
  arrivalControl = new FormControl('');
  todayDate: Date = new Date();
  maxDate: Date = new Date(this.todayDate.getTime() + (1000 * 60 * 60 * 24 * 30));

  stations: IStation[] = []; // Store all station names

  filteredDepartureOptions: IStation[] = []; // Store filtered station names
  filteredArrivalOptions: IStation[] = []; // Store filtered station names

  constructor(private routeSearchService: RouteSearchService) {}

  async ngOnInit(): Promise<void> {
    try {
      this.stations = (await this.routeSearchService.getStations()).sort(
        (a, b) => a.stationName.localeCompare(b.stationName)
      );

      this.filteredDepartureOptions = [...this.stations];
      this.filteredArrivalOptions = [...this.stations];

      this.departureControl.valueChanges.subscribe((value) => {
        this.filteredDepartureOptions = this._filter(
          this.stations,
          value || ''
        );
      });

      this.arrivalControl.valueChanges.subscribe((value) => {
        this.filteredArrivalOptions = this._filter(this.stations, value || '');
      });
    } catch (error) {
      console.log('Failed to fetch stations', error);
    }
  }

  private _filter(options: IStation[], value: string | IStation): IStation[] {
    
    let filterValue: string;
    if (typeof value === 'string'){
      filterValue = value.toLowerCase();
    }
    else {
      filterValue = value.stationName.toLowerCase();
    }

    return options.filter((option) =>
      option.stationName.toLowerCase().includes(filterValue)
    );
  }

  displayStationName(station: IStation | null | string): string {
    if (station && typeof station === 'object' && 'stationName' in station) {
      return station.stationName;
    }
    return '';
  }

  onSubmit(): void {
    console.log('Departure:', this.departureControl.value);
    console.log('Arrival:', this.arrivalControl.value);
  }
}
