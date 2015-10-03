(function(){

    var app = angular.module("githubViewer", []);

    var MainController = function($scope){

        var person = {
            firstname: "Shanks",
            lastname: "RedHair",
            imageSrc: "http://img2.wikia.nocookie.net/__cb20130408191853/onepiece/images/6/66/Shanks_Anime_Infobox.png"
        };

        $scope.message = "Hello, Captain";
        $scope.person = person;
    };

    app.controller("MainController", MainController);

}());