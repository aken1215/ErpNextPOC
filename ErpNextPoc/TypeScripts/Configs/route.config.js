var Aurora;
(function (Aurora) {
    var ErpNext;
    (function (ErpNext) {
        var Configs;
        (function (Configs) {
            angular.module('Aurora.ErpNext.Configs')
                .config([
                '$stateProvider',
                '$urlRouterProvider',
                '$locationProvider',
                function ($stateProvider, $urlRouteProvider, $locationProvider) {
                    $urlRouteProvider.otherwise("member/new");
                }
            ]);
        })(Configs = ErpNext.Configs || (ErpNext.Configs = {}));
    })(ErpNext = Aurora.ErpNext || (Aurora.ErpNext = {}));
})(Aurora || (Aurora = {}));
