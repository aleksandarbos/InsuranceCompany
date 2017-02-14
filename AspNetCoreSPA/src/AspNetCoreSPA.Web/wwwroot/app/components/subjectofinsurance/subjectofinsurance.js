
(function () {

    angular.module('app')
    .service('SubjectOfInsuranceService', ['$http', function ($http) {
            //metode servisa
            return {
                getAll: function () {

                   $http.get("api/SubjectOfInsurance")
                   .then(function (response) {
                    return response;
                });
               },
               getId:function(id){
               return  $http.get("api/SubjectOfInsurance/"+id)
                
            }

            ,
            put: function (subject)
            {
               return  $http.put("api/SubjectOfInsurance/"+subject.id, subject)


            },
            post: function (subject) {
               return $http.post("api/SubjectOfInsurance", subject)
           },
              delete : function(subject)
               {
                $http.delete("api/SubjectOfInsurance/"+subject.id).then(function(response){
                    return response;
                });


              }
          }




      }]);

})();