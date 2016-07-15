/// <reference path="../scripts/typings/angularjs/angular.d.ts" />
/// <reference path="../Scripts/TypeLite.Net4.d.ts" />
/// <reference path="../scripts/typings/jquery/jquery.d.ts" />


module Aurora.ErpNext {
    angular.module('Aurora.ErpNext', [
        'ui.router',
        'Aurora.ErpNext.Services',
        'Aurora.ErpNext.Controllers',
        'Aurora.ErpNext.Configs'
    ]);

    angular.module('Aurora.ErpNext.Configs', []);
    angular.module('Aurora.ErpNext.Controllers', ['Aurora.ErpNext.Services']);
    angular.module('Aurora.ErpNext.Services', []);
}