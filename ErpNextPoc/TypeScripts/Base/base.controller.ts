module Aurora.ErpNext.Controllers {
    export class BaseController {
        static $inject = ['$log'];

        constructor(
        ) {
            console.log('Base');
        }
    }

    angular.module('Aurora.ErpNext.Controllers')
        .controller('BaseController', BaseController);
}