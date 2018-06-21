
//https://github.com/raoulus/angular-simple-pagination
var app = angular.module("appInicio", []);
app.controller("inicioController", function ($scope, $http) {
    $scope.message = "Hello, AngularJS";
    $scope.Categorias = [];
    $scope.Producto = [];
    $scope.CategoriaSelected = 0;
    $scope.TotalSegunCategoria = 0;
   
    $http({
        method: "GET",
        url: "/Home/ObtenerTodo"
    }).then(function mySuccess(response) {

        $scope.Categorias = response.data.CategoriaProducto;
        $scope.Producto = response.data.listaFinalProducto;
    
        if ($scope.Categorias.length > 0)
            $scope.CategoriaSelected = $scope.Categorias[0].IdCategoria;

    }, function myError(response) {
    });

    $scope.SeleccionarCategoria = function (idCategoria) {

        $scope.CategoriaSelected = idCategoria;
    }



});