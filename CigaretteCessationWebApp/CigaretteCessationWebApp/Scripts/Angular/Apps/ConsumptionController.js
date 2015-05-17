(function () {
    "use strict";
    angular
        .module("Quitting")
        .controller("ConsumptionController", function ($routeParams, ConsumptionFactory, USERID, $location, $scope, $rootScope) {
            var Consump = this;
            Consump.viewConsumed = function() {
                ConsumptionFactory.getSmokes(function (consumed) {
              
                    Consump.consumed = consumed;
                });
            };
            Consump.remove = function (cons) {
                removeItem(cons);
            };
            Consump.deleteConsumed = function(id, consumed) {
                ConsumptionFactory.deleteSmokes(consumed.consumedID, function (consumedID) {
                    console.log(Consump.consumed[id]);
                    delete Consump.consumed[id];
                    Consump.remove(Consump.consumed[id]);

                });
            };
            Consump.getIndividualSmoke = function (id, consumed) {
                ConsumptionFactory.getSmoke(consumed.consumedID, function (consumedID) {
                    Consump.consumed[id] = consumed;
                    
                    Consump.consump = consumed;
                    console.log(Consump.consump);

                   
                    
                  
                   
                    $location.path('/Consumption/Edit/' + consumed.consumedID);
                   

                })
            };
        })
})();