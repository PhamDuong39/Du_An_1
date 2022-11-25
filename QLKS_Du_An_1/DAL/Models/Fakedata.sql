use  QLKS_Du_An_1
go

insert into ChucVu
values ('c2809517-bc4f-4abd-b541-f1203cefe14d','CV1',N'Giám Đốc'),
		('ff13e79d-e06d-4f19-aab4-1b20f8f0a3b0','CV2',N'Nhân Viên Quèn'),
		('470af744-a3c1-4fda-b4d8-8ac078d20632','CV3',N'Quản Lý Quèn'),
		('c5802e5f-0a50-4921-a7ef-90c92c2ad306','CV4',N'Bảo Vệ')
insert into NhanVien
values ('49ae747b-5ba8-4c8f-a4ad-7fa4e915809c','NV1',N'Nguyễn A',2/2/2000,1,N'Gầm Cầu','0987654321','031234567890',1000,'c2809517-bc4f-4abd-b541-f1203cefe14d'),
		('9d8a046c-782a-4aa5-ae00-43cc5385a5ba','NV2',N'Nguyễn B',2/2/2000,1,N'Gầm Cầu','0987654321','031234567891',1000,'ff13e79d-e06d-4f19-aab4-1b20f8f0a3b0'),
		('75b2fb2d-d5f7-4055-bb44-deabd9a35111','NV3',N'Nguyễn C',2/2/2000,0,N'Gầm Cầu','0987654321','031234567892',1000,'470af744-a3c1-4fda-b4d8-8ac078d20632'),
		('99cf6035-da08-46d4-b094-bd1da5a9171d','NV4',N'Nguyễn D',2/2/2000,1,N'Gầm Cầu','0987654321','031234567893',1000,'c5802e5f-0a50-4921-a7ef-90c92c2ad306'),
		('163d1b9f-0254-4d80-a634-9002dcdbe102','NV5',N'Nguyễn E',2/2/2000,1,N'Gầm Cầu','0987654321','031234567890',1000,'c5802e5f-0a50-4921-a7ef-90c92c2ad306')
insert into TaiKhoan
values ('a0def50d-3efb-40f6-a54a-d6511b019638','NV1','123',0,'49ae747b-5ba8-4c8f-a4ad-7fa4e915809c'),
		('c240241b-b6dd-4605-bab3-ba62866ea170','NV2','123',1,'9d8a046c-782a-4aa5-ae00-43cc5385a5ba'),
		('0fa5fee8-bc9f-4940-a961-c1b554bae7dd','NV3','123',1,'75b2fb2d-d5f7-4055-bb44-deabd9a35111'),
		('4f29cb6b-1c96-456b-8cfd-ad9119d52e67','NV4','123',1,'99cf6035-da08-46d4-b094-bd1da5a9171d'),
		('6124996c-49da-4cf0-a990-164ae55494a7','NV5','123',1,'163d1b9f-0254-4d80-a634-9002dcdbe102')
insert into KhachHang
values('e1f3f710-491c-4100-825e-e47f41176bed','KH1',N'Trần A',039876543210,0912356789,N'Cầu Papper',1,N'Việt Nam'),
		('55262fb8-08b1-4beb-b09b-fd7f4c5fdabd','KH2',N'Trần B',039876543211,0912356789,N'Cầu Papper',0,N'Việt Nam'),
		('0cf393ce-c4b6-46cd-9ae7-e2c13082cee7','KH3',N'Trần C',039876543212,0912356789,N'Cầu Papper',0,N'Việt Nam'),
		('da1c1cbc-4767-4c4b-94e3-c6f583fb2f7a','KH4',N'Trần D',039876543213,0912356789,N'Cầu Papper',1,N'Việt Nam')
insert into LoaiDichVu
values('85c87692-4fda-4cbe-8449-f2080bf4fb84','DV1',N'Dịch Vụ 1'),
		('d00ca269-6c8a-4748-b4af-515e374a8bec','DV2',N'Dịch Vụ 2'),
		('fd692cb8-d807-4732-943b-2fae8f36f98e','DV3',N'Dịch Vụ 3'),
		('f69bc3a2-fc80-49da-b72d-d792da7b1970','DV4',N'Dịch Vụ 4')
insert into LoaiPhong
values('36d195a5-f31a-42ed-bde7-1c959dd4317e','LP1',N'Loại Phòng 1',10,100),
		('9094c31d-e013-4d60-9efa-312228767ea4','LP2',N'Loại Phòng 2',10,200),
		('e3f90502-8719-4205-938a-5229f04723c4','LP3',N'Loại Phòng 3',10,300),
		('40852914-9e25-4362-96d0-8cbaa36c192a','LP4',N'Loại Phòng 4',10,400)
insert into LoaiTienNghi
values('9768a004-5ea2-4421-99ac-6cf7c1d1406c','LTN1',N'Loại Tiện Nghi 1'),
		('98b34d42-049e-4665-baba-9ab75d92b67e','LTN2',N'Loại Tiện Nghi 2'),
		('04ee0e39-5f16-4195-bd3c-7ed68e94ecc2','LTN3',N'Loại Tiện Nghi 3'),
		('e0d47f05-00b3-43f3-a805-b47117e35a22','LTN4',N'Loại Tiện Nghi 4')
insert into PhieuThue
values('8716e1e8-9ffe-4ba5-a097-6f9a643e8d7a',2/2/2000,'e1f3f710-491c-4100-825e-e47f41176bed','9d8a046c-782a-4aa5-ae00-43cc5385a5ba'),
		('6e909cd4-14e7-4984-8a63-4afc8c090b9ea',2/2/2000,'55262fb8-08b1-4beb-b09b-fd7f4c5fdabd','9d8a046c-782a-4aa5-ae00-43cc5385a5ba'),
		('8244895b-ccff-4ccc-84f9-2af9d16576c6',2/2/2000,'0cf393ce-c4b6-46cd-9ae7-e2c13082cee7','75b2fb2d-d5f7-4055-bb44-deabd9a35111'),
		('3425f1aa-158b-403a-bb00-88e6eaf02de7',2/2/2000,'da1c1cbc-4767-4c4b-94e3-c6f583fb2f7a','9d8a046c-782a-4aa5-ae00-43cc5385a5ba')
insert into DichVu
values('36209f47-b65c-49e6-bc35-338a1e21c265','DV1',N'Dịch vụ 1',100,'85c87692-4fda-4cbe-8449-f2080bf4fb84'),
		('41d510da-de25-4961-b018-7999e7b1bb94','DV2',N'Dịch vụ 2',200,'d00ca269-6c8a-4748-b4af-515e374a8bec'),
		('2c077ae4-7388-4b24-ae01-7b74e2a5c8b3','DV3',N'Dịch vụ 3',300,'fd692cb8-d807-4732-943b-2fae8f36f98e'),
		('83f65b15-2bec-41a4-a4fc-44eb3d0a82d0','DV4',N'Dịch vụ 4',400,'f69bc3a2-fc80-49da-b72d-d792da7b1970')
insert into 