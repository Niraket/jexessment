import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { VacanciesComponent } from './vacancies/vacancies.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, VacanciesComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.less'
})
export class AppComponent {
  title = 'jexessment';
}
