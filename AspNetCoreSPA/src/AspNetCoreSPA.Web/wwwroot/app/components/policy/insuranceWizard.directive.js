(function(){
	"use strict";
	
	angular
		.module('policyModule')
		.directive('insuranceWizardDirective', insuranceWizardDirective);
		
	userInfoDirective.$inject = ['$window'];
	function insuranceWizardDirective($window){
		
		var polisa = $window.localStorage.polisy;
		

			var userInfoDirective = {
				templateUrl: './app/policy/insuranceWizardDetails.html',
				restrict: 'E'
			}

		
		return insuranceWizardDirective;
	}
})();