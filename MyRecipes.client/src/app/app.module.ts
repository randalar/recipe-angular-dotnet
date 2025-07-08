import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RecipesComponent } from './components/recipes/recipes.component';
import { DeleteRecipeComponent } from './components/delete-recipe/delete-recipe.component';
import { NewRecipeComponent } from './components/new-recipe/new-recipe.component';
import { ShowRecipeComponent } from './components/show-recipe/show-recipe.component';
import { UpdateRecipeComponent } from './components/update-recipe/update-recipe.component';
import { RecipeService } from './services/recipe.service';

@NgModule({
  declarations: [
    AppComponent,
    RecipesComponent,
    DeleteRecipeComponent,
    NewRecipeComponent,
    ShowRecipeComponent,
    UpdateRecipeComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,
    AppRoutingModule
  ],
  providers: [RecipeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
