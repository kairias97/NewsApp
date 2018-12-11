'use strict';
const apiHost = 'http://localhost:47441/';
var app = angular.module('newsApp', [
    'ngRoute'
]);
app.config(['$locationProvider', function ($locationProvider) {
    $locationProvider.html5Mode(true);
    $locationProvider.hashPrefix('');
}]);

app.controller('HomeController', function ($scope, $http) {
    $scope.news = [];
    $scope.error = false;
    
    function getFeaturedNews() {
        
        $http.get(`${apiHost}api/news/featured`).then(function (response) {
            $scope.news = response.data;

            $scope.fetched = true;
        }).catch(function (error) {
            $scope.news = [];
            $scope.error = true;
        })
    }
    getFeaturedNews();
});



