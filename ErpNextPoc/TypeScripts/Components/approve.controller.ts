module Aurora.ErpNext.Components {
    export class ApproveController {
        static $inject = ['Config'];

        constructor(
            private config: Configs.IConfig
        ) {

        }
    }


    angular.module('Aurora.ErpNext.Components')
        .component('approve', {
            templateUrl: '/TypeScripts/Components/approve.html',
            controller: ApproveController,
            controllerAs: 'ApproveCtrl',
            bindings: {
                docno: '='
            }
        });
}

