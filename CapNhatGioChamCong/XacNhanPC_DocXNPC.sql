
ALTER PROCEDURE [dbo].[XacNhanPC_DocXNPC]
	@ArrayMaCC IntArray readonly,
	@NgayBD datetime, 
	@NgayKT datetime, 
	@Duyet bit
AS
BEGIN
	SELECT      ID, UserEnrollNumber, Ngay, LoaiPC, PCNgay, PCDem, Duyet
	FROM        XacNhanPC
	WHERE       Duyet = @Duyet and Ngay >= @NgayBD and Ngay <= @NgayKT 
				and ( UserEnrollNumber in (select * from @ArrayMaCC) )
	ORDER BY    UserEnrollNumber ASC, Ngay ASC 
END
