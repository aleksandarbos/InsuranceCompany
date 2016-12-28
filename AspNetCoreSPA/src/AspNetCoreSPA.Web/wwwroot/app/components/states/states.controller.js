    (function () {
        'use strict';

        angular
        .module('app')
        .controller('StatesController', StatesController);

        StatesController.$inject = ['$scope', 'StatesService'];

        function StatesController($scope, StatesService) {
            var vm = this;
            vm.states = [];
            vm.createStatesInput = {};
            vm.searchStates = {};


            vm.createFunction=function createFunction(){
                $scope.showme=false;

            }   

            vm.createStates = function createStates() {
          // vm.status= StatesService.post(vm.createStatesInput);
         //  vm.states= StatesService.getAll().data;
         vm.createStatesInput.id=vm.states.length+1;
         
         vm.states.push(vm.createStatesInput);

         vm.createStatesInput={};
         $('#formCreateStates').modal('toggle');

     };
     vm.editFunction = function editFunction(states) {
         vm.createStatesInput=states;
         $scope.showme=true;
     }
     vm.editStates=function editStates(state){

    //vm.status= StatesService.put(state);
    //vm.states= StatesService.getAll().data;

    //simulacija edit
    var i;
    for (i = 0; i < vm.states.length-1; i++) { 
       if(vm.states[i].id===state.id){
        vm.states[i]=state;
    }
    }


}

activate();



vm.deleteState=function deleteStates(state){
     //vm.status= StatesService.delete(state);
    //vm.states= StatesService.getAll().data;

    var i;
    console.log(vm.states.length)
    console.log(JSON.stringify(vm.states))
    for (i = 0; i < vm.states.length-1; i++) { 
       if(vm.states[i].id===state.id){
        vm.states.splice(i,1);
    }
}
console.log(vm.states.length)

}


function activate() {
           // vm.states= StatesService.getAll().data;
           vm.states=[{"name":"aaa","id":1},{"name":"bbbb","id":2},{"name":"ccccc","id":3},{"name":"ddddd","id":4},{"name":"eeeeee","id":5}]
           
       };
   }
})();
