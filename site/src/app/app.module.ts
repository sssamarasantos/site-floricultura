import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { MAT_DATE_LOCALE } from '@angular/material/core';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { MaterialModule } from './shared/material/material.module';
import { WebsiteBodyComponent } from './shared/components/website-body/website-body.component';
import { HomeComponent } from './views/home/home.component';
import { SobreNosComponent } from './views/sobre-nos/sobre-nos.component';
import { TiposDeFloresComponent } from './views/tipos-de-flores/tipos-de-flores.component';

@NgModule({
  declarations: [
    AppComponent,
    WebsiteBodyComponent,
    HomeComponent,
    SobreNosComponent,
    TiposDeFloresComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MaterialModule,
    HttpClientModule,
    BrowserAnimationsModule
  ],
  providers: [{ provide: MAT_DATE_LOCALE, useValue: 'pt' }],
  bootstrap: [AppComponent]
})
export class AppModule { }
