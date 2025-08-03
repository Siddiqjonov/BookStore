import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { SignUp } from './components/sign-up/sign-up';
import { Login } from './components/login/login';
import { Book } from './components/book/book';
import { AdminPanel } from './components/admin-panel/admin-panel';
import { Store } from './components/store/store';
import { CheckOut } from './components/check-out/check-out';

@NgModule({
  declarations: [
    App,
    SignUp,
    Login,
    Book,
    AdminPanel,
    Store,
    CheckOut
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    provideBrowserGlobalErrorListeners()
  ],
  bootstrap: [App]
})
export class AppModule { }
