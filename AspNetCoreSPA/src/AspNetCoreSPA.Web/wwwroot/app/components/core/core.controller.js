(function () {
	"use strict";

	angular
		.module('coreModule')
		.controller('MainCtrl', MainCtrl);

	MainCtrl.$inject = ['$window', '$scope', '$q', '$timeout', '$state', '$translate', 'DroolsInfo', 'DroolsHome', 'DroolsVehicle', 'DroolsAllPackages'];
    
	function MainCtrl($window, $scope, $q, $timeout, $state, $translate, DroolsInfo, DroolsHome, DroolsVehicle, DroolsAllPackages) {

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
		var currentYear = new Date().getFullYear();

		vm.stepNo = 0;
		vm.stepNoNext = function () {
		    console.log('stepNoNext function');
		    vm.stepNo = vm.stepNo + 1;
            console.log('step'+vm.stepNo)
		    return 'step' + vm.stepNo;
		}

//		vm.states = ['insuranceWizard.chooseInsurance', 'insuranceWizard.userInfo', 'insuranceWizard.choosePackage','insuranceWizard.additionalOptions','insuranceWizard.homeInfo','insuranceWizard.vehicleInfo', 'insuranceWizard.payment'];
	//	vm.stateIdx = 0;

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
	//	    $state.go(vm.states[++vm.stateIdx]);

		}

		vm.moveToPreviousStep = function moveToPreviousStep() {
		    if (vm.selectedStep > 0) {
		        vm.selectedStep = vm.selectedStep - 1;
	//	        $state.go(vm.states[--vm.stateIdx]);
		    }
		}

        
		vm.submitCurrentStep = function submitCurrentStep(stepData, isSkip) {
		    var deferred = $q.defer();
		    vm.showBusyText = true;
		    if (stepData == 1)
		        $scope.userCount();
		    console.log('On before submit');
		    //connecting with drools
		    if (stepData == 2) {
		        $scope.sendTravelInfo();
		    }
		    //if (!stepData.completed && !isSkip) {
		    if (!isSkip) {
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
		      var brKorisnika;

		      if (vm.polisy.travelType == 'pojedinacno')
		          brKorisnika = 1;
		      else
		          brKorisnika = vm.polisy.noAdults + vm.polisy.noChildren;

		      if (brKorisnika != vm.listaKorisnika.length) {
		          vm.listaKorisnika = [];
		          for (var i = 1; i <= brKorisnika; i++) {
		              vm.listaKorisnika.push({ name: 'Jane ', surname: 'Doe' + i, myDate: '', passport: '', jmbg: '', sex: '', email: '' });
		          }
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
	         return currentYear - userYear;
	     }
	
	     $scope.sendHomeInfo = function () {
	         vm.homeInfo.chosenPackagePrice = {};
	         vm.homeInfo.age = {};
	         vm.homeInfo.insuranceDuration = {};
	         vm.homeInfo.insuranceDuration = vm.polisy.noDays;
	         vm.homeInfo.chosenPackagePrice = vm.polisy.polisyPackage;
	         vm.homeInfo.age = currentYear - vm.homeInfo.buildYear;
             /*
	         vm.homeInfo = {
	             chosenPackagePrice: vm.polisy.polisyPackage,
	             insuranceDuration:vm.polisy.noDays,
	             age: currentYear - vm.homeInfo.buildYear
	         }
             */
	         DroolsHome.save(vm.homeInfo, onsuccessHome)
	     }

	     $scope.sendVehicleInfo = function () {
	         vm.vehicleInfo.chosenPackagePrice = {};
	         vm.vehicleInfo.insuranceDuration = {};
	         vm.vehicleInfo.insuranceDuration = vm.polisy.noDays;
	         vm.vehicleInfo.chosenPackagePrice = vm.polisy.polisyPackage;
             
	       /*  vm.vehicleInfo = {
	             chosenPackagePrice: vm.polisy.noDays,
	             insuranceDuration: vm.polisy.polisyPackage
	         }
             */
             DroolsVehicle.save(vm.vehicleInfo, onsuccessVehicle)
	     }

	     $scope.sendAllPackagesPriceInfo = function () {
	         vm.packagesInfo = {
	             homeIns: vm.homeInsuranceRadio,
	             vehicleIns: vm.vehicleInsuranceRadio,
	             homeInsPrice: vm.packageHome,
	             vehicleInsPrice: vm.packageVehicle,
	             travelInsPrice: vm.polisy.polisyPackage,
                 totalPrice: ""
	         }
	         DroolsAllPackages.save(vm.packagesInfo, onsuccessAllPackages)

	     }

	     $scope.sendTravelInfo = function () {
	         vm.polisy.listOfUsers = {}
	         vm.polisy.sportBool = {}

             if (vm.polisy.riskType == 'sport')
                 vm.polisy.sportBool = true;
	         else
                 vm.polisy.sportBool = false;
	             
	         vm.polisy.listOfUsers = vm.listaKorisnika;
	         DroolsInfo.save(vm.polisy, onSaveSuccess);
	     }
           
		  
			$scope.savePolicy = function(){
				$window.localStorage.polisy = vm.polisy;
	
			}
			
		
			function onSaveSuccess(result) {
			    vm.package1 = {};
			    vm.package2 = {};
			    vm.package3 = {};
			    vm.package1 = result.packagePrice1
			    vm.package2 = result.packagePrice2
			    vm.package3 = result.packagePrice3
			}

			function onsuccessHome(result) {
			    vm.packageHome = {};
			    vm.packageHome = result.price;
			}

			function onsuccessVehicle(result) {
			    vm.packageVehicle = {};
			    vm.packageVehicle = result.price;
			}

			function onsuccessAllPackages(result) {
			    vm.finalPriceWithPotencialDiscount = {}
			    vm.finalPriceWithPotencialDiscount = result.totalPrice;
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
						    $('#myModal').modal('show');
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