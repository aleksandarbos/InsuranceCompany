(function () {

    angular.module('app')
    .service('CarService', ['$http', function ($http) {
            //metode servisa
            return {
                getAll: function () {

                   $http.get("api/Car")
                   .then(function (response) {
                    return response;
                });
               },
               getId:function(id){
                $http.get("api/Car/"+id)
                .then(function (response) {
                    return response;
                });
            }

            ,
            put: function (car)
            {
                $http.put("api/Car/"+car.id, car).then(function(response){
                    return response;
                });


            },
            post: function (car) {
               return $http.post("api/Car", car)
               
           },
               delete : function(car)
               {
                $http.delete("api/Car/"+car.id).then(function(response){
                    return response;
                });


              }
          }




      }]);

})();