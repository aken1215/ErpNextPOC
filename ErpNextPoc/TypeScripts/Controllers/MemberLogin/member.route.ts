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
                controller: 'MemberController',
                controllerAs: 'MemberCtrl',
                resolve: {
                    Member: GetMemberData
                }
            })
            .state('member.new',
            {
                url: '/new',  
                parent:'member',
                template: '<h1>asdsa{{MemberCtrl.member}}</h1>',
                controller: 'MemberController',
                controllerAs: 'MemberCtrl',
                resolve: {
                    Member: GetMemberData
                }
            });


    }

    MemberControllerRoute.$inject = ['$stateProvider'];

    angular.module('Aurora.ErpNext.Controllers')
        .config(MemberControllerRoute);

}