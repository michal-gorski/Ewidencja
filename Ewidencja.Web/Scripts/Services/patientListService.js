angular.module('patientListService', []).
    factory('PatientsList', function ($q, $http) {
        
        return {
            GetPatients: $http.get('/api/Patients/GetPatientsList'),
        };

        /* return $resource('phones/:phoneId.json', {}, {
            query: { method: 'GET', params: { phoneId: 'phones' }, isArray: true }
        });
        */
    });