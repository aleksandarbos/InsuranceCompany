(function () {

  angular.module('app')
  .service('PolicyService', ['$http', function ($http) {
            //metode servisa
            return {
              getAll: function () {

               return $http.get("api/Policy")

             },
             getId:function(id){
              return $http.get("api/Policy/"+id)

            }

            ,
            put: function (policy)
            {
             return  $http.put("api/Policy/"+policy.id, policy)


           },
           post: function (policy)
           {
            var req = {
              method: 'POST',
              url: '/api/Policy/',
              headers: {
                'Content-Type': 'application/json'
              },
              data: JSON.stringify(policy)

            }
            return $http(req);
          },
          delete : function(policy)
          {
            return $http.delete("api/Policy/"+policy.id)


          }
        }




      }]);

})();










