(function () {
    'use strict';
    angular
        .module('droolsModule')
        .factory('DroolsVehicle', DroolsVehicle);

    DroolsVehicle.$inject = ['$resource'];

    function DroolsVehicle($resource) {
        var resourceUrl = 'http://localhost:8080/setVehiclePackage';

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