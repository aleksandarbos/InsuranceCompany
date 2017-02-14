(function () {

    angular.module('app')
    .service('HouseService', ['$http', function ($http) {
            //metode servisa
            return {
                getAll: function () {

                   $http.get("api/House")
                   .then(function (response) {
                    return response;
                });
               },
               getId:function(id){
                $http.get("api/House/"+id)
                .then(function (response) {
                    return response;
                });
            }

            ,
            put: function (house)
            {
                return $http.put("api/House/"+house.id, house)


            },
            post: function (house) {
              return $http.post("api/House", house)
               
           },
               delete : function(house)
               {
                $http.delete("api/House/"+house.id).then(function(response){
                    return response;
                });


              }
          }




      }]);

})();