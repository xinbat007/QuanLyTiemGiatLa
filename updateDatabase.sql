use QuanLyTiemGiatLa;
go
--------------------------
ALTER TABLE dbo.Phieu ADD IsSynced bit NULL;
GO
--------------------------
ALTER TABLE dbo.KhachHang ADD IsSynced bit NULL;
GO
--------------------------