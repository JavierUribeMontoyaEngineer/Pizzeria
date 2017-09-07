(function () {
    angular.module('pizzeria_app', ['ngMaterial', 'ngMessages', 'ngRoute'])//.controller('AppCtrl', function ($scope, $timeout, $mdSidenav, $log) {
        //    $scope.toggleLeft = buildDelayedToggler('left');

        //    function debounce(func, wait, context) {
        //        var timer;

        //        return function debounced() {
        //            var context = $scope,
        //                args = Array.prototype.slice.call(arguments);
        //            $timeout.cancel(timer);
        //            timer = $timeout(function () {
        //                timer = undefined;
        //                func.apply(context, args);
        //            }, wait || 10);
        //        };
        //    }

        //    function buildDelayedToggler(navID) {
        //        return debounce(function () {
        //            $mdSidenav(navID)
        //                .toggle()
        //                .then(function () {
        //                    $log.debug("toggle " + navID + " is done");
        //                });
        //        }, 200);
        //    }

        //    function buildToggler(navID) {
        //        return function () {
        //            $mdSidenav(navID)
        //                .toggle()
        //                .then(function () {
        //                    $log.debug("toggle " + navID + " is done");
        //                });
        //        };
        //    }
        //})
        //    .controller('LeftCtrl', function ($scope, $timeout, $mdSidenav, $log) {
        //        $scope.close = function () {
        //            $mdSidenav('left').close()
        //                .then(function () {
        //                    $log.debug("close LEFT is done");
        //                });

        //        };
        //    })
        .config(function ($routeProvider) {
            $routeProvider
                .when("/Pizza/Add", {
                    templateUrl: "/Content/Pizza/CreatePizza.html"
                })
                .otherwise({
                    template: "<h1>Pagina no encontrada</h1>"
                })
        })

}());
