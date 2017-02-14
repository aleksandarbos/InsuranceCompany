(function () {

    angular.module('app')
    .service('RiskOfCarService', ['$http', function ($http) {
            //metode servisa
            return {
                getAll: function () {

                   $http.get("api/RiskOfCar")
                   .then(function (response) {
                    return response;
                });
               },
               getId:function(id){
               return  $http.get("api/RiskOfCar/"+id)
                
            }

            ,
            put: function (riskofcar)
            {
               return  $http.put("api/RiskOfCar/"+riskofcar.id, riskofcar)


            },
            post: function (riskofcar) {
               return $http.post("api/RiskOfCar", riskofcar)
           },
            delete : function(riskofcar)
               {
                $http.delete("api/RiskOfCar/"+riskofcar.id).then(function(response){
                    return response;
                });


              }
          }




      }]);

})();