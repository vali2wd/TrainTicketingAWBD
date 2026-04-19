import { HttpClient, HttpParams } from '@angular/common/http'; // Added HttpParams
import { Injectable } from '@angular/core';
import { IRoute } from '../../models/route';
import { PaginationResponse } from '../../models/pagination-response'; // Import your new interface
import { firstValueFrom } from 'rxjs';
import { environment } from '../../../environment';

@Injectable({
  providedIn: 'root',
})
export class TravelRoutesService {
  constructor(private http: HttpClient) {}

  public async getRoutes(
    pageNumber: number = 1,
    pageSize: number = 6,
    sortByA: boolean | null = null, // Route Name
    sortByB: boolean | null = null, // Distance
  ): Promise<PaginationResponse<IRoute>> {
    let params = new HttpParams()
      .set('pageNumber', pageNumber.toString())
      .set('pageSize', pageSize.toString());

    if (sortByA !== null) params = params.set('sortByA', sortByA.toString());
    if (sortByB !== null) params = params.set('sortByB', sortByB.toString());

    const url = `${environment.apiUrl}ticketing/routes-pg`;
    return await firstValueFrom(
      this.http.get<PaginationResponse<IRoute>>(url, { params }),
    );
  }
}
