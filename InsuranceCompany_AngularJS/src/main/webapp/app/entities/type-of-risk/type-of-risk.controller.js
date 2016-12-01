	(function() {
    'use strict';

    angular
        .module('insuranceFeApp')
        .controller('TypeOfRiskController', TypeOfRiskController);

    TypeOfRiskController.$inject = ['$scope', '$state', 'TypeOfRisk'];

    function TypeOfRiskController ($scope, $state, TypeOfRisk) {
        var vm = this;

        vm.typeOfRisks = [];

        loadAll();

        function loadAll() {
            TypeOfRisk.query(function(result) {
				alert("result is: " + result)
                vm.typeOfRisks = result;
            });
        }
    }
})();
