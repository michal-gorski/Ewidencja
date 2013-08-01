function PatientsListController($scope, PatientsList) {
    $scope.patients = PatientsList.GetPatients();

    $scope.AddPatient = function ()
    {
        $scope.patients.push({
            name: "Anna",
            surname: "Kowalska",
            address: "Słowackiego 10, Gdańsk"
        });
    };


}