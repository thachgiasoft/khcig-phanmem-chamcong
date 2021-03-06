USE [WiseEyeV5Express]
GO
/****** Object:  StoredProcedure [dbo].[sp_ThongKeCongVaPhuCap]    Script Date: 3/24/2015 4:08:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_ThongKeCongVaPhuCap]
	@ArrUserEnrollNumber as IntArray readonly,
	@NgayBatDau datetime,	@NgayKetThuc datetime
AS
BEGIN
--declare @NgayBatDau datetime
--declare @NgayKetThuc datetime
--	set @NgayBatDau = N'20140101'
--	set @NgayKetThuc = N'20150201'
	select		ngay.UserEnrollNumber, SUM(ngay.TongCong) as TongCong, SUM(ngay.TongPC) as TongPC,
				(select		SUM(Workingday) 
				from		Absent 
				where		Absent.UserEnrollNumber = ngay.UserEnrollNumber and AbsentCode = N'P'
							and (Absent.TimeDate >= @NgayBatDau and Absent.TimeDate <= @NgayKetThuc)
				group by	Absent.UserEnrollNumber ) as TongPhep
	from		KetCongNgay ngay
	where		ngay.UserEnrollNumber in (select * from @ArrUserEnrollNumber) and 
				(ngay.Ngay >= @NgayBatDau and ngay <= @NgayKetThuc)
				-- and u.UserEnrollNumber = ngay.UserEnrollNumber
				--and u.UserEnrollNumber = 9271
	group by	ngay.UserEnrollNumber
				
END
