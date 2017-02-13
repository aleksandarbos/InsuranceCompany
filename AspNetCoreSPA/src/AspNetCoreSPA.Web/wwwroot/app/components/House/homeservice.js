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
                return $http.put("api/Homes/"+house.id, house)


            },
            post: function (house) {
              return $http.post("api/Homes", house)
               
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