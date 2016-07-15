var Aurora;
(function (Aurora) {
    var ErpNext;
    (function (ErpNext) {
        var Services;
        (function (Services) {
            var MemberService = (function () {
                function MemberService($http, config) {
                    this.$http = $http;
                    this.config = config;
                }
                MemberService.prototype.GetMember = function () {
                    var url = this.config.ErpNextHrApiRoot + "/Member/";
                    return this.$http.get(url);
                };
                MemberService.$inject = ['$http', 'Config'];
                return MemberService;
            }());
            Services.MemberService = MemberService;
            angular.module('Aurora.ErpNext.Services')
                .service('MemberService', MemberService);
        })(Services = ErpNext.Services || (ErpNext.Services = {}));
    })(ErpNext = Aurora.ErpNext || (Aurora.ErpNext = {}));
})(Aurora || (Aurora = {}));
