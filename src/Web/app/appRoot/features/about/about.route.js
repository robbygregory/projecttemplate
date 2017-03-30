(function () {
	'use strict';

	angular
	.module('appRoot.about')
	.config(['$stateProvider', function ($stateProvider) {
		$stateProvider
			.state('about', {
				url: '/about',
				abstract: true,
				templateUrl: 'app/appRoot/features/about/aboutWrapper.html'
			})
			.state('about.foo', {
				url: '/foo',
				views: {
					aboutContent: {
						templateUrl: 'app/appRoot/features/about/foo/index.html'
					}
				}
			})
			.state('about.bar', {
				url: '/bar',
				views: {
					aboutContent: {
						templateUrl: 'app/appRoot/features/about/bar/index.html'
					}
				}
			})
	}]);
})();
