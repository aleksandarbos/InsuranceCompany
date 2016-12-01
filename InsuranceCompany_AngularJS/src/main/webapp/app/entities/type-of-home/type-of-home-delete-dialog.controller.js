(function() {
    'use strict';

    angular
        .module('insuranceFeApp')
        .controller('TypeOfHomeDeleteController',TypeOfHomeDeleteController);

    TypeOfHomeDeleteController.$inject = ['$uibModalInstance', 'entity', 'TypeOfHome'];

    function TypeOfHomeDeleteController($uibModalInstance, entity, TypeOfHome) {
        var vm = this;

        vm.typeOfHome = entity;
        vm.clear = clear;
        vm.confirmDelete = confirmDelete;

        function clear () {
            $uibModalInstance.dismiss('cancel');
        }

        function confirmDelete (id) {
            TypeOfHome.delete({id: id},
                function () {
                    $uibModalInstance.close(true);
                });
        }
    }
})();
