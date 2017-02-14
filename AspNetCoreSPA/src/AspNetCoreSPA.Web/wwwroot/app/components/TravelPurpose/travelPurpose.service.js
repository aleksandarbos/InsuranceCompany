(function () {
    'use strict';
    angular
        .module('travelPurposeModule')
        .factory('travelPurpose', travelPurpose);

    travelPurpose.$inject = ['$resource'];

    function travelPurpose($resource) {
        var resourceUrl = 'https://localhost:8443/travelPurpose/getAll';

        return $resource(resourceUrl, {}, {
            'query': { method: 'GET', isArray: true },
            'get': {
                method: 'GET',
                transformResponse: function (data) {
                    if (data) {
                        data = angular.fromJson(data);
                    }
                    return data;
                },
                headers: { 'Access-Control-Allow-Origin': '*' }
            },
            'update': { method: 'PUT' },
            'save': { method: 'POST', headers: { 'Access-Control-Allow-Origin': '*' } }
        });
    }
})();
