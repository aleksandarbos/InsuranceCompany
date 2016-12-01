(function() {
    'use strict';

    angular
        .module('insuranceFeApp')
        .controller('TypeOfHomeController', TypeOfHomeController);

    TypeOfHomeController.$inject = ['$scope', '$state', 'TypeOfHome'];

    function TypeOfHomeController ($scope, $state, TypeOfHome) {
        var vm = this;

        vm.typeOfHomes = [];

        loadAll();

        function loadAll() {
            TypeOfHome.query(function(result) {
                vm.typeOfHomes = result;
            });
        }
    }
})();
