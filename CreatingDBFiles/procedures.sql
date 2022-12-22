create user ProjektUser identified by PU;  -- user created
grant create table to projektuser;	-- granted creating tables
alter user projektuser quota 100m on users; 	-- changed available space for user's tables

CREATE OR REPLACE PROCEDURE DropTablesAndSeq IS
BEGIN
FOR c IN (SELECT table_name FROM user_tables) LOOP
EXECUTE IMMEDIATE ('DROP TABLE "' || c.table_name || '" CASCADE CONSTRAINTS');
END LOOP;
FOR s IN (SELECT sequence_name FROM user_sequences) LOOP
EXECUTE IMMEDIATE ('DROP SEQUENCE ' || s.sequence_name);
END LOOP;
END;

CREATE OR REPLACE PROCEDURE ObliczKwote(pIdTransakcji IN NUMBER) IS
vSum NUMBER;
CURSOR cData IS
    SELECT ID_PRODUKTU, ILOSC, ZNIZKA FROM PRODUKT_W_KOSZYKU WHERE ID_KOSZYKA = 
    (SELECT ID_KOSZYKA FROM TRANSAKCJA WHERE ID_TRANSAKCJI = 1);
vIdProd NUMBER;
vZnizka NUMBER;
vIlosc NUMBER;
vCena NUMBER;
BEGIN
    vSum := 0;
    OPEN cData;
    LOOP 
        FETCH cData INTO vIdProd, vIlosc, vZnizka;
        SELECT CENA_JEDN INTO vCena FROM PRODUKT WHERE ID_PRODUKTU = vIdProd;
        if cData%FOUND THEN
            vSum := vSum + (vCena * vIlosc * ((100 - vZnizka)/100));
        ELSE
            EXIT;
        END IF;
    END LOOP;
    DBMS_OUTPUT.PUT_LINE('Suma transakcji: ');
    DBMS_OUTPUT.PUT_LINE(vSum);
    CLOSE cData;
END;


