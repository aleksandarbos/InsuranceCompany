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
                        templateUrl: 'app/main/main.html',
                        controller: 'MainController',
                        controllerAs: 'vm'
                    },
                    'content@main': {
                        templateUrl: 'app/components/home/home.html',
                        controller: 'HomeController',
                        controllerAs: 'vm'
                    },
                    'stepper@main': {
                        templateUrl: 'app/components/stepper/stepper.html'
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
            });
    }
})();
