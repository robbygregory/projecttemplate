(function() {
    'use strict';

    angular
        .module('appRoot.core', [
			/* Angular modules */
            'ngAnimate',
            'ngSanitize',
			'ngAria',

			/* Cross-app modules */
            'blocks.diagnostics',
            'blocks.exception',
            'blocks.logger',
            'blocks.router',

			/* 3rd-party modules */
            'ui.router',
            'ngplus'
        ]);

})();
