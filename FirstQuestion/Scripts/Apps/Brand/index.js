angular.module("mainModule", [])
  .controller("mainController", function ($scope, $http) {
      var getData = function () {
          //var params = {
          //    jsonObjParam: {
          //        param1: $scope.getJSONParam1,
          //        param2: $scope.getJSONParam2
          //    }
          //};

          var config = {
              //params: params
          };

          $http.get("/api/product", config)
            .success(function (data, status, headers, config) {
                $scope.products = data;
            })
            .error(function (data, status, headers, config) {
                console.log(data);
            });
      };

      getData();
  });