import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ContactusComponent } from 'src/layout/contactus/contactus.component';
import { FooterComponent } from 'src/layout/footer/footer.component';
import { HeaderComponent } from 'src/layout/header/header.component';
import { LoginRedirectionComponent } from 'src/layout/login-redirection/login-redirection.component';
import { MainlayoutComponent } from 'src/layout/mainlayout/mainlayout.component';
import { RedirectionComponent } from 'src/layout/redirection/redirection.component';

const routes: Routes = [
  { path: 'header', component: HeaderComponent },
  { path: 'footer', component: FooterComponent },
  {
    path: 'contact-us',
    component: ContactusComponent,
  },
  {
    path: 'mainlayout',
    component: MainlayoutComponent,
  },
  { path: 'redirection', component: RedirectionComponent },
  { path: 'login-redirection', component: LoginRedirectionComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
