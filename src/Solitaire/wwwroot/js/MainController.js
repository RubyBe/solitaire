// Write your Javascript code.
(function () {
    // GamePlay is attached to the entire body in the _layout file
    var app = angular.module("GamePlay", []);

    // ------------------ Controllers for the Card API ------------------------------
    // A controller for the deck
    var APIDeckController = function ($scope, $http, $anchorScroll, $location, dealService) {
        $http.get("https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1")
            .then(function (response) {
                $scope.deck = response.data;
            });
        $location.hash("cardsList");
        $anchorScroll();

        $scope.dealMessage = dealService.getMessage;
    };
    // A controller to draw cards
    var APIDrawController = function ($scope, $http) {
        $http.get("https://deckofcardsapi.com/api/deck/5qtjfuws937b/draw/?count=5")
            .then(function (response) {
                $scope.draw = response.data;
                var cards = $scope.draw.cards;

            });

        $scope.cardSortValue = "+value";       
        $scope.urlName = "https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
    };

    // --------------------- Controllers for the Home Index ---------------------------------
    var MainController = function ($scope, $interval, $log) {
        $scope.countdown = 5;
        var decrementCountdown = function () {
            $scope.countdown -= 1;
            $log.info("Current number is " + $scope.countdown);
            if ($scope.countdown < 1) {
            //    $interval.cancel(countdownInterval);
            //}
            //else if ($scope.countdown < 1) {
                console.log("hey hey hello");
            }
        }

        var countdownInterval = null;
        var startCountdown = function () {
            countdownInterval = $interval(decrementCountdown, 1000, $scope.countdown);
        }

        startCountdown();
    };

    // ----------------------- Inject Controllers Into App ----------------------------------
    app.controller("MainController", MainController); // If i don't use array notation, angular checks the MainController and pulls in references
    app.controller("APIDeckController", APIDeckController);
    app.controller("APIDrawController", ["$scope", "$http", APIDrawController]);

}());

// -------------------------------- Services --------------------------------------------

