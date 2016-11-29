(function() {
    'use strict';

    angular
        .module('insuranceFeApp')
        .controller('TypeOfRiskDeleteController',TypeOfRiskDeleteController);

    TypeOfRiskDeleteController.$inject = ['$uibModalInstance', 'entity', 'TypeOfRisk'];

    function TypeOfRiskDeleteController($uibModalInstance, entity, TypeOfRisk) {
        var vm = this;

        vm.typeOfRisk = entity;
        vm.clear = clear;
        vm.confirmDelete = confirmDelete;

        function clear () {
            $uibModalInstance.dismiss('cancel');
        }

        function confirmDelete (id) {
            TypeOfRisk.delete({id: id},
                function () {
                    $uibModalInstance.close(true);
                });
        }
    }
})();
