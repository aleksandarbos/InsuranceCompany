(function () {

    angular.module('app')
    .service('HomeService', ['$http', function ($http) {
            //metode servisa
            return {
                getAll: function () {

                   $http.get("api/Homes")
                   .then(function (response) {
                    return response;
                });
               },
               getId:function(id){
                $http.get("api/Homes/"+id)
                .then(function (response) {
                    return response;
                });
            }

            ,
            put: function (house)
            {
                $http.put("api/Homes/"+house.id, house).then(function(response){
                    return response;
                });


            },
            post: function (house) {
               $http.post("api/Homes", house)
               .then(function (response) {
                    // Re-load data
                    return response;



                });
           },
               delete : function(house)
               {
                $http.delete("api/Homes/"+house.id).then(function(response){
                    return response;
                });


              }
          }




      }]);

})();