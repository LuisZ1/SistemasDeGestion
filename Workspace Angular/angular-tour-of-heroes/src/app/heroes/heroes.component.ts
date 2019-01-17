import { Component, OnInit } from '@angular/core';
<<<<<<< HEAD

import { Hero } from '../hero';
import { HeroService } from '../hero.service';
=======
import { Hero } from '../hero';
import { HEROES } from '../mock-heroes';
>>>>>>> master

@Component({
  selector: 'app-heroes',
  templateUrl: './heroes.component.html',
  styleUrls: ['./heroes.component.css']
})
export class HeroesComponent implements OnInit {
<<<<<<< HEAD
  heroes: Hero[];

  constructor(private heroService: HeroService) { }

  ngOnInit() {
    this.getHeroes();
  }

  getHeroes(): void {
    this.heroService.getHeroes()
    .subscribe(heroes => this.heroes = heroes);
  }
}
=======

  hero: Hero = {
    id: 1,
    name: 'Windstorm'
  };

  heroes = HEROES;

  selectedHero: Hero;
  onSelect(hero: Hero): void {
    this.selectedHero = hero;
  }

  constructor() { }

  ngOnInit() {
  }

}
>>>>>>> master
