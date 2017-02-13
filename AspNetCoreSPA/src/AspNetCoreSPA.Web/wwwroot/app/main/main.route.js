(function () {
    'use strict';

    angular
      .module('app')
      .config(routerConfig);

    routerConfig.$inject = ['$stateProvider'];

    function routerConfig($stateProvider) {
        $stateProvider
            .state('main',
            {
                url: '/',
                views: {
                    'main': {
                        templateUrl:'app/main/main.html',
                        controller: 'MainController',
                        controllerAs: 'vm'
                    }
                }
            });

        $stateProvider
            .state('insuranceWizard',
            {
                url: '/insuranceWizard',
                views: {
                    'main': {
                        templateUrl: 'app/components/stepper/stepper.html'
                    }
                }
            })


        ;
    }
})();
