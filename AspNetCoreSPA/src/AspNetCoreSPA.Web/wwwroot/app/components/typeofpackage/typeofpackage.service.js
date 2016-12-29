(function () {

    angular.module('app')
    .service('TypeOfPackageService', ['$http', function ($http) {
            //metode servisa
            return {
                getAll: function () {

                   $http.get("api/Packages")
                   .then(function (response) {
                    return response;
                });
               },
               getId:function(id){
                $http.get("api/Packages/"+id)
                .then(function (response) {
                    return response;
                });
            }

            ,
            put: function (state)
            {
                $http.put("api/Packages/"+state.id, state).then(function(response){
                    return response;
                });


            },
            post: function (state) {
               $http.post("api/Packages", state)
               .then(function (response) {
                    // Re-load data
                    return response;



                });
           },
               delete : function(state)
               {
                $http.delete("api/Packages/"+state.id).then(function(response){
                    return response;
                });


              }
          }




      }]);

})();