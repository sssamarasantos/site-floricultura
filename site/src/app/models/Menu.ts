export interface Menu {
  id: number;
  item: string;
  route: string;
  subMenus: Array<SubMenu>;
}

export interface SubMenu {
  id: number;
  item: string;
  route: string;
  idMenu: number;
}
