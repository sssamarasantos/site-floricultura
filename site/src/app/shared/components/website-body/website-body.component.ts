import { HttpClient } from "@angular/common/http";
import { Component, OnInit } from '@angular/core';
import { Menu } from "src/app/models/Menu";
import { MenuService } from "src/app/services/menu.service";

@Component({
  selector: 'app-website-body',
  templateUrl: './website-body.component.html',
  styleUrls: ['./website-body.component.css']
})
export class WebsiteBodyComponent implements OnInit {

  menus: Menu[] = [];

  constructor(private menuService: MenuService) { }

  ngOnInit(): void {
    this.listar()
  }

  private listar() {
    let listaMenus = sessionStorage.getItem('menus');
    if (listaMenus != null || listaMenus != undefined) {
      this.menus = JSON.parse(listaMenus);
    }
    else {
      this.menuService.listar().subscribe((response: Menu[]) => {
        sessionStorage.setItem('menus', JSON.stringify(response));
        this.menus = response;
      });
    }
  }
}
