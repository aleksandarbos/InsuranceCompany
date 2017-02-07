(function () {

    angular.module('app')
    .service('CarService', ['$http', function ($http) {
            //metode servisa
            return {
                getAll: function () {

                   $http.get("api/Cars")
                   .then(function (response) {
                    return response;
                });
               },
               getId:function(id){
                $http.get("api/Cars/"+id)
                .then(function (response) {
                    return response;
                });
            }

            ,
            put: function (car)
            {
                $http.put("api/Cars/"+car.id, car).then(function(response){
                    return response;
                });


            },
            post: function (car) {
               $http.post("api/Cars", car)
               .then(function (response) {
                    // Re-load data
                    return response;



                });
           },
               delete : function(car)
               {
                $http.delete("api/Cars/"+car.id).then(function(response){
                    return response;
                });


              }
          }




      }]);

})();