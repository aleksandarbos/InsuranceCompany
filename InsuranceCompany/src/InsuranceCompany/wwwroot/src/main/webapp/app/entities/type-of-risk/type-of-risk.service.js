(function() {
    'use strict';
    angular
        .module('insuranceFeApp')
        .factory('TypeOfRisk', TypeOfRisk);

    TypeOfRisk.$inject = ['$resource'];

    function TypeOfRisk ($resource) {
        var resourceUrl =  'api/type-of-risks/:id';

        return $resource(resourceUrl, {}, {
            'query': { method: 'GET', isArray: true},
            'get': {
                method: 'GET',
                transformResponse: function (data) {
                    if (data) {
                        data = angular.fromJson(data);
                    }
                    return data;
                }
            },
            'update': { method:'PUT' }
        });
    }
})();
