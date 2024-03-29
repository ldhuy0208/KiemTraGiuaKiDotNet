USE [master]
GO
/****** Object:  Database [DanhBa]    Script Date: 06/11/2019 01:59:26 SA ******/
CREATE DATABASE [DanhBa]
GO
USE [DanhBa]
GO
/****** Object:  Table [dbo].[LienHe]    Script Date: 06/11/2019 01:59:26 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LienHe](
	[MaLienHe] [int] IDENTITY(1,1) NOT NULL,
	[TenLienHe] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[SoDienThoai] [nchar](15) NULL,
 CONSTRAINT [PK_LienHe] PRIMARY KEY CLUSTERED 
(
	[MaLienHe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhom]    Script Date: 06/11/2019 01:59:26 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhom](
	[MaNhom] [int] IDENTITY(1,1) NOT NULL,
	[TenNhom] [nvarchar](50) NULL,
 CONSTRAINT [PK_Nhom] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhom_LienHe]    Script Date: 06/11/2019 01:59:26 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhom_LienHe](
	[MaNhom] [int] NOT NULL,
	[MaLienHe] [int] NOT NULL,
 CONSTRAINT [PK_Nhom_LienHe] PRIMARY KEY CLUSTERED 
(
	[MaNhom] ASC,
	[MaLienHe] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LienHe] ON 

INSERT [dbo].[LienHe] ([MaLienHe], [TenLienHe], [Email], [DiaChi], [SoDienThoai]) VALUES (1, N'Huy', NULL, N'Tây 9', N'0868678969     ')
INSERT [dbo].[LienHe] ([MaLienHe], [TenLienHe], [Email], [DiaChi], [SoDienThoai]) VALUES (2, N'Ba', NULL, N'Lao Bảo', N'0983009560     ')
INSERT [dbo].[LienHe] ([MaLienHe], [TenLienHe], [Email], [DiaChi], [SoDienThoai]) VALUES (3, N'Bảo', NULL, N'Đà Nẵng', N'0342762999     ')
SET IDENTITY_INSERT [dbo].[LienHe] OFF
SET IDENTITY_INSERT [dbo].[Nhom] ON 

INSERT [dbo].[Nhom] ([MaNhom], [TenNhom]) VALUES (1, N'Gia đình')
INSERT [dbo].[Nhom] ([MaNhom], [TenNhom]) VALUES (2, N'Bạn bè')
INSERT [dbo].[Nhom] ([MaNhom], [TenNhom]) VALUES (3, N'Công ty')
INSERT [dbo].[Nhom] ([MaNhom], [TenNhom]) VALUES (4, N'Trường học')
SET IDENTITY_INSERT [dbo].[Nhom] OFF
INSERT [dbo].[Nhom_LienHe] ([MaNhom], [MaLienHe]) VALUES (1, 2)
INSERT [dbo].[Nhom_LienHe] ([MaNhom], [MaLienHe]) VALUES (1, 3)
INSERT [dbo].[Nhom_LienHe] ([MaNhom], [MaLienHe]) VALUES (2, 1)
INSERT [dbo].[Nhom_LienHe] ([MaNhom], [MaLienHe]) VALUES (2, 3)
INSERT [dbo].[Nhom_LienHe] ([MaNhom], [MaLienHe]) VALUES (4, 1)
ALTER TABLE [dbo].[Nhom_LienHe]  WITH CHECK ADD  CONSTRAINT [FK_Nhom_LienHe_LienHe] FOREIGN KEY([MaLienHe])
REFERENCES [dbo].[LienHe] ([MaLienHe])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nhom_LienHe] CHECK CONSTRAINT [FK_Nhom_LienHe_LienHe]
GO
ALTER TABLE [dbo].[Nhom_LienHe]  WITH CHECK ADD  CONSTRAINT [FK_Nhom_LienHe_Nhom] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[Nhom] ([MaNhom])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nhom_LienHe] CHECK CONSTRAINT [FK_Nhom_LienHe_Nhom]
GO
/****** Object:  StoredProcedure [dbo].[LienHe_LayDanhSachLienHe]    Script Date: 06/11/2019 01:59:26 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LienHe_LayDanhSachLienHe] 
	@MaNhom	int = NULL
AS
BEGIN
	SET NOCOUNT ON;

	SELECT	LH.*
	FROM	LienHe		LH
	JOIN	Nhom_LienHe	NL
	ON		LH.MaLienHe = NL.MaLienHe AND NL.MaNhom = @MaNhom OR @MaNhom = NULL
	
END
GO
/****** Object:  StoredProcedure [dbo].[LienHe_ThemLienHe]    Script Date: 06/11/2019 01:59:26 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LienHe_ThemLienHe]
	@TenLienHe		nvarchar(50),
    @Email			nvarchar(50),
	@SoDienThoai	nchar(15),
    @DiaChi			nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO LienHe (TenLienHe, Email, SoDienThoai, DiaChi)
	VALUES
	(@TenLienHe, @Email, @SoDienThoai, @DiaChi)

	SELECT @@IDENTITY AS MaLienHe
END
    
GO
/****** Object:  StoredProcedure [dbo].[LienHe_TimKiem]    Script Date: 06/11/2019 01:59:26 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[LienHe_TimKiem]
	@Key nvarchar(50) = null
AS
BEGIN
	SET NOCOUNT ON;

	SELECT	*
	FROM	LienHe
	WHERE	TenLienHe	LIKE ('%'+@Key+'%')
	OR		Email		LIKE ('%'+@Key+'%')
	OR		SoDienThoai LIKE ('%'+@Key+'%')
	OR		DiaChi		LIKE ('%'+@Key+'%')
	OR		@Key		IS NULL
END

    
GO
/****** Object:  StoredProcedure [dbo].[LienHe_XoaLienHe]    Script Date: 06/11/2019 01:59:26 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LienHe_XoaLienHe]
	@MaLienHe	int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE
	FROM	LienHe
	WHERE	MaLienHe = @MaLienHe
END
GO
/****** Object:  StoredProcedure [dbo].[Nhom_LayDanhSachNhom]    Script Date: 06/11/2019 01:59:26 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Nhom_LayDanhSachNhom]
AS
BEGIN
	SET NOCOUNT ON;

	SELECT * FROM Nhom
END
GO
/****** Object:  StoredProcedure [dbo].[Nhom_LienHe_Them]    Script Date: 06/11/2019 01:59:26 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[Nhom_LienHe_Them] 
	@MaNhom		int,
	@MaLienHe	int
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO Nhom_LienHe
	VALUES
	(@MaNhom, @MaLienHe)
END
    
GO
/****** Object:  StoredProcedure [dbo].[Nhom_ThemNhom]    Script Date: 06/11/2019 01:59:26 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Nhom_ThemNhom]
	@TenNhom	nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO NHOM (TenNhom)
	VALUES
	(@TenNhom)
END
GO
/****** Object:  StoredProcedure [dbo].[Nhom_XoaNhom]    Script Date: 06/11/2019 01:59:26 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[Nhom_XoaNhom]
	@MaNhom	int
AS
BEGIN
	SET NOCOUNT ON;

	DELETE
	FROM	Nhom
	WHERE	MaNhom = @MaNhom
END
GO
USE [master]
GO
ALTER DATABASE [DanhBa] SET  READ_WRITE 
GO
