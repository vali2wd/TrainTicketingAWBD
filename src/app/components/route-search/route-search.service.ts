import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom } from 'rxjs';
import { IStation } from '../../models/station';
import { environment } from '../../../environment';

@Injectable({
  providedIn: 'root',
})
export class RouteSearchService {
  
  private stations: IStation[] = [];
  private areStationsLoaded: boolean = false;

  constructor(private http: HttpClient) { }

  async getStations(): Promise<IStation[]> {
    if (!this.areStationsLoaded){
      try{
        this.stations = await firstValueFrom(this.http.get<IStation[]>(environment.apiUrl + 'ticketing/stations'));
        this.areStationsLoaded = true;
      } catch (error) {
        console.error('Failed to fetch stations', error);
        throw error;
      }
    }
    return this.stations;
  }
}
