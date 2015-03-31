USE [WiseEyeV5Express]
GO
/****** Object:  StoredProcedure [dbo].[sp_KiemTraKetLuongThang]    Script Date: 3/24/2015 4:07:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_KiemTraKetLuongThang]	(@NgayDauThang datetime)
AS
BEGIN
	if exists (select Thang from ThongSoKetLuongThang where Thang = @NgayDauThang)
	begin return 1 end
	else begin return 0 end
END
