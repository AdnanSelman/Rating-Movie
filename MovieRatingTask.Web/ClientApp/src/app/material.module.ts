import { NgModule } from '@angular/core';
import { MatButtonModule } from '@angular/material/button';
import {MatInputModule} from '@angular/material/input';
import {MatSlideToggleModule} from '@angular/material/slide-toggle';
import {MatCardModule} from '@angular/material/card';
import {MatTooltipModule} from '@angular/material/tooltip';
import { MatIconModule } from '@angular/material/icon';
import { MatListModule } from '@angular/material/list';
import { SharedModule } from './shared/shared.module';


@NgModule({
  imports: [
    SharedModule,
    MatButtonModule,
    MatTooltipModule,
    MatInputModule,
    MatSlideToggleModule,
    MatCardModule,
    MatIconModule,
    MatListModule
  ],
  exports: [
    MatButtonModule,
    MatTooltipModule,
    MatInputModule,
    MatSlideToggleModule,
    MatCardModule,
    MatIconModule,
    MatListModule
  ]
})
export class MaterialModule { }