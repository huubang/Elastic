var contactApp = angular.module("ContactApp", []);

contactApp.controller("ContactController", function ($scope) {    
    $scope.contacts = [
        {
            name: 'Bang',
            mobile: '0435678972',
            email: 'bang@gmail.com'
        }
    ];

    $scope.addContact = function () {
        $scope.contacts.push(angular.copy($scope.newcontact));
    }

    $scope.delete = function (x) {
        $scope.contacts.splice(x, 1);
    }

    $scope.edit = function (item) {
        $scope.newcontact = item;
    }
});
