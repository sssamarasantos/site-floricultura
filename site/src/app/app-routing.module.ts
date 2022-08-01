import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WebsiteBodyComponent } from './shared/components/website-body/website-body.component';
import { HomeComponent } from './views/home/home.component';
import { SobreNosComponent } from './views/sobre-nos/sobre-nos.component';
import { TiposDeFloresComponent } from './views/tipos-de-flores/tipos-de-flores.component';

const routes: Routes = [
  {
    path: '',
    component: WebsiteBodyComponent,
    children: [
      {
        path: 'home', component: HomeComponent
      },
      {
        path: 'sobre-nos', component: SobreNosComponent
      },
      {
        path: 'tipos-de-flores', component: TiposDeFloresComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
