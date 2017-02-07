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
                $http.get("api/Clients/"+id)
                .then(function (response) {
                    return response;
                });
            }

            ,
            put: function (client)
            {
                $http.put("api/Clients/"+client.id, client).then(function(response){
                    return response;
                });


            },
            post: function (client) {
               $http.post("api/Clients", client)
               .then(function (response) {
                    // Re-load data
                    return response;



                });
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