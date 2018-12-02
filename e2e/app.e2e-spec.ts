import { DotNetCoreAppPage } from './app.po';

describe('ng2-asp-core App', () => {
  let page: DotNetCoreAppPage;

  beforeEach(() => {
    page = new DotNetCoreAppPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('Welcome to app!!');
  });
});
