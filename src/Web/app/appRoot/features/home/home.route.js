(function () {
	'use strict';

	angular
	.module('appRoot.home')
	.config(['$stateProvider', function ($stateProvider) {
		$stateProvider
			.state('home', {
				url: '/home',
				templateUrl: 'app/appRoot/features/home/index/index.html'
			});
	}]);
})();
