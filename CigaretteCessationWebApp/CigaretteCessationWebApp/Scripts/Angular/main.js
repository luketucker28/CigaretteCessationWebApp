;(function() {
    'use strict'
    ;var app = angular.module('QuittingModule', [])
    .controller('EnterCigarettesController', function ($routeParams, USERID, $location) {
        var vm = this;
        
    
    })
 .controller('ViewEntriesController', function ($routeParams, USERID, $location) {
     var vm = this;
        
 
})
        angular.module('QuittingModule')
        .config(function ($routeProvider) {
            $routeProvider
            
            .when('/EnterCigarettes', {
                templateUrl: '/Angular/Views/EnterCigarettes.html',
                controller: 'EnterCigarettesController',
                controllerAs: 'Add'
            })
            .when('/ViewData', {
                templateUrl: '/Angular/views/ViewEntries.html',
                controller: 'ViewEntriesController',
                controllerAs: 'View'
            })
            
        });
 

})();