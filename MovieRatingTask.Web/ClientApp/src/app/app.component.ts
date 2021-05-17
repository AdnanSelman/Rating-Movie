import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'Rating Movies';
  isShow = false;

  toggleShow(){
    this.isShow = !this.isShow;
  }
}
