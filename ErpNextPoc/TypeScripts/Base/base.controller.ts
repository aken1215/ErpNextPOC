module Aurora.ErpNext.Controllers {
    export class BaseController {
        static $inject = ['$log'];

        constructor(
        ) {
  
        }
    }

    angular.module('Aurora.ErpNext.Controllers')
        .controller('BaseController', BaseController);
}