-- Example case create statement:
CREATE TABLE users (
  id INTEGER NOT NULL PRIMARY KEY,
  userName VARCHAR(50) NOT NULL
);

CREATE TABLE roles (
  id INTEGER NOT NULL PRIMARY KEY,
  role VARCHAR(20) NOT NULL
);

INSERT INTO users(id, userName) VALUES(1, 'Steven Smith');
INSERT INTO users(id, userName) VALUES(2, 'Brian Burns');

INSERT INTO roles(id, role) VALUES(1, 'Project Manager');
INSERT INTO roles(id, role) VALUES(2, 'Solution Architect');

-- Improve the create table statement below:
CREATE TABLE users_roles (
  userId INTEGER,
  roleId INTEGER
);

-- The statements below should pass.
INSERT INTO users_roles(userId, roleId) VALUES(1, 1);
INSERT INTO users_roles(userId, roleId) VALUES(1, 2);
INSERT INTO users_roles(userId, roleId) VALUES(2, 2);

-- The statement below should fail.
INSERT INTO users_roles(userId, roleId) VALUES(2, NULL);