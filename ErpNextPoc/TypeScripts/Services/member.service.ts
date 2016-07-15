module Aurora.ErpNext.Services {
    export class MemberService {
        static $inject = ['$http','Config']

        constructor(
            private $http: ng.IHttpService,
            private config: Configs.IConfig

        ) {
        }

        GetMember(): ng.IHttpPromise<ViewModel.MemberViewModel> {
            var url = `${this.config.ErpNextHrApiRoot}/Member/`;
                return this.$http.get<ViewModel.MemberViewModel>(url);
            }
    }

    angular.module('Aurora.ErpNext.Services')
        .service('MemberService', MemberService);
}