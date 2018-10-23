import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AddressEntryComponent } from './address-entry/address-entry.component';

const routes: Routes = [
  { path: 'address-entry', component: AddressEntryComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
