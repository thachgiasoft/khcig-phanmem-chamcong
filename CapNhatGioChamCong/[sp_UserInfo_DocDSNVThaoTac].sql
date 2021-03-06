USE [WiseEyeV5Express]
GO
/****** Object:  StoredProcedure [dbo].[sp_UserInfo_DocDSNVThaoTac]    Script Date: 3/23/2015 4:38:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Name
-- Create date: 
-- Description:	
-- =============================================
ALTER PROCEDURE [dbo].[sp_UserInfo_DocDSNVThaoTac] 
	@ArrUserIDD IntArray readonly
AS
BEGIN
	SELECT		(CAST (0 as bit)) as 'check',UserFullCode, UserFullName, UserEnrollNumber, UserLastName, UserEnrollName, 
				UserIDD as MaPhong, 
				--case when (UserIDD is null or UserIDD = 0) then N'--' else RelationDept.Description end as TenPhong, 
				--RelationDept.TinhPC50, RelationDept.ViTri,
				--UserIDTitle as IDChucVu, case when (UserInfo.UserIDTitle is null or UserInfo.UserIDTitle = 0)  then N'Chưa SX' else TitleName end as ChucVu, 
				UserInfo.SchID --, case when (UserInfo.SchID is null or UserInfo.SchID = 0)  then N'--' else SchName end as SchName,   
--									HeSoLuongCB, HeSoLuongSP, 
--									UserCardNo, HSBHCongThem, 
--									case when ( UserSex = 0 ) then N'Nam' else N'Nữ' end as UserSex, 
--									UserBirthDay, UserEnabled, UserHireDay, UserPrivilege 
	From		UserInfo
	where		UserIDD > 0 and UserIDD in (select * from @ArrUserIDD)
	order by	UserFullCode
END


--select	UserFullCode, UserFullName, UserEnrollNumber, UserLastName, UserEnrollName,
--									UserIDD as MaPhong, 
--									case when (UserIDD is null or UserIDD = 0) then N'--' else RelationDept.Description end as TenPhong, RelationDept.TinhPC50, RelationDept.ViTri,
 
--									UserIDTitle as IDChucVu, case when (UserInfo.UserIDTitle is null or UserInfo.UserIDTitle = 0)  then N'Chưa SX' else TitleName end as ChucVu, 

--									UserInfo.SchID, case when (UserInfo.SchID is null or UserInfo.SchID = 0)  then N'--' else SchName end as SchName,   

--									HeSoLuongCB, HeSoLuongSP, 
--									UserCardNo, HSBHCongThem, 
--									case when ( UserSex = 0 ) then N'Nam' else N'Nữ' end as UserSex, 
--									UserBirthDay, UserEnabled, UserHireDay, UserPrivilege 

--							FROM	UserInfo left join Title on UserInfo.UserIDTitle = Title.IDT
--									left join RelationDept on UserInfo.UserIDD = RelationDept.ID
--									left join Schedule on UserInfo.SchID = Schedule.SchID
--							{0}
--							order by UserFullCode