import { Inject } from '@angular/core';
import { Component } from '@angular/core';
import { ActivatedRoute } from "@angular/router";
import { Http } from "@angular/http";
import { BaseComponent} from "../base/BaseComponent";
import { ResultJson } from "../../models/ResultJson"
import { BlogPostListViewItem } from "../../models/BlogPost";

@Component({
    selector: 'blogPostList',
    templateUrl: './blogPostList.component.html',
    styleUrls: ['./blogPostList.component.css']
})

export class BlogPostListComponent extends BaseComponent {
    constructor(http: Http,
                @Inject('BASE_URL') protected baseUrl: string) {
        super(baseUrl, http);

        this.loading = true;
        this.getBlogPostList();
    }
    blogPosts: BlogPostListViewItem[];
    loading: boolean;
    
    private getBlogPostList = (): void => {
        let route = `${this.apiUrl()}BlogPost/list`;

        this.http.get(route).subscribe(
            data => {

                let resultJson = data.json() as ResultJson;
                if(resultJson.success) {
                    this.blogPosts = data.json().result.map((serverPost: IApiBlogPost) => {
                        return new BlogPostListViewItem(serverPost.title, serverPost.headerImageUrl,
                            serverPost.id, serverPost.excerpt);
                    });
                    this.loading = false;
                }
            },
            error =>{
                debugger;
            });
    }
}

interface IApiBlogPost {
    title: string;
    excerpt: string;
    headerImageUrl: string;
    id: number;
}