(function(){

    var app = angular.module("githubViewer", []);

    var MainController = function($scope, $http){

        var onUserComplete = function(response){
          $scope.user = response.data;
        };
        var onError = function(reason){
            $scope.error = "Could not fetch the user"
        };

        $scope.search = function(username){
            $http.get("https://api.github.com/users/" + username)
                .then(onUserComplete, onError);
        }

        $scope.usernname = "angular";
        $scope.message = "Github viewer";

    };

    app.controller("MainController", ["$scope","$http",MainController]);

}());