(function () {
    "use strict"

    angular.module('coreModule')

        .directive("jmbgValidationDirective", jmbgValidationDirective);

    jmbgValidationDirective.$inject = [];
    function jmbgValidationDirective() {
        return {
            templateUrl: '/app/components/stepper/polisyPreview.html'
        };
    };

})();