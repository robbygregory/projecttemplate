(function() {
    'use strict';

    angular
        .module('appRoot.core')
		.config(['$stateProvider', function ($stateProvider) { 
			$stateProvider
				.state('404', {
					url: '/404',
					templateUrl: 'app/appRoot/core/404.html'
				});
		}]);



    //    .run(appRun);

    ///* @ngInject */
    //function appRun(routerHelper) {
    //    var otherwise = '/404';
    //    routerHelper.configureStates(getStates(), otherwise);
    //}

    //function getStates() {
    //    return [
    //        {
    //            state: '404',
    //            config: {
    //                url: '/404',
    //                templateUrl: './app/appRoot/core/404.html',
    //                title: '404'
    //            }
    //        }
    //    ];
    //}
})();
