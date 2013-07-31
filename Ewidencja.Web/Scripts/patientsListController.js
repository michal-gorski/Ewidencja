function PatientsListController($scope) {
    $scope.patients = [
      {
          name: "Jan",
          surname: "Kowalski",
          address:"Focha 4a/53, Gdańsk"
      },

     {
         name: "Adam",
         surname: "Nowak",
         address: "Kartuska 5, Gdańsk"
     },

  {
      name: "Maria",
      surname: "Kowalska",
      address: "Mickiewicza 10, Gdańsk"
  }, ];

    $scope.AddPatient = function ()
    {
        $scope.patients.push({
            name: "Anna",
            surname: "Kowalska",
            address: "Słowackiego 10, Gdańsk"
        });
    };


}