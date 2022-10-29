export interface Menu {
  id: number;
  item: string;
  rota: string;
  ordem: number;
  subMenus: Array<SubMenu>;
}
export interface SubMenu {
  id: number;
  item: string;
  rota: string;
  ordem: number;
  idMenu: number;
}
