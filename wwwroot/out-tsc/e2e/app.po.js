"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
var protractor_1 = require("protractor");
var DotNetCoreAppPage = /** @class */ (function () {
    function DotNetCoreAppPage() {
    }
    DotNetCoreAppPage.prototype.navigateTo = function () {
        return protractor_1.browser.get('/');
    };
    DotNetCoreAppPage.prototype.getParagraphText = function () {
        return protractor_1.element(protractor_1.by.css('app-root h1')).getText();
    };
    return DotNetCoreAppPage;
}());
exports.DotNetCoreAppPage = DotNetCoreAppPage;
//# sourceMappingURL=app.po.js.map