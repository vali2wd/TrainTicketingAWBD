import { Injectable } from '@angular/core';
import { environment } from '../../../environment';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RouteTariffService {

  constructor(private http: HttpClient) { }

  // TODO
  async getTariff(routeId: string | null): Promise<any> {
    try {
      return await firstValueFrom(this.http.get<any>(environment.apiUrl + 'ticketing/tariffs'));
    } catch (error) {
      console.error('Failed to fetch tariffs', error);
      throw error;
    }
  }
}
