(function() {
    'use strict';

    angular
        .module('insuranceFeApp')
        .controller('BankDeleteController',BankDeleteController);

    BankDeleteController.$inject = ['$uibModalInstance', 'entity', 'Bank'];

    function BankDeleteController($uibModalInstance, entity, Bank) {
        var vm = this;

        vm.bank = entity;
        vm.clear = clear;
        vm.confirmDelete = confirmDelete;

        function clear () {
            $uibModalInstance.dismiss('cancel');
        }

        function confirmDelete (id) {
            Bank.delete({id: id},
                function () {
                    $uibModalInstance.close(true);
                });
        }
    }
})();
