CREATE DATABASE LibraryManagement;

GO
USE LibraryManagement;

GO

-- Tạo bảng khách hàng
CREATE TABLE Customer (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),			-- Khóa chính, tự tăng
    Name NVARCHAR(100) NOT NULL,						-- Họ tên khách hàng
    Gender NVARCHAR(10) NOT NULL,						-- Giới tính
    DateOfBirth DATE NOT NULL,							-- Ngày sinh
    Address NVARCHAR(255) NOT NULL,						-- Địa chỉ
    PhoneNumber NVARCHAR(10) NOT NULL,					-- Số điện thoại
    CitizenIdentification NVARCHAR(12) NOT NULL UNIQUE, -- Số CCCD/CMND
    StartDate DATE NOT NULL,								-- Ngày cấp thẻ
	IsDeleted BIT DEFAULT 0
);

-- Tạo bảng Kệ sách
CREATE TABLE Shelf (
    ShelfID INT PRIMARY KEY IDENTITY(1,1),
    ShelfName NVARCHAR(100) NOT NULL,
	IsDeleted BIT DEFAULT 0
);

-- Tạo bảng sách
CREATE TABLE Book (
    BookID INT PRIMARY KEY IDENTITY(1,1),   -- Khóa chính, tự tăng
    Name NVARCHAR(255) NOT NULL,            -- Tên sách
    ShelfID INT,							-- Mã Kệ sách
    Publisher NVARCHAR(100) NOT NULL,       -- Nhà xuất bản
    DateOfRelease DATE,                     -- Ngày xuất bản
    Author NVARCHAR(50),                    -- Tên tác giả
    Quantity INT NOT NULL,                  -- Số lượng
    Price DECIMAL(10, 2) NOT NULL           -- Giá tiền
	FOREIGN KEY (ShelfID) REFERENCES Shelf(ShelfID), -- Tạo khóa ngoại
	IsDeleted BIT DEFAULT 0
);

-- Tạo bảng phiếu thuê
CREATE TABLE RentalSlip (
    RentalSlipID INT PRIMARY KEY IDENTITY(1,1), -- Khóa chính, tự tăng
    CustomerID INT NOT NULL,                    -- Khách hàng (khóa ngoại)
    RentalDate DATE NOT NULL,                   -- Ngày thuê
    DueDate DATE NOT NULL,                      -- Hạn trả dự kiến
    ReturnDate DATE,                            -- Ngày trả thực tế
    TotalFee DECIMAL(10, 2),					-- Tổng tiền thuê
    IsReturnedOnTime BIT,						-- Đã trả đúng hạn (1: Có, 0: Không)
    IsBookIntact BIT,							-- Sách nguyên vẹn (1: Có, 0: Không)
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);

-- Tạo bảng chi tiết phiếu thuê
CREATE TABLE RentalSlipDetail (
    RentalSlipDetailID INT PRIMARY KEY IDENTITY(1,1), -- Khóa chính, tự tăng
    RentalSlipID INT NOT NULL,                        -- Phiếu thuê (khóa ngoại)
    BookID INT NOT NULL,                              -- Mã sách (khóa ngoại)
    Quantity INT NOT NULL,                            -- Số lượng sách thuê
    RentalFee DECIMAL(10, 2) NOT NULL,                -- Phí thuê
    FOREIGN KEY (RentalSlipID) REFERENCES RentalSlip(RentalSlipID),
    FOREIGN KEY (BookID) REFERENCES Book(BookID)
);

-- Tạo bảng User
CREATE TABLE [User] (
    UserID INT PRIMARY KEY IDENTITY(1,1),	-- Khóa chính, tự tăng
    Email NVARCHAR(100) NOT NULL UNIQUE,    -- Email đăng nhập
    [Password] NVARCHAR(255) NOT NULL,		-- Mật khẩu
    Name NVARCHAR(100) NOT NULL,			-- Họ tên
    DateOfBirth DATE NOT NULL,				-- Ngày sinh
    Address NVARCHAR(255) NOT NULL,			-- Địa chỉ
    Gender NVARCHAR(10) NOT NULL,			-- Giới tính
    PhoneNumber NVARCHAR(10) NOT NULL,		-- Số điện thoại
    CitizenIdentification NVARCHAR(12) NOT NULL UNIQUE,		-- Số CCCD/CMND
    Role NVARCHAR(10) NOT NULL,				-- Vai trò (Admin/Nhân viên)
	IsDeleted BIT DEFAULT 0
);
ALTER TABLE Book ADD Image VARBINARY(MAX) NULL;

delete Customer;

DBCC CHECKIDENT ('Customer', RESEED, 0);