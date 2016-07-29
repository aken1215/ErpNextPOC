var Aurora;
(function (Aurora) {
    var ErpNext;
    (function (ErpNext) {
        var Controllers;
        (function (Controllers) {
            var MemberController = (function () {
                function MemberController($log, member) {
                    this.member = member;
                    console.log(this);
                }
                MemberController.prototype.Submit = function () {
                    console.log('test');
                };
                MemberController.$inject = ['$log', 'Member', '$scope'];
                return MemberController;
            }());
            Controllers.MemberController = MemberController;
            angular.module('Aurora.ErpNext.Controllers')
                .controller('MemberController', MemberController);
        })(Controllers = ErpNext.Controllers || (ErpNext.Controllers = {}));
    })(ErpNext = Aurora.ErpNext || (Aurora.ErpNext = {}));
})(Aurora || (Aurora = {}));
//# sourceMappingURL=member.controller.js.map