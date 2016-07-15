var Aurora;
(function (Aurora) {
    var ErpNext;
    (function (ErpNext) {
        var Configs;
        (function (Configs) {
            var ConfigProvider = (function () {
                function ConfigProvider() {
                    this.config = {
                        ErpNextHrApiRoot: 'http://localhost/ErpNextPocApi/api/',
                    };
                }
                ConfigProvider.prototype.setConfig = function (value) {
                    this.config = value;
                };
                ConfigProvider.prototype.$get = function () {
                    return this.config;
                };
                return ConfigProvider;
            }());
            Configs.ConfigProvider = ConfigProvider;
            angular.module('Aurora.ErpNext.Configs')
                .provider('Config', ConfigProvider);
        })(Configs = ErpNext.Configs || (ErpNext.Configs = {}));
    })(ErpNext = Aurora.ErpNext || (Aurora.ErpNext = {}));
})(Aurora || (Aurora = {}));
