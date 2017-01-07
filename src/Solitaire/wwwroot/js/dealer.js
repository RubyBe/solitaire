(function () {
    var dealService = function () {
        var myServiceMessage = "This is a service from the dealService";

        return {
            getMessage: myServiceMessage
        };
    };
    var module = angular.module("GamePlay");
    module.factory("dealService", dealService);
}());