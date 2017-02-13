(function () {

    angular.module('app')
    .service('ClientService', ['$http', function ($http) {
            //metode servisa
            return {
                getAll: function () {

                   $http.get("api/Clients")
                   .then(function (response) {
                    return response;
                });
               },
               getId:function(id){
               return  $http.get("api/Clients/"+id)
                
            }

            ,
            put: function (client)
            {
               return  $http.put("api/Clients/"+client.id, client)


            },
            post: function (client) {
               return $http.post("api/Clients", client)
           },
               delete : function(client)
               {
                $http.delete("api/Clients/"+client.id).then(function(response){
                    return response;
                });


              }
          }




      }]);

})();