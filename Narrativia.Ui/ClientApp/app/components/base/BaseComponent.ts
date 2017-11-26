import { Http } from "@angular/http";

export class BaseComponent {
    constructor(private originUrl: string, public http: Http) { }

    apiUrl = () :string => {
        return `${this.originUrl}api/`;
    }
}