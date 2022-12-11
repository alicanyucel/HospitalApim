import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { DoktorComponent } from './doktor/doktor.component';
import { HospitalComponent } from './hospital/hospital.component';
import { DrhptlComponent } from './drhptl/drhptl.component';

@NgModule({
  declarations: [
    AppComponent,
    DoktorComponent,
    HospitalComponent,
    DrhptlComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
