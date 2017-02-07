(function () {

    angular.module('app')
    .service('TravelPurposeService', ['$http', function ($http) {
            //metode servisa
            return {
                getAll: function () {

                   $http.get("api/TravelPurpose")
                   .then(function (response) {
                    return response;
                });
               },
               getId:function(id){
                $http.get("api/TravelPurpose/"+id)
                .then(function (response) {
                    return response;
                });
            }

            ,
            put: function (purpose)
            {
                $http.put("api/TravelPurpose/"+purpose.id, purpose).then(function(response){
                    return response;
                });


            },
            post: function (purpose) {
               $http.post("api/TravelPurpose", purpose)
               .then(function (response) {
                    // Re-load data
                    return response;



                });
           },
               delete : function(purpose)
               {
                $http.delete("api/TravelPurpose/"+purpose.id).then(function(response){
                    return response;
                });


              }
          }




      }]);

})();