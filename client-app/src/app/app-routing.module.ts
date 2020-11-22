import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { JobsComponent } from './jobs/jobs.component';
import { StatisticsComponent } from './statistics/statistics.component';

const routes: Routes = [
  { path: 'jobs', component: JobsComponent },
  { path: 'stats', component: StatisticsComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
