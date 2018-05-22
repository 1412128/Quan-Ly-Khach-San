/*
 Navicat Premium Data Transfer

 Source Server         : localhost_3306
 Source Server Type    : MySQL
 Source Server Version : 50719
 Source Host           : localhost:3306
 Source Schema         : db.quanlykhachsan

 Target Server Type    : MySQL
 Target Server Version : 50719
 File Encoding         : 65001

 Date: 22/05/2018 23:23:33
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for account_nhanvien
-- ----------------------------
DROP TABLE IF EXISTS `account_nhanvien`;
CREATE TABLE `account_nhanvien`  (
  `IDTaiKhoan` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `TaiKhoan` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `MatKhau` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`IDTaiKhoan`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of account_nhanvien
-- ----------------------------
INSERT INTO `account_nhanvien` VALUES ('0', 'nhanvien2', '123');
INSERT INTO `account_nhanvien` VALUES ('1', 'quanly1', '1');
INSERT INTO `account_nhanvien` VALUES ('2', 'quanly2', '1');
INSERT INTO `account_nhanvien` VALUES ('3', 'nhanvien1', '3423453565');

-- ----------------------------
-- Table structure for baobieu
-- ----------------------------
DROP TABLE IF EXISTS `baobieu`;
CREATE TABLE `baobieu`  (
  `IDBaoBieu` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `IDPhong` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `IDNhanVien` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `IDKhachHang` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ThoiGianBatDau` datetime(6) NOT NULL,
  `ThoiGianKetThuc` datetime(6) NOT NULL,
  `DSDichVu` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `TongTien` int(255) NOT NULL,
  PRIMARY KEY (`IDBaoBieu`) USING BTREE,
  INDEX `fk_baobieu_dichvu`(`DSDichVu`) USING BTREE,
  INDEX `fk_baobieu_khachhang`(`IDKhachHang`) USING BTREE,
  INDEX `fk_baobieu_nhanvien`(`IDNhanVien`) USING BTREE,
  INDEX `fk_baobieu_phong`(`IDPhong`) USING BTREE,
  CONSTRAINT `fk_baobieu_khachhang` FOREIGN KEY (`IDKhachHang`) REFERENCES `khachhang` (`IDKhachHang`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_baobieu_nhanvien` FOREIGN KEY (`IDNhanVien`) REFERENCES `nhanvien` (`IDNhanVien`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `fk_baobieu_phong` FOREIGN KEY (`IDPhong`) REFERENCES `phong` (`IDPhong`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of baobieu
-- ----------------------------
INSERT INTO `baobieu` VALUES ('0', '0', '1', '0', '2018-01-01 00:00:00.000000', '2018-01-03 00:00:00.000000', '1,0,2', 1000000);
INSERT INTO `baobieu` VALUES ('1', '11', '1', '1', '2018-05-10 16:17:00.000000', '2018-05-22 22:08:04.000000', '', 293851200);
INSERT INTO `baobieu` VALUES ('2', '3', '1', '0', '2018-05-18 16:17:00.000000', '2018-05-22 22:08:37.000000', ',0,1,2', 102961500);
INSERT INTO `baobieu` VALUES ('3', '17', '1', '1', '2018-05-05 16:17:00.000000', '2018-05-22 22:09:40.000000', '2', 206940000);
INSERT INTO `baobieu` VALUES ('4', '2', '1', '9', '2018-05-22 22:21:24.000000', '2018-05-22 22:29:16.000000', '', 131159);

-- ----------------------------
-- Table structure for dichvu
-- ----------------------------
DROP TABLE IF EXISTS `dichvu`;
CREATE TABLE `dichvu`  (
  `IDDichVu` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `TenDichVu` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Gia` float(255, 0) NOT NULL,
  `TinhTrang` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  PRIMARY KEY (`IDDichVu`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of dichvu
-- ----------------------------
INSERT INTO `dichvu` VALUES ('0', 'Massage1', 1000000, 'Đang hoạt động');
INSERT INTO `dichvu` VALUES ('1', 'Thuê Xe Máy', 100000, 'Đang hoạt động');
INSERT INTO `dichvu` VALUES ('2', 'Thuê xe đạp', 1000, 'Đang hoạt động');

-- ----------------------------
-- Table structure for khachhang
-- ----------------------------
DROP TABLE IF EXISTS `khachhang`;
CREATE TABLE `khachhang`  (
  `IDKhachHang` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `HoTen` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `CMND` int(9) NOT NULL,
  `NgaySinh` varchar(10) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `SDT` int(11) NOT NULL,
  PRIMARY KEY (`IDKhachHang`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of khachhang
-- ----------------------------
INSERT INTO `khachhang` VALUES ('0', 'Doan Van Ho', 111111111, '1996-05-05', 12345678);
INSERT INTO `khachhang` VALUES ('1', 'Nguyen Luu', 2245345, '1997-08-08', 123456789);
INSERT INTO `khachhang` VALUES ('2', 'Ho Van Cuoi', 333333333, '2000-01-01', 123456789);
INSERT INTO `khachhang` VALUES ('3', 'Ho Ngoc Ha', 444444444, '2001-08-12', 123456789);
INSERT INTO `khachhang` VALUES ('4', 'Ngo Viet Cuong', 555555555, '1996-05-05', 123456789);
INSERT INTO `khachhang` VALUES ('5', 'Van A', 1234, '1996-07-19', 12345678);
INSERT INTO `khachhang` VALUES ('6', 'Nguyen Dat', 123456789, '1996-01-02', 132);
INSERT INTO `khachhang` VALUES ('7', 'Nguyen', 123, '1996-1-1', 123465789);
INSERT INTO `khachhang` VALUES ('8', 'Ngoc', 123412, '1996-01-12', 231313);
INSERT INTO `khachhang` VALUES ('9', 'asd2', 12312, '1996-01-01', 1231);

-- ----------------------------
-- Table structure for nhanvien
-- ----------------------------
DROP TABLE IF EXISTS `nhanvien`;
CREATE TABLE `nhanvien`  (
  `IDNhanVien` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `TenNhanVien` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `NgaySinh` datetime(6) NOT NULL,
  `CMND` int(255) NOT NULL,
  `ChucVu` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Luong` int(255) NOT NULL,
  PRIMARY KEY (`IDNhanVien`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of nhanvien
-- ----------------------------
INSERT INTO `nhanvien` VALUES ('0', 'Phuo1', '2000-07-11 00:00:00.000000', 123456789, 'Nhan vien', 7000000);
INSERT INTO `nhanvien` VALUES ('1', 'Nhan Vien', '1991-08-11 00:00:00.000000', 123456789, 'Quan Ly', 1000000);

-- ----------------------------
-- Table structure for phong
-- ----------------------------
DROP TABLE IF EXISTS `phong`;
CREATE TABLE `phong`  (
  `IDPhong` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `TenPhong` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `LoaiPhong` int(1) NOT NULL,
  `TrangThai` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `DonGia` float(255, 0) NOT NULL,
  PRIMARY KEY (`IDPhong`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of phong
-- ----------------------------
INSERT INTO `phong` VALUES ('0', 'Phòng Vip1', 0, 'Đang Sử Dụng', 1000000);
INSERT INTO `phong` VALUES ('1', 'Phòng Vip2', 0, 'Còn Trống', 1000000);
INSERT INTO `phong` VALUES ('10', 'Phòng Vip10', 0, 'Đang Bảo Trì', 1000000);
INSERT INTO `phong` VALUES ('11', 'Phòng Vip11', 0, 'Đang Sử Dụng', 1000000);
INSERT INTO `phong` VALUES ('12', 'Phòng Vip12', 0, 'Đang Bảo Trì', 1000000);
INSERT INTO `phong` VALUES ('13', 'Phòng 4 Sao2', 1, 'Còn Trống', 500000);
INSERT INTO `phong` VALUES ('14', 'Phòng 4 Sao3', 1, 'Còn Trống', 500000);
INSERT INTO `phong` VALUES ('15', 'Phòng 4 Sao4', 1, 'Còn Trống', 500000);
INSERT INTO `phong` VALUES ('16', 'Phòng 4 Sao5', 1, 'Đang Bảo Trì', 50000);
INSERT INTO `phong` VALUES ('17', 'Phòng 4 Sao6', 1, 'Còn Trống', 500000);
INSERT INTO `phong` VALUES ('18', 'Phòng 4 Sao7', 1, 'Đang Bảo Trì', 500000);
INSERT INTO `phong` VALUES ('19', 'Phòng 4 Sao8', 1, 'Đang Sử Dụng', 500000);
INSERT INTO `phong` VALUES ('2', 'Phòng Vip3', 0, 'Còn Trống', 1000000);
INSERT INTO `phong` VALUES ('20', 'Phòng 4 Sao9', 1, 'Đang Bảo Trì', 500000);
INSERT INTO `phong` VALUES ('21', 'Phòng 4 Sao1', 1, 'Đang Bảo Trì', 500000);
INSERT INTO `phong` VALUES ('22', 'Phòng 3 Sao1', 2, 'Đang Bảo Trì', 300000);
INSERT INTO `phong` VALUES ('23', 'Phòng 3 Sao2', 2, 'Còn Trống', 300000);
INSERT INTO `phong` VALUES ('24', 'Phòng 3 Sao3', 2, 'Còn Trống', 300000);
INSERT INTO `phong` VALUES ('3', 'Phòng Vip3', 0, 'Còn Trống', 1000000);
INSERT INTO `phong` VALUES ('4', 'Phòng Vip4', 0, 'Đang Bảo Trì', 1000000);
INSERT INTO `phong` VALUES ('6', 'Phòng Vip6', 0, 'Đang Bảo Trì', 1000000);
INSERT INTO `phong` VALUES ('7', 'Phòng Vip7', 0, 'Còn Trống', 1000000);
INSERT INTO `phong` VALUES ('8', 'Phòng Vip7', 0, 'Còn Trống', 1000000);
INSERT INTO `phong` VALUES ('9', 'Phòng Vip8', 0, 'Còn Trống', 1000000);

-- ----------------------------
-- Table structure for phong_dangsudung
-- ----------------------------
DROP TABLE IF EXISTS `phong_dangsudung`;
CREATE TABLE `phong_dangsudung`  (
  `IDPhong` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `ThoiGianBatDau` datetime(6) NOT NULL,
  `IDKhachHang` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `DsDichVu` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `GiaDichVu` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of phong_dangsudung
-- ----------------------------
INSERT INTO `phong_dangsudung` VALUES ('19', '2018-05-08 16:17:00.000000', '2', '1,0,2,2', '642030');
INSERT INTO `phong_dangsudung` VALUES ('0', '2018-05-22 14:45:44.000000', '7', ',0,1,2', '1101000');
INSERT INTO `phong_dangsudung` VALUES ('11', '2018-05-22 22:14:35.000000', '8', '', '0');

SET FOREIGN_KEY_CHECKS = 1;
