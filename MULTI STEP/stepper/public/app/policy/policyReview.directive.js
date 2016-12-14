(function(){
	"use strict";
	
	angular
		.module('policyModule')
		.directive('policyReviewDirective', policyReviewDirective);
		
		policyReviewDirective.$inject = ['$window']
		function policyReviewDirective($window){
			var policyReviewDirective = {
				template: '<ul class=\"list-group\">' +
						'<li class=\"list-group-item\">{{vm.polisa.paket}}</li></ul>',
				restrict: 'E'
			}
			return policyReviewDirective;
		}
})();