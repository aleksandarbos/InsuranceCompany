(function () {

    angular.module('app')
    .service('RiskOfHouseService', ['$http', function ($http) {
            //metode servisa
            return {
                getAll: function () {

                   $http.get("api/RiskOfHouse")
                   .then(function (response) {
                    return response;
                });
               },
               getId:function(id){
               return  $http.get("api/RiskOfHouse/"+id)
                
            }

            ,
            put: function (riskofhouse)
            {
               return  $http.put("api/RiskOfHouse/"+riskofhouse.id, riskofhouse)


            },
            /*post: function (riskofhouse,callback) {
               $http.post("api/RiskOfHouse", riskofhouse).success(function (response) {
                callback(response.data);
            }).error(function(response){

            });
           }*/
          post: function (riskofhouse) {
               return $http.post("api/RiskOfHouse", riskofhouse)
           }
           ,
            delete : function(riskofhouse)
               {
                $http.delete("api/RiskOfHouse/"+riskofhouse.id).then(function(response){
                    return response;
                });


              }
          }




      }]);

})();