(function () {

    angular.module('app')
    .service('InsurancePackageService', ['$http', function ($http) {
            //metode servisa
            return {
                getAll: function () {

                   $http.get("api/InsurancePackages")
                   .then(function (response) {
                    return response;
                });
               },
               getId:function(id){
                $http.get("api/InsurancePackages/"+id)
                .then(function (response) {
                    return response;
                });
            }

            ,
            put: function (package)
            {
                $http.put("api/InsurancePackages/"+package.id, package).then(function(response){
                    return response;
                });


            },
            post: function (package) {
               $http.post("api/InsurancePackages", package)
               .then(function (response) {
                    // Re-load data
                    return response;



                });
           },
               delete : function(packages)
               {
                $http.delete("api/InsurancePackages/"+package.id).then(function(response){
                    return response;
                });


              }
          }




      }]);

})();