import { Component, OnInit } from '@angular/core';
import { ApiServiceService } from '../api-service.service';
import { Job } from '../model/job';

@Component({
  selector: 'app-jobs',
  templateUrl: './jobs.component.html',
  styleUrls: ['./jobs.component.scss']
})
export class JobsComponent implements OnInit {
  jobs: Job[];

  constructor(private service: ApiServiceService) { }

  ngOnInit(): void {
    this.service.getJobs().subscribe(x => this.jobs = x.items)
  }

  complete(item: Job) {
    this.service.markAsComplete(item.id).subscribe();
  }

  getColor(item: Job) {
    switch(item.jobStatus) {
      case 'Complete': return 'green';
      case 'Not Started': return 'white';
      case 'In Progress': return 'blue';
      case 'Delayed': return 'red';
    }

    return "gray";
  }

}
