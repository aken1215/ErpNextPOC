module Aurora.ErpNext.Controllers {

    function InfoSupportControllerRoute($stateProvider: angular.ui.IStateProvider) {
        $stateProvider
            .state('infoSupport',
            {
                url: '/infoSupport',
                templateUrl: 'TypeScripts/Controllers/資訊服務單/infoSupport.edit.html',
                controller: 'InfoSupportController',
                controllerAs: 'InfoSupportCtrl',
                resolve: {

                }
            })
    }

    InfoSupportControllerRoute.$inject = ['$stateProvider'];

    angular.module('Aurora.ErpNext.Controllers')
        .config(InfoSupportControllerRoute);

}