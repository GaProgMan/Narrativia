import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { MarkdownModule } from 'angular2-markdown';

import { BaseComponent } from "./components/base/BaseComponent";
import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { BlogPostComponent } from "./components/blogPost/blogPost.component";
import { BlogPostListComponent } from "./components/blogPostList/blogPostList.component";
import { PageComponent} from "./components/page/page.component";

@NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        HomeComponent,
        BlogPostComponent,
        BlogPostListComponent,
        PageComponent
    ],
    imports: [
        CommonModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'blogPostList', component: BlogPostListComponent },
            { path: 'blogPost/:id', component: BlogPostComponent },
            { path: 'page/:pageTitle', component: PageComponent },
            { path: '**', redirectTo: 'home' }
        ]),
        MarkdownModule.forRoot()
    ]
})
export class AppModuleShared {
}
