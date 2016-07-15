module Aurora.ErpNext.Configs {
    angular.module('Aurora.ErpNext.Configs')
        .config([
            '$stateProvider',
            '$urlRouterProvider',
            '$locationProvider',
            (
                $stateProvider: angular.ui.IStateProvider,
                $urlRouteProvider: angular.ui.IUrlRouterProvider,
                $locationProvider: ng.ILocaleService) => {
                $urlRouteProvider.otherwise("member/new");
            }
        ])
}