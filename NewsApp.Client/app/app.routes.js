﻿angular.module('newsApp').config(function ($routeProvider) {
    $routeProvider
        .when('/', {
            templateUrl: 'app/components/home/homeView.html',
            controller: 'HomeController'
        });
});