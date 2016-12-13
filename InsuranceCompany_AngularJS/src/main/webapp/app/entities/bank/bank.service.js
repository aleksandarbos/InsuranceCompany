(function() {
    'use strict';
    angular
        .module('insuranceFeApp')
        .factory('Bank', Bank);

    Bank.$inject = ['$resource'];

    function Bank ($resource) {
        var resourceUrl =  'http://localhost:5000/api/banks/:id';

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
