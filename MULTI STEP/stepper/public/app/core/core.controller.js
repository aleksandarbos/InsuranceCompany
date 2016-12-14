(function(){
	"use strict";
	
	angular
		.module('coreModule')
		.controller('MainCtrl', MainCtrl);
		
		MainCtrl.$inject = ['$scope', '$q', '$timeout'];
		function MainCtrl($scope, $q, $timeout){
			
			var vm = this;
			$scope.myDate = new Date();


		$scope.choices = [];
		  
		  $scope.addNewChoice = function() {
			var newItemNo = $scope.choices.length+1;
			$scope.choices.push($scope.choices.length);
		  };
			
		  $scope.removeChoice = function() {
			var lastItem = $scope.choices.length-1;
			$scope.choices.splice(lastItem);
		  };



		vm.selectedStep = 0;
		vm.stepProgress = 1;
		vm.maxStep = 6;
		vm.showBusyText = false;
		vm.stepData = [
			{ step: 1, completed: false, optional: false, data: {} },
			{ step: 2, completed: false, optional: false, data: {} },
			{ step: 3, completed: false, optional: false, data: {} },
			,
			{ step: 4, completed: false, optional: false, data: {} },
			,
			{ step: 5, completed: false, optional: false, data: {} },
			,
			{ step: 6, completed: false, optional: false, data: {} },
		];

		vm.enableNextStep = function nextStep() {
			//do not exceed into max step
			if (vm.selectedStep >= vm.maxStep) {
				return;
			}
			//do not increment vm.stepProgress when submitting from previously completed step
			if (vm.selectedStep === vm.stepProgress - 1) {
				vm.stepProgress = vm.stepProgress + 1;
			}
			vm.selectedStep = vm.selectedStep + 1;
		}

		vm.moveToPreviousStep = function moveToPreviousStep() {
			if (vm.selectedStep > 0) {
				vm.selectedStep = vm.selectedStep - 1;
			}
		}

		vm.submitCurrentStep = function submitCurrentStep(stepData, isSkip) {
			var deferred = $q.defer();
			vm.showBusyText = true;
			console.log('On before submit');
			//if (!stepData.completed && !isSkip) {
				if(!isSkip){
				//simulate $http
				$timeout(function () {
					vm.showBusyText = false;
					console.log('On submit success');
					deferred.resolve({ status: 200, statusText: 'success', data: {} });
					//move to next step when success
				   // stepData.completed = true;
					vm.enableNextStep();
				}, 1000)
			} else {
				vm.showBusyText = false;
				vm.enableNextStep();
			}
		}

			}
	
})();