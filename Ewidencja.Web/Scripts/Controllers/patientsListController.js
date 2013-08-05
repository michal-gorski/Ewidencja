function PatientsListController($scope, PatientsList) {

    PatientsList.GetPatients
        .then(function(data) {
            $scope.patients = data.data;
        }, function(request, status, error) {
            $scope.patients = Array();
        });          
        
    
}