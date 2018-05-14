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

 Date: 14/05/2018 14:21:11
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for account_nhanvien
-- ----------------------------
DROP TABLE IF EXISTS `account_nhanvien`;
CREATE TABLE `account_nhanvien`  (
  `IDNhanVien` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `TaiKhoan` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `MatKhau` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for baobieu
-- ----------------------------
DROP TABLE IF EXISTS `baobieu`;
CREATE TABLE `baobieu`  (
  `IDBaoBieu` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `IDPhong` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `IDNhanVien` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `CMNDKhachHang` int(9) NOT NULL,
  `ThoiGianBatDau` datetime(6) NOT NULL,
  `ThoiGianKetThuc` datetime(6) NOT NULL,
  `DSDichVu` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `TongTien` float(255, 0) NOT NULL,
  PRIMARY KEY (`IDBaoBieu`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

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
-- Table structure for khachhang
-- ----------------------------
DROP TABLE IF EXISTS `khachhang`;
CREATE TABLE `khachhang`  (
  `HoTen` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `CMND` int(9) NOT NULL,
  `NgaySinh` datetime(6) NOT NULL,
  `SDT` int(11) NOT NULL,
  PRIMARY KEY (`CMND`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Table structure for nhanvien
-- ----------------------------
DROP TABLE IF EXISTS `nhanvien`;
CREATE TABLE `nhanvien`  (
  `IDNhanVien` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `TenNhanVien` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `NgaySinh` datetime(6) NOT NULL,
  `CMND` int(9) NOT NULL,
  `ChucVu` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Luong` float(255, 0) NOT NULL,
  PRIMARY KEY (`IDNhanVien`) USING BTREE
) ENGINE = InnoDB CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

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

SET FOREIGN_KEY_CHECKS = 1;
