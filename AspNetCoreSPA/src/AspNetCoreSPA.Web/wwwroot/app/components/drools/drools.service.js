(function () {
    'use strict';
    angular
        .module('droolsModule')
        .factory('DroolsInfo', DroolsInfo);

    DroolsInfo.$inject = ['$resource'];

    function DroolsInfo($resource) {
        var resourceUrl = 'https://localhost:8443/setPackages';

        return $resource(resourceUrl, {}, {
            'query': { method: 'GET', isArray: true },
            'get': {
                method: 'GET',
                transformResponse: function (data) {
                    if (data) {
                        data = angular.fromJson(data);
                    }
                    return data;
                }
            },
            'update': { method: 'PUT' },
            'save': { method: 'POST', headers: { 'Access-Control-Allow-Origin': '*' } }
        });
    }
})();
