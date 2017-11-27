import { Inject } from '@angular/core';
import { Component } from '@angular/core';
import { Http } from "@angular/http";
import { BaseComponent} from "../base/BaseComponent";
import { ResultJson } from "../../models/ResultJson";

@Component({
    selector: 'home,[Markdown]',
    templateUrl: './home.component.html'
})

export class HomeComponent extends BaseComponent {
    constructor(http: Http,
                @Inject('BASE_URL') protected baseUrl: string) {

        super(baseUrl, http);

        this.aboutString = '';
        this.loading = true;

        this.getAboutString();
    }

    private aboutString: string;

    loading: boolean;

    private getAboutString = () => {

        let route = `${this.apiUrl()}pages/Home`;
        this.loading = true;
        this.http.get(route).subscribe(
            data => {
                let resultJson = data.json() as ResultJson;
                if(resultJson.success) {
                    let serverPage = <IPage>data.json().result;
                    this.aboutString = serverPage.bodyText;
                    this.loading = false;
                }
            },
            error =>{
            });
    }
}

interface IPage  {
    title: string;
    bodyText: string;
}