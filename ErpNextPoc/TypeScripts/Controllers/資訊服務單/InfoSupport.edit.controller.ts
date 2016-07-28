module Aurora.ErpNext.Controllers {
    export class InfoSupportEditController {
        static $inject = ['$log','$state','InfoSupport'];

        InfoSupports:ViewModel.InfoSupportEditViewModel[];

        constructor(
            $log: ng.ILogService,
            protected $state: ng.ui.IStateService,
            public infoSupport: Aurora.ErpNext.ViewModel.InfoSupportEditViewModel

        ) {
            this.InfoSupports = [];
            this.InfoSupports.push(infoSupport);
        }

        Submit(): void {
            let infoSupport: ViewModel.InfoSupportEditViewModel = {
                Title: "",
                Context: "",
                ManagerEMPNO: "",
                ManagerName: "",
                Attachments:["",""]
            }
            this.InfoSupports.push(infoSupport);

            this.$state.go('detail', {
                Id: "test",
                Name:"Hank"
            });
        }
    }

    angular.module('Aurora.ErpNext.Controllers')
        .controller('InfoSupportEditController', InfoSupportEditController);
}