create user ProjektUser identified by PU;  -- user created
grant create table to projektuser;	-- granted creating tables
alter user projektuser quota 100m on users; 	-- changed available space for user's tables
