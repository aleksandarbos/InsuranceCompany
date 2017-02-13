(function () {

    "use strict";
    angular.module('coreModule')
        .directive('birthDateDirective', birthDateDirective);
        

    birthDateDirective.$inject = [];
    function birthDateDirective(ageType) {
        console.log('directiveFunction');
   

        var birthDatePickerDirectiveDefinition = {
            templateUrl: '/app/components/datepicker/datepicker.html',
            restrict: 'E'
        }

        return birthDatePickerDirectiveDefinition;

    };


})();






