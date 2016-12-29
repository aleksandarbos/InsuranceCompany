    (function () {
        'use strict';

        angular
        .module('app')
        .controller('TypeOfPackageController', TypeOfPackageController);

        TypeOfPackageController.$inject = ['$scope', 'TypeOfPackageService'];

        function TypeOfPackageController($scope, TypeOfPackageService) {
            var vm = this;
            vm.typeofpackages = [];
            vm.createTypeOfPackageInput = {};
            vm.searchTypeOfPackage = {};


            vm.createFunction=function createFunction(){
                $scope.showme=false;

            }   

            vm.createTypeOfPackage = function createTypeOfPackage() {
          // vm.status= TypeOfPackageService.post(vm.createTypeOfPackageInput);
         //  vm.typeofpackage= TypeOfPackageService.getAll().data;
         vm.createTypeOfPackageInput.id=vm.typeofpackages.length+1;
         
         vm.typeofpackages.push(vm.createTypeOfPackageInput);
         console.log(JSON.stringify(vm.typeofpackages))

         vm.createTypeOfPackageInput={};
         $('#formCreateTypeOfPackage').modal('toggle');

     };
     vm.editFunction = function editFunction(typeofpackage) {
         vm.createTypeOfPackageInput=typeofpackage;
         $scope.showme=true;
     }
     vm.editTypeOfPackage=function editTypeOfPackage(state){

    //vm.status= TypeOfPackageService.put(state);
    //vm.typeofpackage= TypeOfPackageService.getAll().data;

    //simulacija edit
    var i;
    for (i = 0; i < vm.typeofpackages.length-1; i++) { 
       if(vm.typeofpackages[i].id===state.id){
        vm.typeofpackages[i]=state;
    }
    }


}

activate();



vm.deleteTypeOfPackage=function deleteTypeOfPackage(state){
     //vm.status= TypeOfPackageService.delete(state);
    //vm.typeofpackage= TypeOfPackageService.getAll().data;

    var i;
    console.log(vm.typeofpackages.length)
    console.log(JSON.stringify(vm.typeofpackages))
    for (i = 0; i < vm.typeofpackages.length-1; i++) { 
       if(vm.typeofpackages[i].id===state.id){
        vm.typeofpackages.splice(i,1);
    }
}
console.log(vm.typeofpackages.length)

}


function activate() {
           // vm.typeofpackage= TypeOfPackageService.getAll().data;
           vm.typeofpackages=[{"name":"4","opis":"4","cena":"4","id":1},{"name":"5","opis":"5","cena":"5","id":2},{"name":"6","opis":"6","cena":"6","id":3}]
           
       };
   }
})();
