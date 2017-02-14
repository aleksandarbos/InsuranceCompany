(function () {
    'use strict';

    angular
        .module('app',
        [
            'apiMock',
            'ngAria',
            'ngMessages',
            'ngAnimate',
            'ngMaterial',
            'md-steppers',
            'angular-loading-bar',
            'ngStorage',
            'ui.router',
            'site',
            'coreModule',
            'policyModule',
            'droolsModule',
            'stateOfOriginModule',
            'sportModule',
            'travelPurposeModule'
        ]);

    angular
        .module('app')
        .config(mockConfig);

    angular
        .module('app')
        .run(runBlock);

    runBlock.$inject = ['$rootScope', '$templateCache', '$state'];

    function runBlock($rootScope, $templateCache, $state) {
        $rootScope.$on('$viewContentLoaded', function () {
            $templateCache.removeAll();
        });

        $rootScope.$on('$stateChangeStart', function (e, toState, toParams, fromState, fromParams) {
            /*
            var isLogin = toState.name === "login";
            var athenticated = auth0Service.isAuthenticated();
            if (isLogin) {
                if (athenticated) {
                    e.preventDefault();
                    $state.go(fromState.name);
                } else {
                    return;
                }
            }

            if (!athenticated) {
                // stop current execution
                e.preventDefault();

                // go to login
                $state.go('login');
            }
            */
        });
    }

    mockConfig.$inject = ['apiMockProvider'];

    function mockConfig(apiMockProvider) {
        apiMockProvider.config({
            mockDataPath: 'app/mock_data',
            apiPath: 'api'
        });
    }
})();
