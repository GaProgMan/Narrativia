export class BasePageViewModel {
    constructor (public title: string) {

    }
}

export class PageForHeaderViewModel extends BasePageViewModel {
    constructor(title: string, public displayName: string, public iconIdentifier?: string) {
        super(title);
    }
}

export class PageForDisplayViewModel extends PageForHeaderViewModel {
    constructor(title: string, displayName:string, public bodyText: string, public headerImageUrl?: string) {
        super(title, displayName);
    }
}