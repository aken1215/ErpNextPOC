module Aurora.ErpNext.Controllers {
    export class MemberController {
        static $inject = ['$log', 'Member'];

        constructor(
             $log: ng.ILogService,
              member: Aurora.ErpNext.ViewModel.MemberViewModel
        ) {
            console.log(member);
        }

        Submit(): void {
            console.log('test');
        }
    }

    angular.module('Aurora.ErpNext.Controllers')
        .controller('MemberController', MemberController);
}