angular.module('newsApp').config(function ($routeProvider) {
    $routeProvider
        .when('/', {
            templateUrl: 'app/components/home/homeView.html',
            controller: 'HomeController'
        })
        .when('/explore', {
            templateUrl: 'app/components/explore/exploreView.html',
            controller: 'ExploreController'
        });
});