(function(){
	"use strict";
	
	angular
		.module('app', ['ngMaterial', 'md-steppers','ngMessages', 'coreModule', 'ui.router'])
		.config(function($mdThemingProvider) {
				$mdThemingProvider.theme('docs-dark')
				})
		.config(function($stateProvider, $urlRouterProvider) {

			 $urlRouterProvider.otherwise('/');

			 $stateProvider.state({
				name: 'destination',
				url: '/destination'
				//templateUrl: 'app/stepper/destination.html'
			 });
			 $stateProvider.state({
				name: 'package',
				url: '/package'
				//templateUrl: 'app/stepper/package.html'
			 });
			$stateProvider.state({
				name: 'userinfo',
				url: '/userinfo'
				//templateUrl: 'app/stepper/userinfo.html'
			 });
			$stateProvider.state({
				name: 'payment',
				url: '/payment'
				//templateUrl: 'app/stepper/payment.html'
			 });
		});
})();


