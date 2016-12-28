



(function () {
    'use strict';

    angular
      .module('app')
      .config(routerConfig);

    routerConfig.$inject = ['$stateProvider'];

    function routerConfig($stateProvider) {
        $stateProvider
            .state('states',
            {
                parent: 'main',
                url: 'State',
                views: {
                    'content@main': {
                        templateUrl: 'app/components/states/states.html',
                        controller: 'StatesController',
                        controllerAs: 'vm'
                    }
                }
            });
    }
})();
