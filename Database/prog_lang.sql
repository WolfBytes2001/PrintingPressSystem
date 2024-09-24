/*
 Navicat Premium Data Transfer

 Source Server         : db1
 Source Server Type    : MySQL
 Source Server Version : 100428 (10.4.28-MariaDB)
 Source Host           : localhost:3306
 Source Schema         : prog_lang

 Target Server Type    : MySQL
 Target Server Version : 100428 (10.4.28-MariaDB)
 File Encoding         : 65001

 Date: 01/04/2024 12:51:15
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for approved_request
-- ----------------------------
DROP TABLE IF EXISTS `approved_request`;
CREATE TABLE `approved_request`  (
  `seq_id` int NOT NULL AUTO_INCREMENT,
  `request_id` varchar(13) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `po_id` varchar(13) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `approved_by` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `status` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL DEFAULT 'Pending',
  `approved_at` datetime NOT NULL DEFAULT current_timestamp,
  PRIMARY KEY (`seq_id`) USING BTREE,
  UNIQUE INDEX `request_id`(`request_id` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 16 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of approved_request
-- ----------------------------
INSERT INTO `approved_request` VALUES (3, 'PR-27-03-7105', '', 'Pepe', 'Done', '2024-03-27 21:28:41');
INSERT INTO `approved_request` VALUES (4, 'PR-28-03-3768', '', 'Pepe', 'Done', '2024-03-28 10:51:49');
INSERT INTO `approved_request` VALUES (5, 'PR-28-03-4187', '', 'Pepe', 'Done', '2024-03-28 12:19:03');
INSERT INTO `approved_request` VALUES (6, 'PR-28-03-4399', '', 'Pepe', 'Done', '2024-03-28 12:36:01');
INSERT INTO `approved_request` VALUES (7, 'PR-28-03-8896', '', 'Pepe', 'Done', '2024-03-28 12:38:31');
INSERT INTO `approved_request` VALUES (8, 'PR-28-03-6614', '', 'Pepe', 'Done', '2024-03-28 12:41:37');
INSERT INTO `approved_request` VALUES (9, 'PR-28-03-2826', '', 'Pepe', 'Done', '2024-03-28 12:53:05');
INSERT INTO `approved_request` VALUES (10, 'PR-28-03-1644', 'PO-28-03-8778', 'Pepe', 'Done', '2024-03-28 12:56:25');
INSERT INTO `approved_request` VALUES (11, 'PR-28-03-7010', 'PO-28-03-3506', 'Pepe', 'Done', '2024-03-28 12:58:41');
INSERT INTO `approved_request` VALUES (12, 'PR-28-03-8830', 'PO-28-03-1002', 'Pepe', 'Done', '2024-03-28 13:03:01');
INSERT INTO `approved_request` VALUES (13, 'PR-28-03-1163', 'PO-28-03-9704', 'Pepe', 'Done', '2024-03-28 13:07:45');
INSERT INTO `approved_request` VALUES (14, 'PR-28-03-5275', 'PO-28-03-7029', 'Pepe', 'Done', '2024-03-28 13:41:15');
INSERT INTO `approved_request` VALUES (15, 'PR-28-03-6563', 'PO-28-03-3663', 'Pepe', 'Done', '2024-03-28 13:47:25');

-- ----------------------------
-- Table structure for employee
-- ----------------------------
DROP TABLE IF EXISTS `employee`;
CREATE TABLE `employee`  (
  `seq_id` int NOT NULL AUTO_INCREMENT,
  `employee_id` varchar(13) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `fullname` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `username` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `password` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `authority` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NULL DEFAULT NULL,
  `added_at` datetime NOT NULL DEFAULT current_timestamp,
  PRIMARY KEY (`seq_id`) USING BTREE,
  UNIQUE INDEX `employee_id`(`employee_id` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 6 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of employee
-- ----------------------------
INSERT INTO `employee` VALUES (4, '21-A-0076', 'Elon Musk', 'Tesla1', 'Tesla1', 'Admin', '2024-03-27 19:44:05');
INSERT INTO `employee` VALUES (5, NULL, 'Pepe', '1', '1', NULL, '2024-03-27 20:36:26');

-- ----------------------------
-- Table structure for item_recieve
-- ----------------------------
DROP TABLE IF EXISTS `item_recieve`;
CREATE TABLE `item_recieve`  (
  `seq_id` int NOT NULL AUTO_INCREMENT,
  `po_id` varchar(13) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `personnel` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `vehicle` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `recieved_by` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `item_condition` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `date_recieved` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  PRIMARY KEY (`seq_id`) USING BTREE,
  UNIQUE INDEX `po_id`(`po_id` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of item_recieve
-- ----------------------------
INSERT INTO `item_recieve` VALUES (1, 'PO-28-03-7029', 'Roderick', 'Van', 'John', 'Good', '29 March 2024');
INSERT INTO `item_recieve` VALUES (2, 'PO-28-03-3663', 'Rusty', 'Motorcycle', 'Anon', 'Good', '28 March 2024');

-- ----------------------------
-- Table structure for purchase_order
-- ----------------------------
DROP TABLE IF EXISTS `purchase_order`;
CREATE TABLE `purchase_order`  (
  `seq_id` int NOT NULL AUTO_INCREMENT,
  `po_id` varchar(13) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `pr_id` varchar(13) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `supplier_name` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `shipping_method` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `brand` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `courier` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `delivery_date` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `status` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL DEFAULT 'Processing',
  `issued_at` datetime NOT NULL DEFAULT current_timestamp,
  PRIMARY KEY (`seq_id`) USING BTREE,
  UNIQUE INDEX `po_id`(`po_id` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 19 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of purchase_order
-- ----------------------------
INSERT INTO `purchase_order` VALUES (1, 'PO-28-03-7623', 'PR-27-03-7105', '', '', '', '', '', 'Processing', '2024-03-28 12:03:04');
INSERT INTO `purchase_order` VALUES (2, 'PO-28-03-7068', 'PR-27-03-7105', '', '', '', '', '', 'Processing', '2024-03-28 12:03:39');
INSERT INTO `purchase_order` VALUES (3, 'PO-28-03-8939', 'PR-28-03-3768', '', '', '', '', '', 'Processing', '2024-03-28 12:05:37');
INSERT INTO `purchase_order` VALUES (4, 'PO-28-03-4291', 'PR-27-03-7105', '', '', '', '', '', 'Processing', '2024-03-28 12:06:02');
INSERT INTO `purchase_order` VALUES (5, 'PO-28-03-2149', 'PR-27-03-7105', '', '', '', '', '', 'Processing', '2024-03-28 12:13:23');
INSERT INTO `purchase_order` VALUES (6, 'PO-28-03-1343', 'PR-27-03-7105', '', '', '', '', '', 'Processing', '2024-03-28 12:14:29');
INSERT INTO `purchase_order` VALUES (7, 'PO-28-03-9852', 'PR-27-03-7105', '', '', '', '', '', 'Processing', '2024-03-28 12:14:35');
INSERT INTO `purchase_order` VALUES (8, 'PO-28-03-5512', 'PR-27-03-7105', '', '', '', '', '', 'Processing', '2024-03-28 12:15:29');
INSERT INTO `purchase_order` VALUES (9, 'PO-28-03-4584', 'PR-28-03-3768', '', '', '', '', '', 'Processing', '2024-03-28 12:16:09');
INSERT INTO `purchase_order` VALUES (10, 'PO-28-03-8376', 'PR-28-03-4187', '', '', '', '', '', 'Processing', '2024-03-28 12:19:15');
INSERT INTO `purchase_order` VALUES (11, 'PO-28-03-5573', 'PR-28-03-4399', '', '', '', '', '', 'Processing', '2024-03-28 12:36:13');
INSERT INTO `purchase_order` VALUES (12, 'PO-28-03-5837', 'PR-28-03-8896', '', '', '', '', '', 'Processing', '2024-03-28 12:38:37');
INSERT INTO `purchase_order` VALUES (13, 'PO-28-03-4840', 'PR-28-03-6614', '', '', '', '', '', 'Processing', '2024-03-28 12:41:43');
INSERT INTO `purchase_order` VALUES (14, '', '', '1', '1', '1', '1', '29 March 2024', 'Processing', '2024-03-28 12:45:57');
INSERT INTO `purchase_order` VALUES (15, 'PO-28-03-9704', 'PR-28-03-1163', '123', '23', '123', '123', '28 March 2024', 'Processing', '2024-03-28 13:08:11');
INSERT INTO `purchase_order` VALUES (16, 'PO-28-03-7029', 'PR-28-03-5275', 'Lee Plaza', 'COD', 'Canon Pixma', 'Supplier Door to Door', '30 March 2024', 'Delivered', '2024-03-28 13:42:18');
INSERT INTO `purchase_order` VALUES (18, 'PO-28-03-3663', 'PR-28-03-6563', '123', '23', '123', '123', '28 March 2024', 'Delivered', '2024-03-28 13:48:28');

-- ----------------------------
-- Table structure for request_form
-- ----------------------------
DROP TABLE IF EXISTS `request_form`;
CREATE TABLE `request_form`  (
  `seq_id` int NOT NULL AUTO_INCREMENT,
  `request_id` varchar(13) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `request_by` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `item_description` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `price` double NOT NULL,
  `measure` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `quantity` int NOT NULL,
  `product_type` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `source_of_fund` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `purpose` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `total_amount` double NOT NULL,
  `status` varchar(13) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL DEFAULT 'Pending',
  `requested_at` datetime NOT NULL DEFAULT current_timestamp,
  PRIMARY KEY (`seq_id`) USING BTREE,
  UNIQUE INDEX `request_id`(`request_id` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 16 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of request_form
-- ----------------------------
INSERT INTO `request_form` VALUES (3, 'PR-27-03-7105', 'Pepe', 'Tshirt', 150, 'Piece', 20, 'Consumable', 'Income', 'Costumer Order', 3000, 'Approved', '2024-03-27 21:14:41');
INSERT INTO `request_form` VALUES (4, 'PR-28-03-3768', 'Elon Musk', 'Printer', 14, 'Unit', 1, 'Equipment', 'Income', 'Tech need', 14000, 'Approved', '2024-03-28 10:51:34');
INSERT INTO `request_form` VALUES (5, 'PR-28-03-4187', 'Elon Musk', 'Laptop', 47, 'Unit', 1, 'Laptop', 'Income', 'Tech needs', 47000, 'Approved', '2024-03-28 12:18:45');
INSERT INTO `request_form` VALUES (6, 'PR-28-03-4399', 'Elon Musk', 'Ballpen', 100, 'box', 10, 'Supply', 'Income', 'Restock', 1000, 'Approved', '2024-03-28 12:35:51');
INSERT INTO `request_form` VALUES (7, 'PR-28-03-8896', 'Pepe', 'Pencil', 3, 'piece', 30, 'Supply', 'Income', 'Restock', 90, 'Approved', '2024-03-28 12:37:40');
INSERT INTO `request_form` VALUES (8, 'PR-28-03-6614', 'Pepe', '1', 1, '1', 1, '1', '1', '1', 1, 'Approved', '2024-03-28 12:41:28');
INSERT INTO `request_form` VALUES (9, 'PR-28-03-2826', 'Elon Musk', 'Eco Bag', 2, 'piece', 100, 'supply', 'Income', 'costumer order', 200, 'Approved', '2024-03-28 12:52:55');
INSERT INTO `request_form` VALUES (10, 'PR-28-03-1644', 'Elon Musk', '121', 23, '123', 3, '1312312', '123123', '13123', 69369369, 'Approved', '2024-03-28 12:56:14');
INSERT INTO `request_form` VALUES (11, 'PR-28-03-7010', 'Elon Musk', '167667', 66, '6767', 6767, '6767', '76767', '7676', 451812289, 'Approved', '2024-03-28 12:58:32');
INSERT INTO `request_form` VALUES (12, 'PR-28-03-8830', 'Elon Musk', '1', 9, '8889', 9, '9', '9', '199', 9, 'Approved', '2024-03-28 13:02:54');
INSERT INTO `request_form` VALUES (13, 'PR-28-03-1163', 'Elon Musk', '222', 222, '22', 22, '2', '2222', '22', 4884, 'Approved', '2024-03-28 13:07:36');
INSERT INTO `request_form` VALUES (14, 'PR-28-03-5275', 'Elon Musk', 'Printer', 7, 'unit', 1, 'equipment', 'income', 'order', 7999, 'Approved', '2024-03-28 13:41:05');
INSERT INTO `request_form` VALUES (15, 'PR-28-03-6563', 'Elon Musk', '123', 3, '123', 3, '23', '3', '23', 9, 'Approved', '2024-03-28 13:47:16');

-- ----------------------------
-- Table structure for vendors
-- ----------------------------
DROP TABLE IF EXISTS `vendors`;
CREATE TABLE `vendors`  (
  `seq_id` int NOT NULL AUTO_INCREMENT,
  `supplier_id` varchar(13) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `supplier_name` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `type` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `contact` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `location` varchar(30) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `added_at` datetime NOT NULL DEFAULT current_timestamp,
  PRIMARY KEY (`seq_id`) USING BTREE,
  UNIQUE INDEX `supplier_id`(`supplier_id` ASC) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 2 CHARACTER SET = utf8mb4 COLLATE = utf8mb4_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of vendors
-- ----------------------------
INSERT INTO `vendors` VALUES (1, '0001-a', 'Lee Plaza', 'Mall', '092131244', 'Dipolog City', '2024-03-28 11:10:09');

SET FOREIGN_KEY_CHECKS = 1;
