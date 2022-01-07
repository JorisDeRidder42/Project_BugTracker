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
VALUES(1,'Jeuris42','Joris.42@hotmail.com', 1,'Meloen',null,null,'0492641323', 1,1,null,1,0,1,1,'Jeuris42', 'Meloen','1997-02-21', 'Joris', 'De Ridder', 'Joris.42@hotmail.com',1)
INSERT INTO BugTracker.ApplicationUser
VALUES(2,'TankZwaluw','Alec@hotmail.com', 1,'Banaan',null,null,'0492772512', 1,1,null,1,0,2,2,'TankZwaluw', 'Banaan','2000-04-12', 'Alec', 'Van oosterwick', 'Alec@hotmail.com',1)


INSERT INTO BugTracker.Bugs
VALUES(1,2,3,'Databaseconnectionstring', 'kan geen verbinding maken met de db', 'Alec','2021-12-14', null, null, 1)
INSERT INTO BugTracker.Bugs
VALUES(2,3,3,'Bugs tonen', 'Bugs worden niet getoond', 'Joris','2022-01-07', null, null,2)

INSERT INTO BugTracker.Teams
VALUES('JullieZijnGeslaagd', 2,1)
INSERT INTO BugTracker.Teams
VALUES('Thecoders', 2,2)
