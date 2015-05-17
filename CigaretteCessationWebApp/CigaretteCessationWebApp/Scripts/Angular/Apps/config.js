(function () {
    angular.module("Quitting")
        .config(function ($routeProvider, $locationProvider) {


            $routeProvider.when('/EnterCigarettes', {
                templateUrl: '/Scripts/Angular/templates/EnterCigarettes.html',
                controller: 'EnterCigarettesController',
                controllerAs: 'Enter'

            })
            .when('/EnterTarget', {
                templateUrl: '/Scripts/Angular/templates/EnterTarget.html',
                controller: 'EntriesController',
                controllerAs: 'Entries'
            })
            .when('/Consumption', {
                templateUrl: '/Scripts/Angular/templates/Consumption.html',
                controller: 'ConsumptionController',
                controllerAs: 'Consump'
            })
            .when('/Consumption/Edit/:id', {
                templateUrl: '/Scripts/Angular/Templates/Editor.html',
                controller: 'ConsumptionController',
                controllerAs: 'Consump'
            })

        })
})();