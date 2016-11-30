(function() {
    'use strict';

    angular
        .module('insuranceFeApp')
        .controller('TypeOfRiskDialogController', TypeOfRiskDialogController);

    TypeOfRiskDialogController.$inject = ['$timeout', '$scope', '$stateParams', '$uibModalInstance', 'entity', 'TypeOfRisk'];

    function TypeOfRiskDialogController ($timeout, $scope, $stateParams, $uibModalInstance, entity, TypeOfRisk) {
        var vm = this;

        vm.typeOfRisk = entity;
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
            if (vm.typeOfRisk.id !== null) {
                TypeOfRisk.update(vm.typeOfRisk, onSaveSuccess, onSaveError);
            } else {
				console.log(onSaveError);
                TypeOfRisk.save(vm.typeOfRisk, onSaveSuccess, onSaveError);
            }
        }

        function onSaveSuccess (result) {
            $scope.$emit('insuranceFeApp:typeOfRiskUpdate', result);
            $uibModalInstance.close(result);
            vm.isSaving = false;
        }

        function onSaveError () {
            vm.isSaving = false;
        }


    }
})();
