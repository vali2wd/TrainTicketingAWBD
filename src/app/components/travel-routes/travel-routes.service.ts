import { HttpClient } from '@angular/common/http';
import { Injectable, Output } from '@angular/core';
import { IRoute } from '../../models/route';
import { firstValueFrom } from 'rxjs';
import { environment } from '../../../environment';

@Injectable({
  providedIn: 'root'
})
export class TravelRoutesService {
  constructor(private http: HttpClient) { }

  public async getRoutes(): Promise<IRoute[]> {
    try {
      return await firstValueFrom(this.http.get<IRoute[]>(environment.apiUrl + 'routes'));
    } catch (error) {
      console.error('Failed to fetch routes', error);
      throw error;
    }
  }
}
