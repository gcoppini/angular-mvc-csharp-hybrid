(function () {

    var viajaNetModule = angular.module('app');

    viajaNetModule.factory('app.services.github.search', [
        '$http', 'appSession', function ($http, appSession) {
            return new function () {
                
                this.getList = function (httpParams) {
                    return $http({
                        url: appSession.EndPointSearch,
                        method: "GET",
                        params: httpParams 
                    });
                };

                this.getRepo = function (id) {
                    return $http({
                        url: appSession.EndPointRepositories +'/'+ id,
                        method: "GET"
                    });
                };
            };
        }
    ]);

})();