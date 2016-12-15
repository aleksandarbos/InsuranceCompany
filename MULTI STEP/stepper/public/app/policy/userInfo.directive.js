(function(){
	"use strict";
	
	angular
		.module('policyModule')
		.directive('userInfoDirective', userInfoDirective);
		
	userInfoDirective.$inject = ['$window'];
	function userInfoDirective($window){
		
		var polisa = $window.localStorage.polisy;
		

			var userInfoDirective = {
				templateUrl: './app/policy/userFormDetails.html',
				restrict: 'E'
			}

		
		return userInfoDirective;
	}
})();