import { theslowprojectTemplatePage } from './app.po';

describe('theslowproject App', function() {
  let page: theslowprojectTemplatePage;

  beforeEach(() => {
    page = new theslowprojectTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
