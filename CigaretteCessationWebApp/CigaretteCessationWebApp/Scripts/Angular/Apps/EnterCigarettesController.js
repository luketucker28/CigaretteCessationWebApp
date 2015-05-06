;(function () {
    'use strict';
    angular.module('Quitting')
    .controller('EnterCigarettesController', function ( $routeParams, EnterFactory ,USERID, $location, $scope) {
        var Enter = this;
      
        Enter.newSmoker = { UserID: USERID };
        Enter.addNewSmoke = function () {
            EnterFactory.postSmokes(Enter.newSmoker, function () {
                Enter.newSmoker = { UserID: USERID }
                console.log("success");
            })
        }
    })    
})();