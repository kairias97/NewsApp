'use strict';
const apiHost = 'http://localhost:47441/';
var app = angular.module('newsApp', [
    'ngRoute',
    'ngSanitize'
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

    service.getRecentNews = function () {
        return $http.get(`${this.hostUrl}api/news/recent`)
            .then(function (response) {
                return response.data;
            });
    };

    service.searchNews = function (title, startDate, endDate) {
        return $http.get(encodeURI(`${this.hostUrl}api/news/search?title=${title}&startDate=${startDate}&endDate=${endDate}`))
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
                $scope.error = true;
            });
    }
    getFeaturedNews();
}]);

app.controller('ExploreController', ['$scope', 'newsApi', function ($scope, newsApi) {
    $scope.news = [];
    $scope.error = false;
    $scope.title = '';
    $scope.startDate = '';
    $scope.endDate = '';


    function getRecentNews() {
        newsApi.getRecentNews()
            .then(function (news) {
                $scope.news = news;
                $scope.error = false;
            }).catch(function (e) {
                $scope.error = true;
            });
    }

    $scope.searchNews = function () {
        let { title, startDate, endDate } = $scope;
        newsApi.searchNews(title, startDate, endDate)
            .then(function (news) {
                $scope.news = news;
                $scope.error = false;
            }).catch(function (e) {
                $scope.error = true;
            })
    }

    getRecentNews();
}]);



