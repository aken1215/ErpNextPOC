module Aurora.ErpNext.Controllers {

    function GetMemberData($q: ng.IQService,
        $stateParams: ng.ui.IStateParamsService,
        MemberService: Services.MemberService) 
        {
            var deferred = $q.defer();

            MemberService.GetMember()
                .success((data) => {
                deferred.resolve(data);
            });

        return deferred.promise;
    }

    GetMemberData.$inject = ['$q', '$stateParams','MemberService'];

    function MemberControllerRoute($stateProvider: angular.ui.IStateProvider) {
        $stateProvider
            .state('member',
            {
                abstract:true,
                url: '/member',
                templateUrl: 'TypeScripts/Controllers/MemberLogin/member.base.html',
                controller: 'BaseController',
                controllerAs: 'BaseCtrl',
                resolve: {
                  
                }
            })
            .state('member.new',
            {
                url: '/new',  
                parent:'member',
                templateUrl: 'TypeScripts/Controllers/MemberLogin/member.base.html',
                controller: 'MemberController',
                controllerAs: 'MemberCtrl',
                resolve: {
                    Member: GetMemberData
                }
            })
            .
            state('member.new.old',
            {
                url: '/old',
                parent: 'member.new',
                template: '<div>memberOld</div>',
                controller: 'MemberController',
                controllerAs: 'MemberOldCtrl',
                resolve: {
                    Member: GetMemberData
                }
            })


    }

    MemberControllerRoute.$inject = ['$stateProvider'];

    angular.module('Aurora.ErpNext.Controllers')
        .config(MemberControllerRoute);

}