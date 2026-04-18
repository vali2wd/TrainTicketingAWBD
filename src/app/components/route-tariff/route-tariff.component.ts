import { Component, OnInit } from '@angular/core';
import { RouteTariffService } from './route-tariff.service';
import { ActivatedRoute } from '@angular/router';
import { RouteTariffDetail } from '../../models/route-tariff-detail';
import {MatTableModule} from '@angular/material/table';
import { CurrencyPipe } from '@angular/common';
@Component({
  selector: 'app-route-tariff',
  imports: [MatTableModule, CurrencyPipe],
  templateUrl: './route-tariff.component.html',
  styleUrl: './route-tariff.component.css',
})
export class RouteTariffComponent implements OnInit {
  routeId: string | null = '';
  routeTariff: RouteTariffDetail[] = [];
  displayedColumns: string[] = [ 'startKm', 'endKm', 'pricePerKm', 'seatClass'];

  constructor(private route: ActivatedRoute, private routeTariffService: RouteTariffService) {}

  async ngOnInit(): Promise<void> {
    this.routeId = this.route.snapshot.paramMap.get('routeId');
    try{
      this.routeTariff = await this.routeTariffService.getTariff(this.routeId);
    }catch(error){
    }
  }
}
