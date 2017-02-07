(function () {

    angular.module('app')
    .service('RiskService', ['$http', function ($http) {
            //metode servisa
            return {
                getAll: function () {

                   $http.get("api/Risks")
                   .then(function (response) {
                    return response;
                });
               },
               getId:function(id){
                $http.get("api/Risks/"+id)
                .then(function (response) {
                    return response;
                });
            }

            ,
            put: function (risk)
            {
                $http.put("api/Risks/"+risk.id, risk).then(function(response){
                    return response;
                });


            },
            post: function (risk) {
               $http.post("api/Risks", risk)
               .then(function (response) {
                    // Re-load data
                    return response;



                });
           },
               delete : function(risk)
               {
                $http.delete("api/Risks/"+risk.id).then(function(response){
                    return response;
                });


              }
          }




      }]);

})();