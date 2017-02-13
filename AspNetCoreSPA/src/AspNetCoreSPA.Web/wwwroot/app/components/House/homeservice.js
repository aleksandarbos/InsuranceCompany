(function () {

    angular.module('app')
    .service('HouseService', ['$http', function ($http) {
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
                return $http.put("api/Destination/"+destination.id, destination)


            },
            post: function (destination) {
              return $http.post("api/Destination", destination)
               
           },
               delete : function(destination)
               {
                $http.delete("api/Destination/"+destination.id).then(function(response){
                    return response;
                });


              }
          }




      }]);

})();