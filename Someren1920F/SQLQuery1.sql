ALTER TABLE [StudentActivity]
ADD FOREIGN KEY (studentID) REFERENCES Person (personID);


ALTER TABLE [TeacherActivity]
ADD FOREIGN KEY (teacherID) REFERENCES Person (personID);

ALTER TABLE [activity]
ADD FOREIGN KEY (activityID) REFERENCES TeacherActivity (activityID) 

ALTER TABLE [activity]
ADD FOREIGN KEY (activityID) REFERENCES StudentActivity (activityID);

