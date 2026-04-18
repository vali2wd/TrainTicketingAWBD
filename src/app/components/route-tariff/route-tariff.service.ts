import { Injectable } from '@angular/core';
import { environment } from '../../../environment';
import { HttpClient } from '@angular/common/http';
import { firstValueFrom } from 'rxjs';
import { RouteTariffDetail } from '../../models/route-tariff-detail';

@Injectable({
  providedIn: 'root'
})
export class RouteTariffService {

  constructor(private http: HttpClient) { }

  async getTariff(routeId: string | null): Promise<RouteTariffDetail[]> {
    try {
      return await firstValueFrom(this.http.get<RouteTariffDetail[]>(environment.apiUrl + 'route/' + routeId + '/tariff'));
    } catch (error) {
      console.error('Failed to fetch tariffs', error);
      throw error;
    }
  }
}
