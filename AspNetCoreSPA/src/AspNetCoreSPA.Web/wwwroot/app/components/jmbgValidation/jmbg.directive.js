(function () {

    "use strict";
    angular.module('coreModule')
        .directive('jmbgDirective', jmbgDirective);


    jmbgDirective.$inject = [];
    function jmbgDirective() {
       
        var jmbgDirectiveDefinition = {

            templateUrl: '/app/components/jmbgValidation/jmbg.html'
          //  restrict: 'E',
          //  scope: {
          //      formName: '='
          //  }

        };

        return jmbgDirectiveDefinition;

    };


})();






