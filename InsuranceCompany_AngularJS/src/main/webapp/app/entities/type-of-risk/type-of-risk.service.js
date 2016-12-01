(function() {
    'use strict';
    angular
        .module('insuranceFeApp')
        .factory('TypeOfRisk', TypeOfRisk);

    TypeOfRisk.$inject = ['$resource'];

    function TypeOfRisk ($resource) {
        var resourceUrl =  'http://localhost:5000/api/TypeOfRisks/:id';

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
            'update': { method:'PUT' },
			'save' : { method: 'POST', headers: { 'Access-Control-Allow-Origin': '*' }}
        });
    }
})();
