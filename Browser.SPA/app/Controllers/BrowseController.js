// BrowseController - (angularjs controller)
var BrowseController = browserApp
    .controller("BrowseController", function ($scope, $http) {
        // Response JSON data (model = DirectoryBrowseModel)
        function getDirectoryBrowseModel(path) {
            $http.get(path, { responseType: "JSON" })
            .then(function (response) {
                $scope.model = response.data;
                countFiles($scope.model.AllFilesSizes);
            });
        };
        getDirectoryBrowseModel("http://localhost:9298/api/browse");

        $scope.clickToPath = function (path) {
            getDirectoryBrowseModel(path);
        };
        // Count files by size
        function countFiles(allFilesSizes) {
            $scope.less10Mb = 0;
            $scope.more10less50Mb = 0;
            $scope.more100Mb = 0;
            allFilesSizes.forEach(function (item, i, allFilesSizes) {
                if (item.Size < 10) { $scope.less10Mb = $scope.less10Mb + 1; }
                else if (item.Size >= 10 && item.Size <= 50) { $scope.more10less50Mb = $scope.more10less50Mb + 1; }
                else if (item.Size > 100) { $scope.more100Mb = $scope.more100Mb + 1; };
            });
        };

    });