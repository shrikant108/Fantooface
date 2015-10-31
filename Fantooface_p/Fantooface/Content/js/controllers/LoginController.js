app.controller("LoginController", function ($scope, $filter, Fantooface_Service) {
    $scope.signup = {
        Firstname: "",
        Lastname: "",
        Email: "",
        Displayname: "",
        Username: "",
        Passoword: ""        
    };
    $scope.Login = {        
        Username: "",
        Passoword: ""
    };
    //user's login functionality
    $scope.Login = function () {
        alert("Hi");
        Fantooface_Service.Login($scope.Login.Username, $scope.Login.Passoword)
            .success(function (data, status) {
                if (data != null) {                    
                    $scope.UserModel = data;
                    console.log(data);
                } else {
                    console.log("Unable to login, please try again.");
                }
            })
            .error(function (data, status) {
                console.log("Unknown error occured when trying to login.");
            });
    }
});