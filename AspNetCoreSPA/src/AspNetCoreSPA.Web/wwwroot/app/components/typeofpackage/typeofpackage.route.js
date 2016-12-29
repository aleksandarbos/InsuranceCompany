



(function () {
    'use strict';

    angular
      .module('app')
      .config(routerConfig);

    routerConfig.$inject = ['$stateProvider'];

    function routerConfig($stateProvider) {
        $stateProvider
            .state('packages',
            {
                parent: 'main',
                url: 'TypeOfPackages',
                views: {
                    'content@main': {
                        templateUrl: 'app/components/typeofpackage/typeofpackage.html',
                        controller: 'TypeOfPackageController',
                        controllerAs: 'vm'
                    }
                }
            });
    }
})();
