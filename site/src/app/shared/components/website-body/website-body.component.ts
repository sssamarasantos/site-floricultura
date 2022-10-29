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
    this.menuService.listar().subscribe((response: Menu[]) => {
      console.log(response)
      this.menus = response;
      console.log(this.menus);
    });
  }

}
