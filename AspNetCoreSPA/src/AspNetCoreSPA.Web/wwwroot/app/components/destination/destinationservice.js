(function () {

    angular.module('app')
    .service('DestinationService', ['$http', function ($http) {
            //metode servisa
            return {
                getAll: function () {

                   $http.get("api/Destination")
                   .then(function (response) {
                    return response;
                });
               },
               getId:function(id){
                $http.get("api/Destination/"+id)
                .then(function (response) {
                    return response;
                });
            }

            ,
            put: function (destination)
            {
                return $http.put("api/Destination/"+destination.id, destination);


            },
            post: function (destination) {
              return $http.post("api/Destination", destination)
               
           },
               delete : function(destination)
               {
                return $http.delete("api/Destination/"+destination.id);


              }
          }




      }]);

})();