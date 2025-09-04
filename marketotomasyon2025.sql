create database marketotomasyon;

create table admin(
kullanici_id int auto_increment primary key,
kullanici_ad varchar(50),
sifre varchar(30)
);
INSERT INTO admin (kullanici_ad, sifre)
VALUES ('admin', '1234');

CREATE TABLE Urunler (
    UrunID int auto_increment primary key,
    Barkod NVARCHAR(50) NOT NULL,
    UrunAdi NVARCHAR(100) NOT NULL,
    Kategori NVARCHAR(50),
    Marka NVARCHAR(50),
    AlisFiyati DECIMAL(10,2),
    SatisFiyati DECIMAL(10,2),
    UrunBirim nvarchar(30),
    Stok INT
);

CREATE TABLE Markalar (
    MarkaID INT AUTO_INCREMENT PRIMARY KEY,
    MarkaAdi NVARCHAR(100),
    Kategori NVARCHAR(100)
);

CREATE TABLE Satislar (
    SatisID INT AUTO_INCREMENT PRIMARY KEY,
    Barkod NVARCHAR(50),
    UrunAdi NVARCHAR(100),
    Marka NVARCHAR(50),
    SatisFiyati DECIMAL(10, 2),
    SatisTarihi DATETIME,
    Adet INT
);

select * from Satislar
select * from Urunler

