select * from Login

ALTER TABLE Login
ADD Position VARCHAR(10)

INSERT INTO Login VALUES ('mohammad', '1234', 'Doctor')
INSERT INTO Login VALUES ('admin', 'admin', 'Admin')
INSERT INTO Login VALUES ('ling', '4321', 'Nurse')
INSERT INTO Login VALUES ('melika', '1111', 'Admission')

SELECT * FROM Doctors
SELECT * FROM Patients