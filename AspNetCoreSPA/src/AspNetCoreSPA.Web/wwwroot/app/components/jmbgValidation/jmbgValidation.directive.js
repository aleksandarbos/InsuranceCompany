(function () {
    "use strict"

    angular.module('app')
        .directive("jmbgValidationDirective", jmbgValidationDirective);

    jmbgValidationDirective.$inject = [];


    function isValidJmbg(jmbg) {
        var valid;
        var K;
      
        var charArray = jmbg.split('');
        var a1 = parseInt(charArray[0]);
        var a2 = parseInt(charArray[1]);
        var a3 = parseInt(charArray[2]);
        var a4 = parseInt(charArray[3]);
        var a5 = parseInt(charArray[4]);
        var a6 = parseInt(charArray[5]);
        var a7 = parseInt(charArray[6]);
        var a8 = parseInt(charArray[7]);
        var a9 = parseInt(charArray[8]);
        var a10 = parseInt(charArray[9]);
        var a11 = parseInt(charArray[10]);
        var a12 = parseInt(charArray[11]);
        var a13 = parseInt(charArray[12]);
   
        var S = 7 * a1 + 6 * a2 + 5 * a3 + 4 * a4 + 3 * a5 + 2 * a6 + 7 * a7 + 6 * a8 + 5 * a9 + 4 * a10 + 3 * a11 + 2 * a12;
        var m = S % 11;
    
        if (m == 0) {
            K = 0;
        } else if (m == 1) {
            valid = false;
            return valid;
        } else {
            K = 11 - m;
        }

        if (a13 == K) {
            valid = true;
        } else {
            valid = false;
        }

        return valid;

    }

    function jmbgValidationDirective() {
        return {
            restrict: 'A',
            require: 'ngModel',
            link: function (scope, elem, attr, ngModel) {
                var valid = false;
               
                ngModel.$validators.invalidJmbg = function (modelValue, viewValue) {
                 //   console.log('nije usao u if' + isValidJmbg(viewValue));
                    if (isValidJmbg(viewValue)) {
               //         console.log('usao u if' + isValidJmbg(viewValue));
                        valid = true;
                    }

                    if (viewValue.length != 13) {
                        valid = false;
                    }

                    return valid;
                }
            }
        };
    };

})();