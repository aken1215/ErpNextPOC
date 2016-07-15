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
                template: 'asas <div  ui-view></div>',
                controller: 'BaseController',
                controllerAs: 'BaseCtrl',
                resolve: {

                }
            })
            .state('member.new',
            {
                url: '/new',  
                parent:'member',
                template: '<h1>asdsa{{ MemberCtrl.member.Id }}</h1>',
                controller: 'MemberController',
                controllerAs: 'MemberCtrl',
                resolve: {
                    Member: function () {
                        return { value: 'simple!' };
                }
            });


    }

    MemberControllerRoute.$inject = ['$stateProvider'];

    angular.module('Aurora.ErpNext.Controllers')
        .config(MemberControllerRoute);

}