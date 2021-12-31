INSERT INTO BugTracker.BugStatus
VALUES('Functional errors')
INSERT INTO BugTracker.BugStatus
VALUES('Performance defects')
INSERT INTO BugTracker.BugStatus
VALUES('Usability defects')
INSERT INTO BugTracker.BugStatus
VALUES('Compatibility defects')
INSERT INTO BugTracker.BugStatus
VALUES('Security defects')
INSERT INTO BugTracker.BugStatus
VALUES('Syntax errors')
INSERT INTO BugTracker.BugStatus
VALUES('Logic errors')
INSERT INTO BugTracker.BugStatus
VALUES('Unit-level bugs')
INSERT INTO BugTracker.BugStatus
VALUES('System-level integration bugs')
INSERT INTO BugTracker.BugStatus
VALUES('Code Duplication')
INSERT INTO BugTracker.BugStatus
VALUES('Data Type Mismatch')

INSERT INTO BugTracker.BugsPriority
VALUES('Low')
INSERT INTO BugTracker.BugsPriority
VALUES('Medium')
INSERT INTO BugTracker.BugsPriority
VALUES('High')

INSERT INTO BugTracker.ApplicationUser
VALUES('Jeuris42','Joris.42@hotmail.com', 1,'Meloen',null,null,'0492641323', 1,1,null,1,0,1,1,1, 'Jeuris42', 'Meloen','1997-02-21 12:00:00', 'Joris', 'De Ridder', 'Joris.42@hotmail.com',1)


INSERT INTO BugTracker.Bugs(ApplicationId, BugStatusID, BugTitle, BugDescription, BugType, BugCreatedBy, BugCreatedOn, BugClosedBy, BugClosedOn)
VALUES(1,1,2,'Databaseconnectionstring', 'kan geen verbinding maken met de db', 'Usability defects', 'Alec','2021-12-14', null, null)

INSERT INTO BugTracker.Teams
VALUES('JullieZijnGeslaag', 2,3)
INSERT INTO BugTracker.Teams
VALUES('JullieZijnGeslaag', 2,4)
