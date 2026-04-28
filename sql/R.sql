
CREATE PROCEDURE Client_Read_Licenseno
    @Driver_License_Number INT = NULL
AS
BEGIN
    if @Driver_License_Number is null
        select * from Client;
    else
        select * from Client where Driver_License_Number = @Driver_License_Number;
END;
