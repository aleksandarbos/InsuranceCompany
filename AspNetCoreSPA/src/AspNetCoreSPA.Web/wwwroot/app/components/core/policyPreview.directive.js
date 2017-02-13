(function () {
    "use strict"

    angular.module('coreModule')
        .directive("policyPreviewDirective", policyPreviewDirective);

    policyPreviewDirective.$inject = [];
    function policyPreviewDirective() {
        return {
            templateUrl: '/app/components/stepper/polisyPreview.html'
        };
    };

})();