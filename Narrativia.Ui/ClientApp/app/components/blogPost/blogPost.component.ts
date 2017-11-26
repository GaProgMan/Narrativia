import { Inject } from '@angular/core';
import { Component } from '@angular/core';
import { ActivatedRoute } from "@angular/router";
import { Http } from "@angular/http";

import { BaseComponent} from "../base/BaseComponent";

import { ResultJson } from "../../models/ResultJson"
import { BlogPostViewModel } from "../../models/BlogPost";

@Component({
    selector: 'blogPost,[Markdown]',
    //selector: 'blogPost',
    templateUrl: './blogPost.component.html'
})

export class BlogPostComponent extends BaseComponent {
    constructor(private route: ActivatedRoute,
                http: Http,
                @Inject('BASE_URL') protected baseUrl: string) {
        super(baseUrl, http);
        this.loading = true;
    }
    blogPostId: number;
    blogPost: BlogPostViewModel;
    loading: boolean;

    private subscription: any;

    ngOnInit() {
        this.subscription = this.route.params.subscribe(params => {
            this.blogPostId = +params['id'];

            let route = `${this.apiUrl()}BlogPost/${this.blogPostId}`;

            this.http.get(route).subscribe(
             data => {

                 let resultJson = data.json() as ResultJson;
                 if(resultJson.success) {
                     
                     let serverPost = <IApiBlogPost>data.json().result;
                     this.blogPost = new BlogPostViewModel(serverPost.title, serverPost.headerImageUrl,
                         serverPost.id, serverPost.bodyText);
                     this.loading = false;
                 }
             },
             error =>{
                 debugger;
             });
        });
    }
}

interface IApiBlogPost {
    title: string;
    headerImageUrl: string;
    bodyText: string;
    id: number;
}