(function () {

    angular.module('app')
    .service('StatesService', ['$http', function ($http) {
            //metode servisa
            return {
                getAll: function () {

                   $http.get("api/StateOfOrigins")
                   .then(function (response) {
                    return response;
                });
               },
               getId:function(id){
                $http.get("api/StateOfOrigins/"+id)
                .then(function (response) {
                    return response;
                });
            }

            ,
            put: function (state)
            {
                $http.put("api/StateOfOrigins/"+state.id, state).then(function(response){
                    return response;
                });


            },
            post: function (state) {
               $http.post("api/StateOfOrigins", state)
               .then(function (response) {
                    // Re-load data
                    return response;



                });
           },
               delete : function(state)
               {
                $http.delete("api/StateOfOrigins/"+state.id).then(function(response){
                    return response;
                });


              }
          }




      }]);

})();