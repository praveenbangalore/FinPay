import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { InvoiceComponent } from './invoice/invoice.component';
import {   AuthGuardService as AuthGuard } from './auth-guard.service';
import { TransactionsComponent } from './transactions/transactions.component';

const routes: Routes = [
  { path:"home",component:HomeComponent ,pathMatch:'full'},
  { path:"login",component:LoginComponent,pathMatch:'full'},
  { path:"dashboard",component:DashboardComponent ,canActivate:[AuthGuard] },
  { path:"register",component:RegisterComponent,pathMatch:'full'},
  {path:"invoice",component:InvoiceComponent,canActivate:[AuthGuard]},
  {path:"transactions",component:TransactionsComponent,canActivate:[AuthGuard]},
  { path:'',component:DashboardComponent,canActivate:[AuthGuard],pathMatch:'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {useHash: true})],
  exports: [RouterModule]
})
export class AppRoutingModule { }
