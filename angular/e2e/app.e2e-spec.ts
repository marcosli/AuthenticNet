import { AuthenticNetTemplatePage } from './app.po';

describe('AuthenticNet App', function() {
  let page: AuthenticNetTemplatePage;

  beforeEach(() => {
    page = new AuthenticNetTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
