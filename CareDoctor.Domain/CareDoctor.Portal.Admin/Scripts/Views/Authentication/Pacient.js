$scope.adicionaItem = function () {
    $scope.itens.push({
        produto: $scope.item.produto,
        quantidade: $scope.item.quantidade,
        comprado: false
    });
    $scope.item.produto = $scope.item.quantidade = '';
};