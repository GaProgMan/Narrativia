import {Component, Inject} from '@angular/core';
import {BaseComponent} from "../base/BaseComponent";
import {Http} from "@angular/http";
import {ResultJson} from "../../models/ResultJson";
import {PageForHeaderViewModel} from "../../models/Page";

@Component({
    selector: 'nav-menu',
    templateUrl: './navmenu.component.html',
    styleUrls: ['./navmenu.component.css']
})
export class NavMenuComponent extends BaseComponent {
    constructor(http: Http, @Inject('BASE_URL') protected baseUrl: string) {
        super(baseUrl, http);

        this.loading = true;
        
        this.getPages();
    }

    pagesForHeader: PageForHeaderViewModel[];
    
    loading: boolean;

    private getPages = () => {

        let route = `${this.apiUrl()}pages/PagesForHeader`;
        this.loading = true;
        this.http.get(route).subscribe(
            data => {
                let resultJson = data.json() as ResultJson;
                if(resultJson.success) {
                    this.pagesForHeader = data.json().result.map((pageEntity: IPage) => {
                        return new PageForHeaderViewModel(pageEntity.title, pageEntity.displayName,
                            pageEntity.iconIdentifier);
                    });
                    this.loading = false;
                }
            },
            error =>{
            });
    }
}

interface IPage  {
    title: string;
    displayName: string;
    bodyText: string;
    iconIdentifier: string;
}