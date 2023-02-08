import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FormComponent } from './form/form.component';
import { InitComponent } from './init/init.component';

const routes: Routes = [
  { path: "form", component: FormComponent },
  { path: "init", component:InitComponent },
  { path: "", redirectTo: "init", pathMatch: "full" }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
