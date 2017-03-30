(function() {
    'use strict';

    var core = angular.module('appRoot.core');

    core.config(toastrConfig);

    function toastrConfig(toastr) {
        toastr.options.timeOut = 4000;
        toastr.options.positionClass = 'toast-bottom-right';
    }

    var config = {
        appErrorPrefix: '[AppName Error] ', //Configure the exceptionHandler decorator
        appTitle: 'AppName'
    };

    core.value('config', config);

    core.config(configure);

    configure.$inject = ['$compileProvider', '$logProvider', 'diagnostics', 'exceptionHandlerProvider'];
    function configure ($compileProvider, $logProvider, diagnostics, exceptionHandlerProvider) {

        diagnostics.enable = false;

        $compileProvider.debugInfoEnabled(false);

        // turn debugging off/on (no info or warn)
        if ($logProvider.debugEnabled) {
            $logProvider.debugEnabled(true);
        }
        exceptionHandlerProvider.configure(config.appErrorPrefix);
    }
})();
