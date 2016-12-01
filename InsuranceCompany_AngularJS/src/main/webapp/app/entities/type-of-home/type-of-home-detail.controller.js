(function() {
    'use strict';

    angular
        .module('insuranceFeApp')
        .controller('TypeOfHomeDetailController', TypeOfHomeDetailController);

    TypeOfHomeDetailController.$inject = ['$scope', '$rootScope', '$stateParams', 'previousState', 'entity', 'TypeOfHome'];

    function TypeOfHomeDetailController($scope, $rootScope, $stateParams, previousState, entity, TypeOfHome) {
        var vm = this;

        vm.typeOfHome = entity;
        vm.previousState = previousState.name;

        var unsubscribe = $rootScope.$on('insuranceFeApp:typeOfHomeUpdate', function(event, result) {
            vm.typeOfHome = result;
        });
        $scope.$on('$destroy', unsubscribe);
    }
})();
