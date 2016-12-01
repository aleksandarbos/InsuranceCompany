(function() {
    'use strict';
    angular
        .module('insuranceFeApp')
        .factory('TypeOfHome', TypeOfHome);

    TypeOfHome.$inject = ['$resource'];

    function TypeOfHome ($resource) {
        var resourceUrl =  'api/type-of-homes/:id';

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
