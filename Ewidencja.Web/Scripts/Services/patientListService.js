angular.module('patientListService', []).
    factory('PatientsList', function (/*$resource*/) {
        return {
            GetPatients: function () {
                var patients = Array();
                patients = [
                {
                    name: "Jan",
                    surname: "Kowalski",
                    address: "Focha 4a/53, Gdańsk"
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
                
                return patients;
            }
        };

        /* return $resource('phones/:phoneId.json', {}, {
            query: { method: 'GET', params: { phoneId: 'phones' }, isArray: true }
        });
        */
    });