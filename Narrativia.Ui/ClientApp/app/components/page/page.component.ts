import { Inject } from '@angular/core';
import { Component } from '@angular/core';
import { ActivatedRoute } from "@angular/router";
import { Http } from "@angular/http";

import { BaseComponent} from "../base/BaseComponent";

import { ResultJson } from "../../models/ResultJson"
import {PageForDisplayViewModel} from "../../models/Page";

@Component({
    selector: 'page,[Markdown]',
    templateUrl: './page.component.html',
    styleUrls: ['./page.component.css']
})

export class PageComponent  extends BaseComponent {
    constructor(private route: ActivatedRoute, http: Http, @Inject('BASE_URL') protected baseUrl: string) {
        super(baseUrl, http);
        this.loading = true;
    }
    
    loading: boolean;
    pageTitle: string;
    pageViewModel: PageForDisplayViewModel;

    private subscription: any;

    ngOnInit() {
        this.subscription = this.route.params.subscribe(params => {
            this.pageTitle = params['pageTitle'];

            let route = `${this.apiUrl()}pages/${this.pageTitle}`;

            this.http.get(route).subscribe(
                data => {

                    let resultJson = data.json() as ResultJson;
                    if(resultJson.success) {
                        this.pageViewModel = <IPage>data.json().result;
                        this.loading = false;
                    }
                },
                error =>{
                    debugger;
                });
        });
    }
}

interface IPage  {
    title: string;
    displayName: string;
    bodyText: string;
}