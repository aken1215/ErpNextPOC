module Aurora.ErpNext.Controllers {
    export class InfoSupportController {
        static $inject = ['$log', 'InfoSupport', '$scope'];
        constructor(
            $log: ng.ILogService,
            public member: Aurora.ErpNext.ViewModel.MemberViewModel

        ) {

            console.log(this);
        }

        Submit(): void {
            console.log('test');
        }
    }

    angular.module('Aurora.ErpNext.Controllers')
        .controller('InfoSupportController', InfoSupportController);
}