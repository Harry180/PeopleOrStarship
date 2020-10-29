import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import {MatCardModule} from '@angular/material/card';
import {Starship} from "../dto/Starship";
import FightService from "../../utils/fightService";

@Component({
  selector: 'app-starship-data',
  templateUrl: './starship.component.html',
  styleUrls: ['./starship.component.css']
})
export class StarshipComponent {
  private http:HttpClient;
  private baseUrl: string;
  public starships: Starship[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
    this.extracted(http, baseUrl);
  }

  private extracted(http: HttpClient, baseUrl: string) {
    http.get<Starship[]>(baseUrl + 'starships').subscribe(result => {
      console.log(`people result: ${JSON.stringify(result)}`);
      this.starships = result;
      var fightWinner = FightService.starshipBattle(result[0],result[1]);

      this.starships.forEach((person,index) => {
        if(fightWinner.id === person.id){
          person.won = true;
        }
      });
    }, error => console.error(error));
  }

  fightAgain($event: MouseEvent) {
    this.starships = null;
    this.extracted(this.http, this.baseUrl);
  }
}


