module Aurora.ErpNext.Controllers {

    function InfoSupportControllerRoute($stateProvider: angular.ui.IStateProvider) {
        $stateProvider
            .state('infoSupport',
            {
                url: '/infoSupport',
                templateUrl: 'TypeScripts/Controllers/資訊服務單/infoSupport.edit.html',
                controller: 'InfoSupportEditController',
                controllerAs: 'InfoSupportEditCtrl',
                resolve: {
                    InfoSupport: function () {
                        let model: ViewModel.InfoSupportEditViewModel = {
                            ManagerName:"萱姐",
                            ManagerEMPNO: "00012345",
                            Context: "我的電腦已經壞很久了",
                            Title: "電腦維修服務",
                            Attachments:["1.jpg","2.jpg"]
                        }
                        return model;
                    }
                }
            })
            .state('detail',
            {
                url: '/detail/{Id}/{Name}',
                templateUrl: 'TypeScripts/Controllers/資訊服務單/infoSupport.detail.html',
                controller: 'InfoSupportDetailController',
                controllerAs: 'InfoSupportDetailCtrl',
                resolve: {

                }
            })
    }

    InfoSupportControllerRoute.$inject = ['$stateProvider'];

    angular.module('Aurora.ErpNext.Controllers')
        .config(InfoSupportControllerRoute);

}