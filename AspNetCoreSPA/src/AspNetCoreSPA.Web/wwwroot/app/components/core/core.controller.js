(function () {
	"use strict";

	angular
		.module('coreModule')
		.controller('MainCtrl', MainCtrl)
        .config(function($mdDateLocaleProvider, $compileProvider, $mdThemingProvider){
            $mdDateLocaleProvider.firstDayOfWeek = 1;
            $compileProvider.preAssignBindingsEnabled(true);

            var darkBlueMap = $mdThemingProvider.extendPalette('indigo', {
                '500': '#274474',
                'contrastDefaultColor': 'light'
            });

            $mdThemingProvider.definePalette('darkBlue', darkBlueMap);

            $mdThemingProvider.theme('default')
                .primaryPalette('darkBlue')
                .accentPalette('orange');
        });
	MainCtrl.$inject = ['$window', '$scope', '$q', '$timeout', '$state', '$translate', 'DroolsInfo'];
    
	function MainCtrl($window, $scope, $q, $timeout, $state, $translate, DroolsInfo) {

	    $scope.myDate = new Date();
	    $scope.minDate = new Date(
            $scope.myDate.getFullYear(),
            $scope.myDate.getMonth(),
            $scope.myDate.getDate() + 1);

	    $scope.maxDateBirth = new Date(
                $scope.myDate.getFullYear() - 18,
                $scope.myDate.getMonth(),
                $scope.myDate.getDate()
            );
        

            $scope.changeLanguage = function (langKey) {
                $translate.use(langKey);
                //odraditi poziv i dodeliti ng modelu za odredjene entite
             };


		var vm = this;
		$scope.choices = [];
		vm.listaKorisnika = [];


		vm.stepNo = 0;
		vm.stepNoNext = function () {
		    console.log('stepNoNext function');
		    vm.stepNo = vm.stepNo + 1;
            console.log('step'+vm.stepNo)
		    return 'step' + vm.stepNo;
		}

		vm.states = ['destination', 'userinfo', 'package', 'payment'];
		vm.stateIdx = 0;
		vm.currentUser;
		

		$scope.addNewChoice = function () {
			var newItemNo = $scope.choices.length + 1;
			$scope.choices.push($scope.choices.length);
		};

		$scope.removeChoice = function () {
			var lastItem = $scope.choices.length - 1;
			$scope.choices.splice(lastItem);
		};



		  $scope.userCount = function(){
		      var brKorisnika = vm.polisy.noAdults + vm.polisy.noChildren;
		      
			  		  
			  for(var i=1; i<=brKorisnika; i++){
				  vm.listaKorisnika.push({name: 'Jane ', surname: 'Doe'+i, myDate: '', passport: '', jmbg: '', sex: '', email: ''});
			  }
			  vm.currentUser = vm.listaKorisnika[0];
			  vm.currentUserIndex = 0;
			
              
		  }

		  $scope.saveUser = function () {
		      vm.currentUser.age = [];
		      vm.currentUser.age = $scope.calculateAge(vm.currentUser.myDate);
		      vm.listaKorisnika[vm.currentUserIndex] = vm.currentUser;
		  }

	     $scope.nextUser = function () {
	         $scope.saveUser();
	         vm.currentUserIndex++;
		     vm.currentUser = vm.listaKorisnika[vm.currentUserIndex];
            
	     }

	     $scope.editUser = function (index) {
	         console.log(index);
	         vm.currentUserIndex = index;
	         vm.currentUser = vm.listaKorisnika[index];
	     }

	     $scope.calculateAge = function (year) {
	         var userYear = year.getFullYear();
	         var currentYear = new Date().getFullYear();
	         return currentYear - userYear;
	     }
	

           
		  
			$scope.savePolicy = function(){
				$window.localStorage.polisy = vm.polisy;
	
			}
			
			vm.selectedStep = 0;
			vm.stepProgress = 1;
			vm.maxStep = 7;
			vm.showBusyText = false;
			vm.stepData = [
				{ step: 1, completed: false, optional: false, data: {} },
				{ step: 2, completed: false, optional: false, data: {} },
				{ step: 3, completed: false, optional: false, data: {} },
				{ step: 4, completed: false, optional: false, data: {} },
                { step: 5, completed: false, optional: false, data: {} },
                { step: 6, completed: false, optional: false, data: {} },
                { step: 7, completed: false, optional: false, data: {} }
              

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
			$state.go(vm.states[++vm.stateIdx]);
			
		}

		vm.moveToPreviousStep = function moveToPreviousStep() {
			if (vm.selectedStep > 0) {
				vm.selectedStep = vm.selectedStep - 1;
				$state.go(vm.states[--vm.stateIdx]);
			}
		}

			vm.submitCurrentStep = function submitCurrentStep(stepData, isSkip) {
				var deferred = $q.defer();
				vm.showBusyText = true;
                if(stepData == 1)
				    $scope.userCount();
				console.log('On before submit');
                //connecting with drools
				if (stepData == 2) {
				    vm.polisy.listOfUsers = [];
				    vm.polisy.listOfUsers = vm.listaKorisnika;
				    DroolsInfo.save(vm.polisy, onSaveSuccess);
				}
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
					}, 2000)
				} else {
					vm.showBusyText = false;
					vm.enableNextStep();
				}
			}
		
			function onSaveSuccess(result) {
			    vm.package1 = {};
			    vm.package2 = {};
			    vm.package3 = {};
			    vm.package1 = result.packagePrice1
			    vm.package2 = result.packagePrice2
			    vm.package3 = result.packagePrice3
			}


			 paypal.Button.render({

					env: 'sandbox', // Specify 'sandbox' for the test environment //'production'

					style: {
						size: 'small',
						color: 'blue',
						shape: 'pill'
					},

					 client: {
								sandbox:    'AUlcGuyTEzEq-YB7nmrCi8MDumqrghQIlID387O1SFkEyVNSDvXoB7gpapZdDcSUmK5z_n6tQUcBWPa7',
								production: 'xxxxxxxxx'
					 },

					//TODO - redirections
					//https://developer.paypal.com/docs/integration/direct/express-checkout/integration-jsv4/script-options/

					payment: function() {
						// Set up the payment here, when the buyer clicks on the button

						 var env    = this.props.env;
						 var client = this.props.client;

						return paypal.rest.payment.create(env, client, {
							transactions: [
								{
								    amount: { total: vm.polisy.polisyPackage, currency: 'USD' }
								}
							]
						});

					},


					//commit: true, // Optional: show a 'Pay Now' button in the checkout flow

					onAuthorize: function(data, actions) {
						// Execute the payment here, when the buyer approves the transaction
						// Optional: display a confirmation page here
						return actions.payment.execute().then(function() {
							// Show a success page to the buyer
							console.log(">>> SUCCESS!");
							console.log(data);



						});

				   },

					onCancel: function(data, actions) {
						 // Show a cancel page or return to cart
						console.log(">>> CANCELED!");
						console.log(data);
					}

				}, '.paypal-button');
			
		}
	
})();