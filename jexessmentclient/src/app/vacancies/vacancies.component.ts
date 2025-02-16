import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { Vacancy } from '../models/vacancy';

@Component({
  selector: 'app-vacancies',
  standalone: true,
  imports: [HttpClientModule, CommonModule],
  templateUrl: './vacancies.component.html',
  styleUrl: './vacancies.component.less'
})

export class VacanciesComponent {
  constructor(private http: HttpClient) {
    this.getData();
  }

  vacancies: Vacancy[] | undefined;

  getData(): void  {
    this.http.get<Vacancy[]>('http://localhost:5079/getvacancies') //weatherforecast
      .subscribe(data => this.vacancies = { ...data });
  }
}
