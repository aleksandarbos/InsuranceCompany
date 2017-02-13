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
	MainCtrl.$inject = ['$window', '$scope', '$q', '$timeout', '$state', '$translate', 'DroolsInfo', 'DroolsHome', 'DroolsVehicle', 'DroolsAllPackages','PolicyService','ClientService','DestinationService','HouseService','CarService'];

	function MainCtrl($window, $scope, $q, $timeout, $state, $translate, DroolsInfo, DroolsHome, DroolsVehicle, DroolsAllPackages,PolicyService,ClientService,DestinationService,HouseService,CarService) {

		$scope.myDate = new Date();
		$scope.minDate = new Date(
			$scope.myDate.getFullYear(),
			$scope.myDate.getMonth(),
			$scope.myDate.getDate() + 1);

	    $scope.maxDate = new Date(
            $scope.myDate.getFullYear() - 18,
            $scope.myDate.getMonth(),
            $scope.myDate.getDate() + 1);

	  

	    $scope.maxDateAdult = new Date(
                $scope.myDate.getFullYear() - 18,
                $scope.myDate.getMonth(),
                $scope.myDate.getDate()
        );
        
           
	    $scope.changeLanguage = function (langKey) {
	        $translate.use(langKey);
	        //odraditi poziv i dodeliti ng modelu za odredjene entite
	    };

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

        vm.setPackage1Selected = function setPackage1Selected(){
            vm.package1Selected = true;
            vm.package2Selected = false;
            vm.package3Selected = false;
        }

	    vm.setPackage2Selected = function setPackage2Selected() {
	    	vm.package1Selected = false;
	    	vm.package2Selected = true;
	    	vm.package3Selected = false;
	    }

	    vm.setPackage3Selected = function setPackage3Selected() {
	    	vm.package1Selected = false;
	    	vm.package2Selected = false;
	    	vm.package3Selected = true;
	    }

	    vm.setUserPrice = function setUserPrice() {
	    	for (var person in vm.polisy.listOfUsers)
	    		if( vm.package1Selected)
	    			vm.polisy.listOfUsers[person].chosenPackagePrice = vm.polisy.listOfUsers[person].price1
	    		else if (vm.package2Selected)
	    			vm.polisy.listOfUsers[person].chosenPackagePrice = vm.polisy.listOfUsers[person].price2
	    		else if (vm.package3Selected)
	    			vm.polisy.listOfUsers[person].chosenPackagePrice = vm.polisy.listOfUsers[person].price3
	    	}

        vm.checkradiobutton = function checkradiobutton(){
            console.log(vm.homeInsuranceRadio)
            console.log(vm.vehicleInsuranceRadio)
        }

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

		      if (vm.polisy.travelType == 'pojedinacno') {
		          brKorisnika = 1;
		          vm.listaKorisnika = [];
		          vm.listaKorisnika.push({ name: 'Jane', surname: 'Doe', myDate: '', passport: '', jmbg: '', sex: '', email: '', ageType: 'adult' });
		      }
		      else
		          brKorisnika = vm.polisy.noAdults + vm.polisy.noChildren;

		      if (brKorisnika != vm.listaKorisnika.length) {
		          vm.listaKorisnika = [];
		          for (var i = 1; i <= vm.polisy.noAdults; i++) {
		              vm.listaKorisnika.push({ name: 'Jane ', surname: 'Doe' + i, myDate: '', passport: '', jmbg: '', sex: '', email: '', ageType:'adult' });
		          }
		          for (var i = 1; i <= vm.polisy.noChildren; i++) {
		              vm.listaKorisnika.push({ name: 'Jacy ', surname: 'Doe' + i, myDate: '', passport: '', jmbg: '', sex: '', email: '', ageType:'child' });
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

	    		DroolsHome.save(vm.homeInfo, onsuccessHome)
	    	}

	    	$scope.sendVehicleInfo = function () {
	    		vm.vehicleInfo.chosenPackagePrice = {};
	    		vm.vehicleInfo.insuranceDuration = {};
	    		vm.vehicleInfo.insuranceDuration = vm.polisy.noDays;
	    		vm.vehicleInfo.chosenPackagePrice = vm.polisy.polisyPackage;

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







	    		var finalListaKorisnika=[];
	    		var ClientNavigation={};
	    		var i=0
	    		var idMain=0;
	    		var listaKljuceva=[];
	    		/*for(i=0;i<vm.listaKorisnika.length;i++)
	    		{
	    			var client={};
	    			client.Firstname=vm.listaKorisnika[i].name;
	    			client.Lastname=vm.listaKorisnika[i].surname;
	    			client.DateOfBirth=vm.listaKorisnika[i].myDate;
	    			client.Jmbg=vm.listaKorisnika[i].jmbg;
	    			client.PassportNumber=vm.listaKorisnika[i].passport;
	    			client.Sex=vm.listaKorisnika[i].sex;
	    			console.log(client);

	    			if(i===0){

	    				ClientService.post(client).then(function(res){
	    					idMain=res.data;
	    					console.log("Prvi")
	    					console.log(res.data)

	    				},function(res){


	    				});

	    			}else{
	    				ClientService.post(client).then(function(res){
	    					listaKljuceva.push(res.data);
						console.log("Drugi")
	    					
						console.log(res.data)

	    				},function(res){

	    				});

	    			}
	    			console.log(idMain);

	    		}*/
	    		var finalCar={};
	    		finalCar.ClientId=19;
	    		finalCar.Year=vm.vehicleInfo.productionYear;
	    		finalCar.ChassisNumber=vm.vehicleInfo.chassis;
	    		finalCar.LicencePlate=vm.vehicleInfo.serialNo;
	    		finalCar.CarStartDate=vm.polisy.date;
	    		finalCar.CarEndDate=vm.polisy.date;
	    		console.log(finalCar)
	    		console.log("Car")
	    		//finalCar.CarEndDate.setTime( vm.polisy.date.getTime() + vm.polisy.noDays * 86400000 );
	    		//var idCar=0;

	    		CarService.post(finalCar).then(function(res){

	    			idCar=res.data;
	    		},function(res){

	    		});


	    		/*var finalHouse={};
	    		finalHouse.HomeSquares=vm.homeInfo.flatSize;
	    		finalHouse.HomeBuildingYear=vm.homeInfo.buildYear;
	    		finalHouse.HomeAddress=vm.homeInfo.address;
	    		finalHouse.HomeValue=vm.homeInfo.estimatedValue;
	    		finalHouse.HomeStartDate=vm.polisy.date;
	    		finalHouse.HomeEndDate=vm.polisy.date;
	    		finalHouse.HomeEndDate.setTime( vm.polisy.date.getTime() + vm.polisy.noDays * 86400000 );
	    		var idHouse=0;
	    		/*HouseService.post(finalHouse).then(function(res){

	    			idHouse=res.data;
	    		},function(res){

	    		});*/

	    	/*	var finalDestination={};
	    		finalDestination.St=vm.polisy.destination;
	    		finalDestination.DstDays=vm.polisy.noDays;


	    		var finalSubjectOfInsurance={};
	    		finalSubjectOfInsurance.Car=finalCar;
	    		finalSubjectOfInsurance.Home=finalHouse;
	    		finalSubjectOfInsurance.Tp=vm.polisy.riskType;
	    		finalSubjectOfInsurance.Dst=finalDestination;


	    		var finalPolicy={};
	    		finalPolicy.R=vm.polisy.sport;
	    		finalPolicy.Client=finalListaKorisnika;
	    		finalPolicy.ClientNavigation=ClientNavigation;
	    		finalPolicy.Ii=finalSubjectOfInsurance;
	    		finalPolicy.Package=vm.polisy.polisyPackage;





	    		console.log(finalPolicy)

	    		/*PolicyService.post(finalPolicy).then(function(response){
	    			alert("Uspelo")
	    		},function(response){
	    			alert("Nije uspelo")
	    		})
*/






















	    	}

	    	$scope.sendTravelInfo = function () {
	    		vm.polisy.listOfUsers = {}
	    		vm.polisy.sportBool = {}
	     $scope.sendTravelInfo = function () {
	         vm.polisy.listOfUsers = {}
	         vm.polisy.sportBool = {}
	         vm.polisy.noDays = {}
	         var oneDay = 24 * 60 * 60 * 1000;

             if (vm.polisy.riskType == 'sport')
                 vm.polisy.sportBool = true;
	         else
                 vm.polisy.sportBool = false;

             var startDate = new Date(vm.polisy.date)
             var endDate = new Date(vm.polisy.endDate)

             vm.polisy.noDays = Math.ceil(Math.abs(startDate - endDate)) / oneDay + 1;
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
				vm.polisy = result;
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