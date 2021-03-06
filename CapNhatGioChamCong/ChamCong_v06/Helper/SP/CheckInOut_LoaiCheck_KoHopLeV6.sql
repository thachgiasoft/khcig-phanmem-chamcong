IF EXISTS (
	   SELECT type_desc, type
	   FROM sys.procedures WITH(NOLOCK)
	   WHERE NAME = 'CheckInOut_LoaiCheck_KoHopLeV6'
		   AND type = 'P'
	 )
DROP PROCEDURE  CheckInOut_LoaiCheck_KoHopLeV6
GO
CREATE PROCEDURE [dbo].[CheckInOut_LoaiCheck_KoHopLeV6]
@UserEnrollNumber int ,
@TimeStr datetime,
@MachineNo int,
@Loai bit,
@DaChamCong bit
AS
BEGIN
	SET NOCOUNT ON;

	update CheckInOut
	set Loai = @Loai, DaChamCong = @DaChamCong
	where UserEnrollNumber = @UserEnrollNumber
	and MachineNo = @MachineNo
	and TimeStr = @TimeStr
END
