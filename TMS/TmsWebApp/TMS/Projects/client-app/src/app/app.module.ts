import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
// import { AlertifyService } from 'src/services/alertify.service';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { FooterComponent } from 'src/layout/footer/footer.component';
import { HeaderComponent } from 'src/layout/header/header.component';
import { RouterModule } from '@angular/router';
import { AbsoluteSourceSpan } from '@angular/compiler';
import { ContactusComponent } from 'src/layout/contactus/contactus.component';
import { MainlayoutComponent } from 'src/layout/mainlayout/mainlayout.component';
import { RedirectionComponent } from 'src/layout/redirection/redirection.component';
import { LoginRedirectionComponent } from 'src/layout/login-redirection/login-redirection.component';

@NgModule({
  declarations: [
    AppComponent,
    FooterComponent,
    HeaderComponent,
    ContactusComponent,
    MainlayoutComponent,
    RedirectionComponent,
   LoginRedirectionComponent

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,

  ],
  providers: [
    // AlertifyService;
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
function appRoutes(appRoutes: any): any[] | import("@angular/core").Type<any> | import("@angular/core").ModuleWithProviders<{}> {
  throw new Error('Function not implemented.');
}

