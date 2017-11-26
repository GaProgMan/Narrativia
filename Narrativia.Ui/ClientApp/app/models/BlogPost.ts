export class BlogPostBaseViewModel {
    constructor (public title: string, public headerImageUrl: string, public id: number) {
        
    }
}

export class BlogPostViewModel extends BlogPostBaseViewModel{
    constructor(title: string, headerImageUrl: string, id: number, bodyText: string) {
        super(title, headerImageUrl, id);
        this.bodyText = bodyText;
    }
    bodyText: string;
}

export class BlogPostListViewItem extends BlogPostBaseViewModel {
    constructor(title: string, headerImageUrl: string, id: number, except: string) {
        super(title, headerImageUrl, id);
        this.excerpt = except;
    }
    excerpt: string;
}