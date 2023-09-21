-- Tạo database EShopper
CREATE DATABASE EShopper;
USE EShopper;

-- Tạo bảng Categories
CREATE TABLE Categories (
    CategoryID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryName NVARCHAR(255)
);

-- Chèn dữ liệu vào bảng Categories
INSERT INTO Categories (CategoryName)
VALUES
    ('Dresses'),
    ('Shirts'),
    ('Jeans'),
    ('Swimwear'),
    ('Sleepwear'),
    ('Sportswear'),
    ('Jumpsuits'),
    ('Blazers'),
    ('Jackets'),
    ('Shoes');

-- Tạo bảng Products
CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) PRIMARY KEY,
    CategoryID INT,
    ImageURL NVARCHAR(255),
    ProductName NVARCHAR(255),
    Size NVARCHAR(50),
    Quantity INT,
    Color NVARCHAR(50),
    Description NVARCHAR(MAX),
    Collection NVARCHAR(255),
    DiscountPercentage DECIMAL(5,2),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

-- Tạo bảng Users
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50),
    Password NVARCHAR(255),
    Role NVARCHAR(50)
);

-- Tạo bảng Reviews
CREATE TABLE Reviews (
    ReviewID INT IDENTITY(1,1) PRIMARY KEY,
    ProductID INT,
    UserID INT,
    Rating INT,
    Comment NVARCHAR(MAX),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (UserID) REFERENCES Users(UserID)
);

-- Tạo bảng Orders
CREATE TABLE Orders (
    OrderID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT,
    ProductID INT,
    TotalAmount DECIMAL(10,2),
    Username NVARCHAR(50),
    PhoneNumber NVARCHAR(20),
    Address NVARCHAR(MAX),
    Country NVARCHAR(50),
    City NVARCHAR(50),
    FOREIGN KEY (UserID) REFERENCES Users(UserID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);

-- Chèn dữ liệu vào bảng Products (20 sản phẩm mẫu)
INSERT INTO Products (CategoryID, ImageURL, ProductName, Size, Quantity, Color, Description, Collection, DiscountPercentage)
VALUES
    (1, 'dress1.jpg', 'Summer Dress 1', 'S', 50, 'Blue', 'Beautiful summer dress for women', 'Summer Collection', 10),
    (1, 'dress2.jpg', 'Summer Dress 2', 'M', 40, 'Red', 'Elegant summer dress for ladies', 'Summer Collection', 15),
    (2, 'shirt1.jpg', 'Casual Shirt 1', 'L', 30, 'White', 'Comfortable men''s casual shirt', 'Casual Wear', 5),
    (2, 'shirt2.jpg', 'Formal Shirt 1', 'M', 25, 'Black', 'Classic black formal shirt', 'Formal Wear', 0),
    (3, 'jeans1.jpg', 'Slim Fit Jeans 1', '32', 20, 'Dark Blue', 'Stylish men''s slim fit jeans', 'Denim Collection', 20),
    (3, 'jeans2.jpg', 'Skinny Jeans 1', '30', 15, 'Light Blue', 'Trendy women''s skinny jeans', 'Denim Collection', 10),
    (4, 'swimwear1.jpg', 'Swimsuit 1', 'S', 40, 'Black', 'Fashionable women''s swimsuit', 'Beach Collection', 10),
    (4, 'swimwear2.jpg', 'Swimsuit 2', 'M', 35, 'Red', 'Comfortable women''s swimwear', 'Beach Collection', 15),
    (5, 'sleepwear1.jpg', 'Pajama Set 1', 'L', 30, 'Pink', 'Cozy women''s pajama set', 'Nightwear Collection', 5),
    (5, 'sleepwear2.jpg', 'Pajama Set 2', 'M', 25, 'Blue', 'Soft men''s pajama set', 'Nightwear Collection', 0),
    (6, 'sportswear1.jpg', 'Sports Tights 1', 'M', 20, 'Black', 'High-performance sports tights', 'Activewear Collection', 10),
    (6, 'sportswear2.jpg', 'Yoga Pants 1', 'S', 15, 'Purple', 'Stretchy yoga pants for women', 'Activewear Collection', 20),
    (7, 'jumpsuit1.jpg', 'Casual Jumpsuit 1', 'L', 30, 'Gray', 'Relaxed-fit jumpsuit for women', 'Casual Collection', 10),
    (7, 'jumpsuit2.jpg', 'Denim Jumpsuit 1', 'M', 25, 'Blue', 'Trendy denim jumpsuit', 'Denim Collection', 15),
    (8, 'blazer1.jpg', 'Formal Blazer 1', 'L', 20, 'Black', 'Classic black blazer for men', 'Formal Collection', 0),
    (8, 'blazer2.jpg', 'Blazer Jacket 1', 'M', 15, 'Navy Blue', 'Stylish navy blue blazer jacket', 'Formal Collection', 5),
    (9, 'jacket1.jpg', 'Leather Jacket 1', 'XL', 10, 'Brown', 'Fashionable leather jacket for men', 'Outerwear Collection', 10),
    (9, 'jacket2.jpg', 'Winter Jacket 1', 'L', 8, 'Black', 'Warm winter jacket for women', 'Outerwear Collection', 15),
    (10, 'shoes1.jpg', 'Sneakers 1', 'US 9', 20, 'White', 'Comfortable white sneakers', 'Footwear Collection', 0),
    (10, 'shoes2.jpg', 'High Heels 1', 'US 7', 15, 'Red', 'Elegant red high heels for women', 'Footwear Collection', 10);

