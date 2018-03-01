// import { Component } from '@angular/core';
//
// @Component({
//     selector: 'app',
//     templateUrl: './app.component.html',
//     styleUrls: ['./app.component.css']
// })
// export class AppComponent {
// }

import { Inject } from '@angular/core';
import { Component } from '@angular/core';
import { Http } from "@angular/http";
import { BaseComponent} from "../base/BaseComponent";
import { ResultJson } from "../../models/ResultJson";


@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    styleUrls: ['./app.component.css']
})
export class AppComponent extends BaseComponent{
    constructor(http: Http,
                @Inject('BASE_URL') protected baseUrl: string) {

        super(baseUrl, http);

        this.versionString = '';

        this.getVersionString();
    }

    private versionString: string;
    
    private getVersionString =() => {
        let route = `${this.apiUrl()}version`;
        this.http.get(route).subscribe(
            data => {
                let result = data.json() as ResultJson;
                if (result.success) {
                    this.versionString = result.result;
                }
            },
            error =>{
            });
    }
}
