(function () {
	'use strict';

	angular
        .module('blocks.router')
		.config(['$stateProvider', '$urlRouterProvider', '$locationProvider',
			function ($stateProvider, $urlRouterProvider, $locationProvider) {
				$urlRouterProvider.otherwise('/home')
			}
		]);
})();
