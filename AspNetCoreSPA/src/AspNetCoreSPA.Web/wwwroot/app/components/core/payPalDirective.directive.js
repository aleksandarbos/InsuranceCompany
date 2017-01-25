(function () {
    "use strict"

    angular.module('coreModule')
        .directive("payPalDirective", payPalDirective);

    payPalDirective.$inject = [];
    function payPalDirective() {
        return {
            template: '<div id="paypal-button"></div>'
        };
    };

})();