import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common'; // For the @for loop or *ngFor
import { MatPaginatorModule, PageEvent } from '@angular/material/paginator'; // Material Paginator
import { RouteCardComponent } from './route-card/route-card.component';
import { TravelRoutesService } from './travel-routes.service';
import { IRoute } from '../../models/route';
import { MatSelectModule, MatFormField, MatLabel, MatOption, MatSelect } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';

@Component({
  selector: 'app-travel-routes',
  standalone: true,
  imports: [
    MatSelectModule,
    MatFormFieldModule,
    CommonModule,
    RouteCardComponent,
    MatPaginatorModule,
    MatFormField,
    MatLabel,
    MatOption,
    MatSelect
],
  templateUrl: './travel-routes.component.html',
  styleUrl: './travel-routes.component.css',
})
export class TravelRoutesComponent implements OnInit {
  routes: IRoute[] = [];
  totalCount = 0;
  pageSize = 10;
  pageIndex = 0; // Angular Material uses 0-based indexing
  currentSortA: boolean | null = null;
  currentSortB: boolean | null = null;

  constructor(private travelRoutesService: TravelRoutesService) {}

  async ngOnInit(): Promise<void> {
    await this.loadRoutes();
  }

  async onSortChange(value: string) {
    this.currentSortA = null;
    this.currentSortB = null;

    if (value === 'name-asc') this.currentSortA = true;
    if (value === 'name-desc') this.currentSortA = false;
    if (value === 'dist-asc') this.currentSortB = true;
    if (value === 'dist-desc') this.currentSortB = false;

    this.pageIndex = 0;
    await this.loadRoutes();
  }

  async loadRoutes(): Promise<void> {
    const response = await this.travelRoutesService.getRoutes(
      this.pageIndex + 1,
      this.pageSize,
      this.currentSortA,
      this.currentSortB,
    );
    this.routes = response.data;
    this.totalCount = response.totalCount;
  }

  async handlePageEvent(event: PageEvent): Promise<void> {
    this.pageIndex = event.pageIndex;
    this.pageSize = event.pageSize;
    await this.loadRoutes();
  }
}
