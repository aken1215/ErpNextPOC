module Aurora.ErpNext.Configs {
    export class ConfigProvider implements ng.IServiceProvider {
        config: IConfig = {
            ErpNextHrApiRoot: 'http://localhost/ErpNextPocApi/api/',
        }

        setConfig(value: IConfig) {
            this.config = value;
        }

        $get(): IConfig {
            return this.config;
        }
    }

    angular.module('Aurora.ErpNext.Configs')
        .provider('Config', ConfigProvider)

}