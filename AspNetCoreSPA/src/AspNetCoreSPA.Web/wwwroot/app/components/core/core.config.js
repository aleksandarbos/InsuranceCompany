(function () {
    'use strict';

    angular
        .module('coreModule')
        .config(['$mdDateLocaleProvider', '$compileProvider', '$mdThemingProvider', function ($mdDateLocaleProvider, $compileProvider, $mdThemingProvider) {
            //config date
            $mdDateLocaleProvider.firstDayOfWeek = 1;
            $mdDateLocaleProvider.firstRenderableDate = new Date(1800, 1, 1);


            $compileProvider.preAssignBindingsEnabled(true);
            //config theme
            var darkBlueMap = $mdThemingProvider.extendPalette('indigo', {
                '500': '#274474',
                'contrastDefaultColor': 'light'
            });

            $mdThemingProvider.definePalette('darkBlue', darkBlueMap);

            $mdThemingProvider.theme('default')
                .primaryPalette('darkBlue')
                .accentPalette('orange');

        }]);

        
})();


