(function() {
    'use strict';

    angular
        .module('insuranceFeApp')
        .controller('TypeOfHomeDialogController', TypeOfHomeDialogController);

    TypeOfHomeDialogController.$inject = ['$timeout', '$scope', '$stateParams', '$uibModalInstance', 'entity', 'TypeOfHome'];

    function TypeOfHomeDialogController ($timeout, $scope, $stateParams, $uibModalInstance, entity, TypeOfHome) {
        var vm = this;

        vm.typeOfHome = entity;
        vm.clear = clear;
        vm.save = save;

        $timeout(function (){
            angular.element('.form-group:eq(1)>input').focus();
        });

        function clear () {
            $uibModalInstance.dismiss('cancel');
        }

        function save () {
            vm.isSaving = true;
            if (vm.typeOfHome.id !== null) {
                TypeOfHome.update(vm.typeOfHome, onSaveSuccess, onSaveError);
            } else {
                TypeOfHome.save(vm.typeOfHome, onSaveSuccess, onSaveError);
            }
        }

        function onSaveSuccess (result) {
            $scope.$emit('insuranceFeApp:typeOfHomeUpdate', result);
            $uibModalInstance.close(result);
            vm.isSaving = false;
        }

        function onSaveError () {
            vm.isSaving = false;
        }


    }
})();
