(function() {
    'use strict';

    angular
        .module('insuranceFeApp')
        .controller('BankController', BankController);

    BankController.$inject = ['$scope', '$state', 'Bank'];

    function BankController ($scope, $state, Bank) {
        var vm = this;

        vm.banks = [];

        loadAll();

        function loadAll() {
            Bank.getAll(function(result) {
                vm.banks = result;
            });
        }
    }
})();
