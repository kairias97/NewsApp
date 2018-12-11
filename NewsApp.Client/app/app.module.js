'use strict';
const apiHost = 'http://localhost:47441/';
var app = angular.module('newsApp', [
    'ngRoute'
]);
app.config(['$locationProvider', function ($locationProvider) {
    $locationProvider.html5Mode(true);
    $locationProvider.hashPrefix('');
}]);

//Custom services setup
app.factory('newsApi', ['$http', function ($http) {
    let service = {};
    service.hostUrl = apiHost;
    service.getFeaturedNews = function () {
        return $http.get(`${this.hostUrl}api/news/featured`)
            .then(function (response) {
                return response.data;
            });
    };
    return service;
}]);

//Controllers setup
app.controller('HomeController', ['$scope', 'newsApi', function ($scope, newsApi) {
    $scope.news = [];
    $scope.error = false;
    
    function getFeaturedNews() {
        newsApi.getFeaturedNews()
            .then(function (news) {
                $scope.news = news;
                $scope.error = false;
            }).catch(function (e) {
                $scope.error = false;
            })
    }
    getFeaturedNews();
}]);



