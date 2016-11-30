(function() {
    'use strict';
    angular
        .module('insuranceFeApp')
        .factory('Bank', Bank);

    Bank.$inject = ['$http'];

    function Bank ($http) {
        var collectionName = "Banks";
		
		var service = {
				getAll: getAll,
				create: create,
				get: get,
				update: update,
				remove: remove
			};

			return service;
			
			function getAll() {
				return $http.get("http://localhost:5000/api/" + collectionName);
			}

			function create(entity) {
				return $http.post("http://localhost:5000/api/" + collectionName, entity);
			}

			function get(id) {
				return $http.get("http://localhost:5000/api/" + collectionName + "/" + id);
			}

			function update(entity) {
				return $http.put("http://localhost:5000/api/" + collectionName + "/" + entity._id, entity);
			}

			function remove(id) {
				return $http.delete("http://localhost:5000/api/" + collectionName + "/" + id);
			}
			
	}
})();
