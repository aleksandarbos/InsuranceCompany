(function () {
    'use strict';

    angular
        .module('app')
        .config(function ($mdDateLocaleProvider, $compileProvider, $mdThemingProvider) {
            $mdDateLocaleProvider.firstDayOfWeek = 1;
            


            $compileProvider.preAssignBindingsEnabled(true);

            var darkBlueMap = $mdThemingProvider.extendPalette('indigo', {
                '500': '#274474',
                'contrastDefaultColor': 'light'
            });

            $mdThemingProvider.definePalette('darkBlue', darkBlueMap);

            $mdThemingProvider.theme('default')
                .primaryPalette('darkBlue')
                .accentPalette('orange');







        });

        
})();


