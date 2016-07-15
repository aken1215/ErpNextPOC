module Aurora.ErpNext.Controllers {
    export class MemberController {
        static $inject = ['$log', 'Member','$scope'];
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
        .controller('MemberController', MemberController);
}