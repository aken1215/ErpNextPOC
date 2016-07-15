var Aurora;
(function (Aurora) {
    var ErpNext;
    (function (ErpNext) {
        var Components;
        (function (Components) {
            var ApproveController = (function () {
                function ApproveController(config) {
                    this.config = config;
                }
                ApproveController.$inject = ['Config'];
                return ApproveController;
            }());
            Components.ApproveController = ApproveController;
            angular.module('Aurora.ErpNext.Components')
                .component('approve', {
                templateUrl: '/TypeScripts/Components/approve.html',
                controller: ApproveController,
                controllerAs: 'ApproveCtrl',
                bindings: {
                    docno: '='
                }
            });
        })(Components = ErpNext.Components || (ErpNext.Components = {}));
    })(ErpNext = Aurora.ErpNext || (Aurora.ErpNext = {}));
})(Aurora || (Aurora = {}));
