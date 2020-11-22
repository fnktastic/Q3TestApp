import { Component, OnInit } from '@angular/core';
import { ApiServiceService } from '../api-service.service';
import { RoomSummary } from '../model/room-summary';

@Component({
  selector: 'app-statistics',
  templateUrl: './statistics.component.html',
  styleUrls: ['./statistics.component.scss']
})
export class StatisticsComponent implements OnInit {
  roomSummaries: RoomSummary[];

  constructor(private service: ApiServiceService) { }

  ngOnInit(): void {
    this.service.getStats()
    .subscribe(x => this.roomSummaries = x.items);
  }
}
