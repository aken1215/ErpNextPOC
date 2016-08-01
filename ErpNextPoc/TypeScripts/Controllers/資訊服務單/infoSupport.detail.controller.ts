module Aurora.ErpNext.Controllers {
    export class InfoSupportDetailController {
        static $inject = ['$log', '$state', '$stateParams'];
        
        InfoSupports: ViewModel.InfoSupportEditViewModel[];

        constructor(
            $log: ng.ILogService,
            protected $state: ng.ui.IStateService,
            $stateParams: ng.ui.IStateParamsService

        ) {
            let infoSupport: ViewModel.InfoSupportEditViewModel = {
                Title: "電腦維修服務",
                Context: "我的電腦已經壞很久了",
                ManagerEMPNO: "00012345",
                ManagerName: "萱姐",
                Attachments: ["1.jpg", "2.jpg"]
            }
            this.InfoSupports = [];
            this.InfoSupports.push(infoSupport);

        }

        Edit(): void {
            this.$state.go('infoSupport');
        }
    }

    angular.module('Aurora.ErpNext.Controllers')
        .controller('InfoSupportDetailController', InfoSupportDetailController);
}