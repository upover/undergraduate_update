/*
Navicat MySQL Data Transfer

Source Server         : mySQLlocalhost
Source Server Version : 50610
Source Host           : localhost:3306
Source Database       : auto_calibration_system

Target Server Type    : MYSQL
Target Server Version : 50610
File Encoding         : 65001

Date: 2018-06-06 20:50:45
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for cali_data
-- ----------------------------
DROP TABLE IF EXISTS `cali_data`;
CREATE TABLE `cali_data` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `instrument_id` int(11) NOT NULL COMMENT '仪器ID',
  `save_time` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP COMMENT '保存数据的时间',
  `mode` varchar(10) DEFAULT NULL,
  `source` float DEFAULT NULL,
  `stand_out` float(255,0) DEFAULT NULL,
  `test_out` float DEFAULT NULL,
  `state` int(3) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=186 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of cali_data
-- ----------------------------
INSERT INTO `cali_data` VALUES ('1', '1', '2018-05-07 20:03:12', 'IACI', '40', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('2', '1', '2018-05-07 20:03:12', 'IACI', '80', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('3', '1', '2018-05-07 20:03:12', 'IACI', '120', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('4', '1', '2018-05-07 20:03:12', 'IACI', '160', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('5', '1', '2018-05-07 20:03:12', 'IACI', '200', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('6', '1', '2018-05-07 20:03:12', 'IACI', '8', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('7', '1', '2018-05-07 20:03:12', 'IACI', '16', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('8', '1', '2018-05-07 20:03:12', 'IACI', '24', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('9', '1', '2018-05-07 20:03:12', 'IACI', '32', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('10', '1', '2018-05-07 20:03:12', 'IACI', '40', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('11', '1', '2018-05-07 20:03:12', 'IACI', '1.81', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('12', '1', '2018-05-07 20:03:12', 'IACI', '3.62', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('13', '1', '2018-05-07 20:03:12', 'IACI', '5.4298', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('14', '1', '2018-05-07 20:03:12', 'IACI', '7.2398', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('15', '1', '2018-05-07 20:03:12', 'IACI', '9.0498', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('16', '1', '2018-05-07 20:03:12', 'IACI', '0.4', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('17', '1', '2018-05-07 20:03:12', 'IACI', '0.8', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('18', '1', '2018-05-07 20:03:12', 'IACI', '1.2', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('19', '1', '2018-05-07 20:03:12', 'IACI', '1.6', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('20', '1', '2018-05-07 20:03:12', 'IACI', '2', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('21', '1', '2018-05-07 20:03:12', 'IACI', '0.08', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('22', '1', '2018-05-07 20:03:12', 'IACI', '0.16', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('23', '1', '2018-05-07 20:03:12', 'IACI', '0.24', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('24', '1', '2018-05-07 20:03:12', 'IACI', '0.32', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('25', '1', '2018-05-07 20:03:12', 'IACI', '0.4', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('26', '1', '2018-05-07 20:03:12', 'IACI', '0.0266', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('27', '1', '2018-05-07 20:03:12', 'IACI', '0.05332', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('28', '1', '2018-05-07 20:03:12', 'IACI', '0.08', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('29', '1', '2018-05-07 20:03:12', 'IACI', '0.10666', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('30', '1', '2018-05-07 20:03:12', 'IACI', '0.13332', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('31', '1', '2018-05-07 20:03:12', 'IACF', '50', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('32', '1', '2018-05-07 20:03:12', 'IACF', '150', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('33', '1', '2018-05-07 20:03:12', 'IACF', '250', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('34', '1', '2018-05-07 20:03:12', 'IACF', '350', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('35', '1', '2018-05-07 20:03:12', 'IACF', '450', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('36', '1', '2018-05-07 20:03:12', 'IACF', '550', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('37', '1', '2018-05-07 20:03:12', 'IACF', '650', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('38', '1', '2018-05-07 20:03:12', 'IACF', '750', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('39', '1', '2018-05-07 20:03:12', 'IACF', '850', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('40', '1', '2018-05-07 20:03:12', 'IACF', '950', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('41', '1', '2018-05-07 20:03:12', 'IDC', '40', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('42', '1', '2018-05-07 20:03:12', 'IDC', '80', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('43', '1', '2018-05-07 20:03:12', 'IDC', '120', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('44', '1', '2018-05-07 20:03:12', 'IDC', '160', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('45', '1', '2018-05-07 20:03:12', 'IDC', '200', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('46', '1', '2018-05-07 20:03:12', 'IDC', '8', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('47', '1', '2018-05-07 20:03:12', 'IDC', '16', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('48', '1', '2018-05-07 20:03:12', 'IDC', '24', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('49', '1', '2018-05-07 20:03:12', 'IDC', '32', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('50', '1', '2018-05-07 20:03:12', 'IDC', '40', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('51', '1', '2018-05-07 20:03:12', 'IDC', '1.81', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('52', '1', '2018-05-07 20:03:12', 'IDC', '3.62', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('53', '1', '2018-05-07 20:03:12', 'IDC', '5.4298', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('54', '1', '2018-05-07 20:03:12', 'IDC', '7.2398', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('55', '1', '2018-05-07 20:03:12', 'IDC', '9.0498', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('56', '1', '2018-05-07 20:03:12', 'IDC', '0.4', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('57', '1', '2018-05-07 20:03:12', 'IDC', '0.8', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('58', '1', '2018-05-07 20:03:12', 'IDC', '1.2', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('59', '1', '2018-05-07 20:03:12', 'IDC', '1.6', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('60', '1', '2018-05-07 20:03:12', 'IDC', '2', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('61', '1', '2018-05-07 20:03:12', 'IDC', '0.08', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('62', '1', '2018-05-07 20:03:12', 'IDC', '0.16', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('63', '1', '2018-05-07 20:03:12', 'IDC', '0.24', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('64', '1', '2018-05-07 20:03:12', 'IDC', '0.32', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('65', '1', '2018-05-07 20:03:12', 'IDC', '0.4', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('66', '1', '2018-05-07 20:03:12', 'IDC', '0.0266', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('67', '1', '2018-05-07 20:03:12', 'IDC', '0.05332', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('68', '1', '2018-05-07 20:03:12', 'IDC', '0.08', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('69', '1', '2018-05-07 20:03:12', 'IDC', '0.10666', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('70', '1', '2018-05-07 20:03:12', 'IDC', '0.13332', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('71', '1', '2018-05-07 20:03:12', 'IDC', '-40', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('72', '1', '2018-05-07 20:03:12', 'IDC', '-80', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('73', '1', '2018-05-07 20:03:12', 'IDC', '-120', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('74', '1', '2018-05-07 20:03:12', 'IDC', '-160', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('75', '1', '2018-05-07 20:03:12', 'IDC', '-200', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('76', '1', '2018-05-07 20:03:12', 'IDC', '-8', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('77', '1', '2018-05-07 20:03:12', 'IDC', '-16', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('78', '1', '2018-05-07 20:03:12', 'IDC', '-24', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('79', '1', '2018-05-07 20:03:12', 'IDC', '-32', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('80', '1', '2018-05-07 20:03:12', 'IDC', '-40', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('81', '1', '2018-05-07 20:03:12', 'IDC', '-1.81', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('82', '1', '2018-05-07 20:03:12', 'IDC', '-3.62', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('83', '1', '2018-05-07 20:03:12', 'IDC', '-5.4298', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('84', '1', '2018-05-07 20:03:12', 'IDC', '-7.2398', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('85', '1', '2018-05-07 20:03:12', 'IDC', '-9.0498', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('86', '1', '2018-05-07 20:03:12', 'IDC', '-0.4', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('87', '1', '2018-05-07 20:03:12', 'IDC', '-0.8', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('88', '1', '2018-05-07 20:03:12', 'IDC', '-1.2', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('89', '1', '2018-05-07 20:03:12', 'IDC', '-1.6', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('90', '1', '2018-05-07 20:03:12', 'IDC', '-2', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('91', '1', '2018-05-07 20:03:12', 'IDC', '-0.08', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('92', '1', '2018-05-07 20:03:12', 'IDC', '-0.16', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('93', '1', '2018-05-07 20:03:12', 'IDC', '-0.24', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('94', '1', '2018-05-07 20:03:12', 'IDC', '-0.32', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('95', '1', '2018-05-07 20:03:12', 'IDC', '-0.4', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('96', '1', '2018-05-07 20:03:12', 'IDC', '-0.0266', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('97', '1', '2018-05-07 20:03:12', 'IDC', '-0.05332', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('98', '1', '2018-05-07 20:03:12', 'IDC', '-0.08', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('99', '1', '2018-05-07 20:03:12', 'IDC', '-0.10666', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('100', '1', '2018-05-07 20:03:12', 'IDC', '-0.13332', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('101', '1', '2018-05-07 20:03:12', 'VACF', '50', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('102', '1', '2018-05-07 20:03:12', 'VACF', '150', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('103', '1', '2018-05-07 20:03:12', 'VACF', '250', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('104', '1', '2018-05-07 20:03:12', 'VACF', '350', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('105', '1', '2018-05-07 20:03:12', 'VACF', '450', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('106', '1', '2018-05-07 20:03:12', 'VACF', '550', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('107', '1', '2018-05-07 20:03:12', 'VACF', '650', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('108', '1', '2018-05-07 20:03:12', 'VACF', '750', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('109', '1', '2018-05-07 20:03:12', 'VACF', '850', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('110', '1', '2018-05-07 20:03:12', 'VACF', '950', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('111', '1', '2018-05-07 20:03:12', 'VACV', '0.05', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('112', '1', '2018-05-07 20:03:12', 'VACV', '0.1', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('113', '1', '2018-05-07 20:03:12', 'VACV', '0.3', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('114', '1', '2018-05-07 20:03:12', 'VACV', '0.5', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('115', '1', '2018-05-07 20:03:12', 'VACV', '0.6', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('116', '1', '2018-05-07 20:03:12', 'VACV', '1', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('117', '1', '2018-05-07 20:03:12', 'VACV', '2', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('118', '1', '2018-05-07 20:03:12', 'VACV', '3', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('119', '1', '2018-05-07 20:03:12', 'VACV', '4', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('120', '1', '2018-05-07 20:03:12', 'VACV', '5', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('121', '1', '2018-05-07 20:03:12', 'VACV', '6', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('122', '1', '2018-05-07 20:03:12', 'VACV', '7', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('123', '1', '2018-05-07 20:03:12', 'VACV', '8', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('124', '1', '2018-05-07 20:03:12', 'VACV', '9', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('125', '1', '2018-05-07 20:03:12', 'VACV', '10', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('126', '1', '2018-05-07 20:03:12', 'VACV', '11', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('127', '1', '2018-05-07 20:03:12', 'VACV', '12', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('128', '1', '2018-05-07 20:03:12', 'VACV', '13', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('129', '1', '2018-05-07 20:03:12', 'VACV', '14', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('130', '1', '2018-05-07 20:03:12', 'VACV', '15', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('131', '1', '2018-05-07 20:03:12', 'VACV', '16', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('132', '1', '2018-05-07 20:03:12', 'VACV', '17', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('133', '1', '2018-05-07 20:03:12', 'VACV', '18', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('134', '1', '2018-05-07 20:03:12', 'VACV', '19', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('135', '1', '2018-05-07 20:03:12', 'VACV', '20', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('136', '1', '2018-05-07 20:03:12', 'VDC', '0.05', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('137', '1', '2018-05-07 20:03:12', 'VDC', '0.1', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('138', '1', '2018-05-07 20:03:12', 'VDC', '0.3', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('139', '1', '2018-05-07 20:03:12', 'VDC', '0.5', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('140', '1', '2018-05-07 20:03:12', 'VDC', '0.6', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('141', '1', '2018-05-07 20:03:12', 'VDC', '1', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('142', '1', '2018-05-07 20:03:12', 'VDC', '2', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('143', '1', '2018-05-07 20:03:12', 'VDC', '3', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('144', '1', '2018-05-07 20:03:12', 'VDC', '4', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('145', '1', '2018-05-07 20:03:12', 'VDC', '5', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('146', '1', '2018-05-07 20:03:12', 'VDC', '6', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('147', '1', '2018-05-07 20:03:12', 'VDC', '7', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('148', '1', '2018-05-07 20:03:12', 'VDC', '8', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('149', '1', '2018-05-07 20:03:12', 'VDC', '9', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('150', '1', '2018-05-07 20:03:12', 'VDC', '10', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('151', '1', '2018-05-07 20:03:12', 'VDC', '11', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('152', '1', '2018-05-07 20:03:12', 'VDC', '12', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('153', '1', '2018-05-07 20:03:12', 'VDC', '13', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('154', '1', '2018-05-07 20:03:12', 'VDC', '14', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('155', '1', '2018-05-07 20:03:12', 'VDC', '15', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('156', '1', '2018-05-07 20:03:12', 'VDC', '16', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('157', '1', '2018-05-07 20:03:12', 'VDC', '17', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('158', '1', '2018-05-07 20:03:12', 'VDC', '18', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('159', '1', '2018-05-07 20:03:12', 'VDC', '19', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('160', '1', '2018-05-07 20:03:12', 'VDC', '20', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('161', '1', '2018-05-07 20:03:12', 'VDC', '-0.05', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('162', '1', '2018-05-07 20:03:12', 'VDC', '-0.1', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('163', '1', '2018-05-07 20:03:12', 'VDC', '-0.3', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('164', '1', '2018-05-07 20:03:12', 'VDC', '-0.5', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('165', '1', '2018-05-07 20:03:12', 'VDC', '-0.6', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('166', '1', '2018-05-07 20:03:12', 'VDC', '-1', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('167', '1', '2018-05-07 20:03:12', 'VDC', '-2', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('168', '1', '2018-05-07 20:03:12', 'VDC', '-3', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('169', '1', '2018-05-07 20:03:12', 'VDC', '-4', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('170', '1', '2018-05-07 20:03:12', 'VDC', '-5', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('171', '1', '2018-05-07 20:03:12', 'VDC', '-6', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('172', '1', '2018-05-07 20:03:12', 'VDC', '-7', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('173', '1', '2018-05-07 20:03:12', 'VDC', '-8', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('174', '1', '2018-05-07 20:03:12', 'VDC', '-9', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('175', '1', '2018-05-07 20:03:12', 'VDC', '-10', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('176', '1', '2018-05-07 20:03:12', 'VDC', '-11', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('177', '1', '2018-05-07 20:03:12', 'VDC', '-12', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('178', '1', '2018-05-07 20:03:12', 'VDC', '-13', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('179', '1', '2018-05-07 20:03:12', 'VDC', '-14', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('180', '1', '2018-05-07 20:03:12', 'VDC', '-15', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('181', '1', '2018-05-07 20:03:12', 'VDC', '-16', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('182', '1', '2018-05-07 20:03:12', 'VDC', '-17', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('183', '1', '2018-05-07 20:03:12', 'VDC', '-18', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('184', '1', '2018-05-07 20:03:12', 'VDC', '-19', '0', '0', '1');
INSERT INTO `cali_data` VALUES ('185', '1', '2018-05-07 20:03:12', 'VDC', '-20', '0', '0', '1');

-- ----------------------------
-- Table structure for divider_data
-- ----------------------------
DROP TABLE IF EXISTS `divider_data`;
CREATE TABLE `divider_data` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `source_volt` float DEFAULT NULL COMMENT '输入源电压',
  `source_freq` float DEFAULT NULL COMMENT '输入源频率',
  `stand_divider_volt` float DEFAULT NULL COMMENT '标准分压器电压',
  `test_divider_volt` float DEFAULT NULL COMMENT '标准分压器频率',
  `temperature` float DEFAULT NULL COMMENT '环境温度',
  `humidity` float DEFAULT NULL COMMENT '环境湿度',
  `divider_id` int(11) DEFAULT NULL COMMENT '待测分压器编号',
  `save_time` timestamp NULL DEFAULT CURRENT_TIMESTAMP COMMENT '保存时间',
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of divider_data
-- ----------------------------
INSERT INTO `divider_data` VALUES ('1', '1', '1', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('2', '2', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('3', '3', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('4', '4', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('5', '5', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('6', '6', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('7', '7', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('8', '8', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('9', '9', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('10', '10', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('11', '-1', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('12', '-2', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('13', '-3', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('14', '-4', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('15', '-5', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('16', '-6', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('17', '-7', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('18', '-8', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('19', '-9', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('20', '-10', '0', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('21', '1', '50', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('22', '2', '50', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('23', '3', '50', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('24', '4', '50', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('25', '5', '50', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('26', '6', '50', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('27', '7', '50', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('28', '8', '50', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('29', '9', '50', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('30', '10', '50', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('31', '0.1', '50', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('32', '0.1', '150', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('33', '0.1', '250', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('34', '0.1', '350', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('35', '0.1', '450', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('36', '0.1', '550', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('37', '0.1', '650', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('38', '0.1', '750', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('39', '0.1', '850', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('40', '0.1', '950', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('41', '0.5', '50', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('42', '0.5', '150', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('43', '0.5', '250', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('44', '0.5', '350', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('45', '0.5', '450', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('46', '0.5', '550', '0', '0', '0', '0', '1', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('47', '0.5', '650', '0', '0', '0', '0', '2', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('48', '0.5', '750', '0', '0', '0', '0', '2', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('49', '0.5', '850', null, null, '0', '0', '2', '2018-05-07 20:31:33');
INSERT INTO `divider_data` VALUES ('50', '0.5', '950', null, '0', '0', '0', '2', '2018-05-07 20:31:33');

-- ----------------------------
-- Table structure for divider_now_ac
-- ----------------------------
DROP TABLE IF EXISTS `divider_now_ac`;
CREATE TABLE `divider_now_ac` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `mode` varchar(10) DEFAULT NULL,
  `source` float DEFAULT NULL,
  `frequency` float DEFAULT NULL,
  `input` float DEFAULT NULL,
  `output` float(15,0) DEFAULT NULL,
  `temperature` float(15,0) DEFAULT NULL,
  `humidity` float DEFAULT NULL,
  `state` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of divider_now_ac
-- ----------------------------
INSERT INTO `divider_now_ac` VALUES ('1', 'AC', '0.07', '50', null, null, null, null, null);
INSERT INTO `divider_now_ac` VALUES ('2', 'AC', '0.14', '50', null, null, null, null, null);
INSERT INTO `divider_now_ac` VALUES ('3', 'AC', '0.21', '50', null, null, null, null, null);
INSERT INTO `divider_now_ac` VALUES ('4', 'AC', '0.28', '50', null, null, null, null, null);
INSERT INTO `divider_now_ac` VALUES ('5', 'AC', '0.35', '50', null, null, null, null, null);
INSERT INTO `divider_now_ac` VALUES ('6', 'AC', '0.42', '50', null, null, null, null, null);
INSERT INTO `divider_now_ac` VALUES ('7', 'AC', '0.49', '50', null, null, null, null, null);
INSERT INTO `divider_now_ac` VALUES ('8', 'AC', '0.56', '50', null, null, null, null, null);
INSERT INTO `divider_now_ac` VALUES ('9', 'AC', '0.63', '50', null, null, null, null, null);
INSERT INTO `divider_now_ac` VALUES ('10', 'AC', '0.7', '50', null, null, null, null, null);

-- ----------------------------
-- Table structure for divider_now_dcn
-- ----------------------------
DROP TABLE IF EXISTS `divider_now_dcn`;
CREATE TABLE `divider_now_dcn` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `mode` varchar(10) DEFAULT NULL,
  `source` float DEFAULT NULL,
  `frequency` float unsigned zerofill DEFAULT NULL,
  `input` float DEFAULT NULL,
  `output` float(15,0) DEFAULT NULL,
  `temperature` float(15,0) DEFAULT NULL,
  `humidity` float DEFAULT NULL,
  `state` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of divider_now_dcn
-- ----------------------------
INSERT INTO `divider_now_dcn` VALUES ('1', 'DCN', '1', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcn` VALUES ('2', 'DCN', '2', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcn` VALUES ('3', 'DCN', '3', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcn` VALUES ('4', 'DCN', '4', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcn` VALUES ('5', 'DCN', '5', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcn` VALUES ('6', 'DCN', '6', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcn` VALUES ('7', 'DCN', '7', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcn` VALUES ('8', 'DCN', '8', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcn` VALUES ('9', 'DCN', '9', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcn` VALUES ('10', 'DCN', '10', '000000000000', null, null, null, null, null);

-- ----------------------------
-- Table structure for divider_now_dcp
-- ----------------------------
DROP TABLE IF EXISTS `divider_now_dcp`;
CREATE TABLE `divider_now_dcp` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `mode` varchar(10) DEFAULT NULL,
  `source` float DEFAULT NULL,
  `frequency` float unsigned zerofill DEFAULT NULL,
  `input` float DEFAULT NULL,
  `output` float(15,0) DEFAULT NULL,
  `temperature` float(15,0) DEFAULT NULL,
  `humidity` float DEFAULT NULL,
  `state` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of divider_now_dcp
-- ----------------------------
INSERT INTO `divider_now_dcp` VALUES ('1', 'DCP', '1', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcp` VALUES ('2', 'DCP', '2', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcp` VALUES ('3', 'DCP', '3', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcp` VALUES ('4', 'DCP', '4', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcp` VALUES ('5', 'DCP', '5', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcp` VALUES ('6', 'DCP', '6', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcp` VALUES ('7', 'DCP', '7', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcp` VALUES ('8', 'DCP', '8', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcp` VALUES ('9', 'DCP', '9', '000000000000', null, null, null, null, null);
INSERT INTO `divider_now_dcp` VALUES ('10', 'DCP', '10', '000000000000', null, null, null, null, null);

-- ----------------------------
-- Table structure for divider_now_f
-- ----------------------------
DROP TABLE IF EXISTS `divider_now_f`;
CREATE TABLE `divider_now_f` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `mode` varchar(10) DEFAULT NULL,
  `source` float DEFAULT NULL,
  `frequency` float DEFAULT NULL,
  `input` float DEFAULT NULL,
  `output` float(15,0) DEFAULT NULL,
  `temperature` float(15,0) DEFAULT NULL,
  `humidity` float DEFAULT NULL,
  `state` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of divider_now_f
-- ----------------------------
INSERT INTO `divider_now_f` VALUES ('1', 'F', '0.1', '50', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('2', 'F', '0.1', '150', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('3', 'F', '0.1', '250', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('4', 'F', '0.1', '350', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('5', 'F', '0.1', '450', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('6', 'F', '0.1', '550', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('7', 'F', '0.1', '650', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('8', 'F', '0.1', '750', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('9', 'F', '0.1', '850', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('10', 'F', '0.1', '950', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('11', 'F', '0.5', '50', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('12', 'F', '0.5', '150', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('13', 'F', '0.5', '250', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('14', 'F', '0.5', '350', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('15', 'F', '0.5', '450', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('16', 'F', '0.5', '550', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('17', 'F', '0.5', '650', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('18', 'F', '0.5', '750', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('19', 'F', '0.5', '850', null, null, null, null, null);
INSERT INTO `divider_now_f` VALUES ('20', 'F', '0.5', '950', null, null, null, null, null);

-- ----------------------------
-- Table structure for divider_process
-- ----------------------------
DROP TABLE IF EXISTS `divider_process`;
CREATE TABLE `divider_process` (
  `num` int(11) unsigned zerofill NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of divider_process
-- ----------------------------
INSERT INTO `divider_process` VALUES ('00000000000');

-- ----------------------------
-- Table structure for testforbulk
-- ----------------------------
DROP TABLE IF EXISTS `testforbulk`;
CREATE TABLE `testforbulk` (
  `id` int(11) NOT NULL,
  `source` float DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of testforbulk
-- ----------------------------
INSERT INTO `testforbulk` VALUES ('0', '40');
INSERT INTO `testforbulk` VALUES ('1', '80');
INSERT INTO `testforbulk` VALUES ('2', '120');
INSERT INTO `testforbulk` VALUES ('3', '160');
INSERT INTO `testforbulk` VALUES ('4', '200');
INSERT INTO `testforbulk` VALUES ('5', '8');
INSERT INTO `testforbulk` VALUES ('6', '16');
INSERT INTO `testforbulk` VALUES ('7', '24');
INSERT INTO `testforbulk` VALUES ('8', '32');
INSERT INTO `testforbulk` VALUES ('9', '40');
INSERT INTO `testforbulk` VALUES ('10', '1.81');
INSERT INTO `testforbulk` VALUES ('11', '3.62');
INSERT INTO `testforbulk` VALUES ('12', '5.4298');
INSERT INTO `testforbulk` VALUES ('13', '7.2398');
INSERT INTO `testforbulk` VALUES ('14', '9.0498');
INSERT INTO `testforbulk` VALUES ('15', '0.4');
INSERT INTO `testforbulk` VALUES ('16', '0.8');
INSERT INTO `testforbulk` VALUES ('17', '1.2');
INSERT INTO `testforbulk` VALUES ('18', '1.6');
INSERT INTO `testforbulk` VALUES ('19', '2');
INSERT INTO `testforbulk` VALUES ('20', '0.08');
INSERT INTO `testforbulk` VALUES ('21', '0.16');
INSERT INTO `testforbulk` VALUES ('22', '0.24');
INSERT INTO `testforbulk` VALUES ('23', '0.32');
INSERT INTO `testforbulk` VALUES ('24', '0.4');
INSERT INTO `testforbulk` VALUES ('25', '0.0266');
INSERT INTO `testforbulk` VALUES ('26', '0.05332');
INSERT INTO `testforbulk` VALUES ('27', '0.08');
INSERT INTO `testforbulk` VALUES ('28', '0.10666');
INSERT INTO `testforbulk` VALUES ('29', '0.13332');

-- ----------------------------
-- Table structure for user_info
-- ----------------------------
DROP TABLE IF EXISTS `user_info`;
CREATE TABLE `user_info` (
  `user_id` int(11) NOT NULL,
  `user_type` enum('admin','user') DEFAULT NULL COMMENT '用户类型，分为管理员和普通用户',
  `password` varchar(255) DEFAULT NULL,
  `user_number` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of user_info
-- ----------------------------
INSERT INTO `user_info` VALUES ('1', 'admin', '1234', '0001');
INSERT INTO `user_info` VALUES ('2', 'user', '1234', '0002');
SET FOREIGN_KEY_CHECKS=1;
