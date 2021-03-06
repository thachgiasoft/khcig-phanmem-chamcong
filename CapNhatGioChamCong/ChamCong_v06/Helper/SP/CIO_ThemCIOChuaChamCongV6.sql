IF EXISTS (
	   SELECT type_desc, type
	   FROM sys.procedures WITH(NOLOCK)
	   WHERE NAME = 'CIO_ThemCIOChuaChamCongV6'
		   AND type = 'P'
	 )
DROP PROCEDURE  CIO_ThemCIOChuaChamCongV6
GO
CREATE PROCEDURE [dbo].[CIO_ThemCIOChuaChamCongV6]
@UserEnrollNumber int
		   ,@NgayCong datetime
		   ,@HaveINOUT int
		   ,@KyHieuCa nvarchar(50)
		   ,@GioVao datetime
		   ,@GioRa datetime
		   ,@Vao int
		   ,@Ra int
		   ,@MayVao int
		   ,@MayRa int
		   ,@BDCa int
		   ,@KTCa int
		   ,@SoPhutNghiTrua int
		   ,@BDLV int
		   ,@KTLVTrongCa int
		   ,@KTLV int
		   ,@BDLVCa3 int
		   ,@KTLVCa3 int
		   ,@QuaDem bit
		   ,@Tre int
		   ,@Som int
		   ,@VaoSauCa int
		   ,@RaTruocCa int
		   ,@SoPhutXacNhanNgoaiGio int
		   ,@ChoPhepTre bit
		   ,@ChoPhepSom bit
		   ,@VaoTuDo bit
		   ,@RaTuDo bit
		   ,@TinhCongThuCong bit
		   ,@ChamCongTay real
		   ,@CongTrongGio real
		   ,@CongNgoaiGio real
		   ,@TruCongTre real
		   ,@TruCongSom real
		   --ko co GhiChu, LyDo
		   ,@TheoDoiGioGocMayCC nvarchar(2000)
AS
begin
INSERT INTO CIO
		   (UserEnrollNumber
		   ,NgayCong
		   ,HaveINOUT
		   ,KyHieuCa
		   ,GioVao
		   ,GioRa
		   ,Vao
		   ,Ra
		   ,MayVao
		   ,MayRa
		   ,BDCa
		   ,KTCa
		   ,SoPhutNghiTrua
		   ,BDLV
		   ,KTLVTrongCa
		   ,KTLV
		   ,BDLVCa3
		   ,KTLVCa3
		   ,QuaDem
		   ,Tre
		   ,Som
		   ,VaoSauCa
		   ,RaTruocCa
		   ,SoPhutXacNhanNgoaiGio
		   ,ChoPhepTre
		   ,ChoPhepSom
		   ,VaoTuDo
		   ,RaTuDo
		   ,TinhCongThuCong
		   ,ChamCongTay
		   ,CongTrongGio
		   ,CongNgoaiGio
		   ,TruCongTre
		   ,TruCongSom
		   ,TheoDoiGioGocMayCC
		   )
	 VALUES
		   (@UserEnrollNumber,
		   @NgayCong,
		   @HaveINOUT,
		   @KyHieuCa,
		   @GioVao,
		   @GioRa,
		   @Vao,
		   @Ra,
		   @MayVao,
		   @MayRa,
		   @BDCa,
		   @KTCa,
		   @SoPhutNghiTrua,
		   @BDLV,
		   @KTLVTrongCa,
		   @KTLV,
		   @BDLVCa3,
		   @KTLVCa3,
		   @QuaDem,
		   @Tre,
		   @Som,
		   @VaoSauCa,
		   @RaTruocCa,
		   @SoPhutXacNhanNgoaiGio,
		   @ChoPhepTre,
		   @ChoPhepSom,
		   @VaoTuDo,
		   @RaTuDo,
		   @TinhCongThuCong,
		   @ChamCongTay,
		   @CongTrongGio,
		   @CongNgoaiGio,
		   @TruCongTre,
		   @TruCongSom,
		   @TheoDoiGioGocMayCC
		   )
end


