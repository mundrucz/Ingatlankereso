import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { EstateRoutingModule } from './estate-routing.module';
import { HomeComponent } from './home/home.component';
import { DetailsComponent } from './details/details.component';


@NgModule({
  declarations: [
    HomeComponent,
    DetailsComponent
  ],
  imports: [
    CommonModule,
    EstateRoutingModule
  ]
})
export class EstateModule { }
