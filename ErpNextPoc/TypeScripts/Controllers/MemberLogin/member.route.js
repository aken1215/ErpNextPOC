var Aurora;
(function (Aurora) {
    var ErpNext;
    (function (ErpNext) {
        var Controllers;
        (function (Controllers) {
            function GetMemberData($q, $stateParams, MemberService) {
                var deferred = $q.defer();
                MemberService.GetMember()
                    .success(function (data) {
                    deferred.resolve(data);
                });
                return deferred.promise;
            }
            GetMemberData.$inject = ['$q', '$stateParams', 'MemberService'];
            function MemberControllerRoute($stateProvider) {
                $stateProvider
                    .state('member', {
                    abstract: true,
                    url: '/member',
                    templateUrl: 'TypeScripts/Controllers/MemberLogin/member.base.html',
                    controller: 'BaseController',
                    controllerAs: 'BaseCtrl',
                    resolve: {}
                })
                    .state('member.new', {
                    url: '/new',
                    parent: 'member',
                    templateUrl: 'TypeScripts/Controllers/MemberLogin/member.html',
                    controller: 'MemberController',
                    controllerAs: 'MemberCtrl',
                    resolve: {
                        Member: GetMemberData
                    }
                })
                    .
                        state('member.new.old', {
                    url: '/old',
                    parent: 'member.new',
                    template: '<div>memberOld</div>',
                    controller: 'MemberController',
                    controllerAs: 'MemberOldCtrl',
                    resolve: {
                        Member: GetMemberData
                    }
                });
            }
            MemberControllerRoute.$inject = ['$stateProvider'];
            angular.module('Aurora.ErpNext.Controllers')
                .config(MemberControllerRoute);
        })(Controllers = ErpNext.Controllers || (ErpNext.Controllers = {}));
    })(ErpNext = Aurora.ErpNext || (Aurora.ErpNext = {}));
})(Aurora || (Aurora = {}));
//# sourceMappingURL=member.route.js.map