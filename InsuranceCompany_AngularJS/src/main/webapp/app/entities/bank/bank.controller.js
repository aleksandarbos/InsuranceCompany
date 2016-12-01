(function() {
    'use strict';

    angular
        .module('insuranceFeApp')
        .controller('BankController', BankController);

    BankController.$inject = ['$scope', '$state', 'Bank'];

    function BankController ($scope, $state, Bank) {

        $scope.banks = [];

        loadAll();

        function loadAll() {
            Bank.query(function(result) {
				debugger
                $scope.banks = result;
            });
        }
    }
})();
