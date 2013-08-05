
function GridUtils(options) {
    /*
    options:
        gridId - ID of the table element containing the grid

    */

    var self = {};
    
    /*
    self.rolloutValue = ko.observable(13);
    
    self.submitForm = function (activity) {
        $.ajax({
            type: "POST",
            url: options.activityUrl(),
            data: activity,
            async: false,
            success: function (callback) {
                var exercises = [dateToJSON(callback.Date), callback.ExercisesMet];
                var sleepTime = [dateToJSON(callback.Date), callback.SleepTime / 60];
                var steps = [dateToJSON(callback.Date), callback.Steps];

                self.addExercises(exercises);
                self.addSleepTime(sleepTime);
                self.addSteps(steps);
            }
        });
    };
    
    */
   
    return self;
}
