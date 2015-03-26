/// <reference path="main.js" />

  var Quitting = angular.module('Quitting', ['ngRoute', 'ngResource'])
       .config(function ($routeProvider, $locationProvider) {


           $routeProvider.when('/EnterCigarettes', {
               templateUrl: '/Scripts/Angular/templates/EnterCigarettes.html',
               controller: 'EnterCigarettesController',
 

           })
                        .when('/ViewEntries', {
                        templateUrl: '/Scripts/Angular/templates/ViewEntries.html',
               controller: 'ViewEntriesController'
           });
          

       });

