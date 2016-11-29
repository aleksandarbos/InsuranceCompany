(function() {
    'use strict';

    angular
        .module('insuranceFeApp')
        .controller('TypeOfRiskDetailController', TypeOfRiskDetailController);

    TypeOfRiskDetailController.$inject = ['$scope', '$rootScope', '$stateParams', 'previousState', 'entity', 'TypeOfRisk'];

    function TypeOfRiskDetailController($scope, $rootScope, $stateParams, previousState, entity, TypeOfRisk) {
        var vm = this;

        vm.typeOfRisk = entity;
        vm.previousState = previousState.name;

        var unsubscribe = $rootScope.$on('insuranceFeApp:typeOfRiskUpdate', function(event, result) {
            vm.typeOfRisk = result;
        });
        $scope.$on('$destroy', unsubscribe);
    }
})();
