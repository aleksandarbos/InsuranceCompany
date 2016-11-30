(function() {
    'use strict';
    angular
        .module('insuranceFeApp')
        .factory('Bank', Bank);

    Bank.$inject = ['$resource'];

    function Bank ($resource) {
        var resourceUrl =  'api/banks/:id';

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
