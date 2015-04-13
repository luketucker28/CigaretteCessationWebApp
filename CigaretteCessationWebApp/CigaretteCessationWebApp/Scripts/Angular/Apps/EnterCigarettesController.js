;(function () {
    'use strict';
    angular.module('Quitting')
    .controller('EnterCigarettesController', function ( $routeParams, EnterFactory ,USERID, $location, $scope) {
        var vm = this;
      
        vm.newSmoker = { UserID: USERID };
            vm.addNewSmoke = function () {
                EnterFactory.postSmokes(vm.newSmoker, function () {
                    vm.newSmoker = { UserID: USERID }
                    console.log("success");
                    
                })
            }

       
    })    
})();