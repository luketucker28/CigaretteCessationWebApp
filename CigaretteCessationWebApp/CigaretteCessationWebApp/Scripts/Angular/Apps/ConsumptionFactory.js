(function () {
    "use strict";
    angular.module("Quitting")
        .factory('ConsumptionFactory', function($http, API, USERID, $q) {
            function _getSmokes(cb) {
                var url = API + 'consumeds/' + USERID
                $http.get(url)
                .success(function(object) {
                    cb(object.data.consumed);
                    console.log("success");
                   
                   
                })
                .error(function (err) {
                    console.log('get Consumed error: ', err);
                })
            }
            function _deleteSmokes(id, cb) {
                var url = API + 'consumeds/DELETE/' + id;
                $http.delete(url)
                .success(function(status) {
                    cb(id);
                })
                .error(function(err) {
                    console.log('get error:', err);
                })            
            }
            function _getSmoke(id, cb) {
                var url = API + 'consumeds/' + USERID + '/' + id;
                $http.get(url)
                .success(function(obj) {
                    cb(obj.data);
               
      
                })
                .error(function (err) {
                    console.log('get error:', err);
                })
            }
            return {
                getSmokes: _getSmokes,
                deleteSmokes: _deleteSmokes,
                getSmoke: _getSmoke
            }   
        })

 })();  