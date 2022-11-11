ALTER TABLE `colchoneria`.`tbl_cuentasbancos` DROP COLUMN `saldoI_montbancario`;

ALTER TABLE `colchoneria`.`tbl_movimientos_bancos` 
CHANGE COLUMN `Pk_idMovimientos` `Pk_idMovimientos` INT NOT NULL AUTO_INCREMENT ;