USE `colchoneria`;
-- ----0901-19-6128 Velvet Samayoa -------  
CREATE TABLE IF NOT EXISTS `Tbl_bancos` (
  `Pk_idbancos` INT NOT NULL,
  `nombre_banco` VARCHAR(25) NULL,
  `direccion_banco` VARCHAR(45) NULL,
  `contacto_banco` VARCHAR(45) NULL,
  `estado_banco` TINYINT DEFAULT 0,
  PRIMARY KEY (`Pk_idbancos`)
  )ENGINE=InnoDB DEFAULT CHARSET=utf8;
 -- ---- 0901-19-3510 Joshua Barrios --------
CREATE TABLE IF NOT EXISTS `Tbl_ConceptosBancario` (
  `Pk_idConcepto` INT NOT NULL,
  `Nombre_cbancario` VARCHAR(50) NOT NULL,
  `PorcentajeIva_cbancario` float null,
  `Clasificacion_cbancario` VARCHAR(5) NOT NULL,
  `Estado_cbancario` TINYINT DEFAULT 0,
  PRIMARY KEY (`Pk_idConcepto`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8;

CREATE TABLE IF NOT EXISTS `Tbl_Miembros` (
  `Pk_idMiembros` INT NOT NULL,
  `Nombre_Miembros` VARCHAR(50) NULL,
  `Direccion` VARCHAR(50) NULL,
  `DPI` VARCHAR(20) NULL,
  `estado_miembros` TINYINT DEFAULT 0,
  PRIMARY KEY (`Pk_idMiembros`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8;
-- ----0901-19-6128 Velvet Samayoa -------  
CREATE TABLE IF NOT EXISTS `Tbl_Reg_tipoCambio` (
   `Pk_regTipoCambio` INT NOT NULL,
  `fecha_RtCambio` DATE NOT NULL,
  `compra_RtCambio` FLOAT NULL,
  `venta_RtCambio` FLOAT NULL,
  `Moneda_RtCambio` VARCHAR(20) NULL,
  PRIMARY KEY (`Pk_regTipoCambio`)
    )ENGINE=InnoDB DEFAULT CHARSET=utf8;
    -- ----0901-19-6128 Velvet Samayoa -------  
CREATE TABLE IF NOT EXISTS `Tbl_tiposPagos` (
  `Pk_idTipoPagos` INT NOT NULL,
  `Concepto_Tipo` VARCHAR(25) NULL,
  PRIMARY KEY (`Pk_idTipoPagos`)
  )ENGINE=InnoDB DEFAULT CHARSET=utf8;
      -- ---- Velvet Samayoa -- Ester Lopez-------      
CREATE TABLE IF NOT EXISTS `Tbl_CuentasBancos` (
  `Pk_idCuentas` INT NOT NULL,
  `Nombre_cta` VARCHAR(45) NOT NULL,
  `fk_bancos` INT NOT NULL,
  `saldoI_montbancario` FLOAT NOT NULL,
  `TCargos_montbancario` FLOAT,
  `TAbonos_montbancario` FLOAT,
  `SActual_montbancario` FLOAT,
  `SConciliado_montbancario` FLOAT,
  `estado_cta` TINYINT DEFAULT 0,
  PRIMARY KEY (`Pk_idCuentas`),
  FOREIGN KEY (`fk_bancos`) REFERENCES `Tbl_bancos` (`Pk_idbancos`)
  )ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----0901-19-6128 Velvet Samayoa -------  
CREATE TABLE IF NOT EXISTS `Tbl_Reportes` (
  `Pk_idReportes` INT NOT NULL,
  `fechas_Reportes` DATE NULL,
  `concepto_Reportes` VARCHAR(45) NULL,
  `Nombre_Reportes` VARCHAR(45) NULL,
  `ubicacion_Reportes` VARCHAR(45) NULL,
  `Banco_Reportes` INT NULL,
  PRIMARY KEY (`Pk_idReportes`),
  FOREIGN KEY (`Banco_Reportes`) REFERENCES  `Tbl_CuentasBancos` (`Pk_idCuentas`)
    )ENGINE=InnoDB DEFAULT CHARSET=utf8;


    
-- ---- 0901-19-3510 Joshua Barrios --------

CREATE TABLE IF NOT EXISTS `tbl_ctabancarias` (
	pk_id_ctabancaria INT NOT NULL,
    num_ctabancaria INT NOT NULL,
    fecha_aper_ctabancaria DATE,
    fk_Moneda_ctabancarias INT NOT NULL,
    fk_Bancos_ctabancarias INT NOT NULL,
    Monto_ctabancarias FLOAT NOT NULL,
    fk_Miembros INT NOT NULL,
    estado_ctabancaria TINYINT DEFAULT 0,
    primary key (`pk_id_ctabancaria`),
	FOREIGN KEY (`fk_Bancos_ctabancarias`) REFERENCES `Tbl_bancos` (`Pk_idbancos`),
    FOREIGN KEY (`fk_Moneda_ctabancarias`) REFERENCES `Tbl_Reg_tipoCambio` (`Pk_regTipoCambio`),
    FOREIGN KEY (`fk_Miembros`) REFERENCES `Tbl_Miembros` (`Pk_idMiembros`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----0901-19-6128 Velvet Samayoa -------  
CREATE TABLE IF NOT EXISTS `Tbl_Ctrl_cheques` (
  `Pk_idControl_cheques` INT NOT NULL,
  `fk_id_cuentabancaria` INT NOT NULL,
  `fk_id_concepto` INT NOT NULL,
  `montoNum_cheques` FLOAT NOT NULL ,
  `fechaReg_cheques` DATE NULL,
  `fechaAplicacion_cheques` DATE NULL,
  `MontoLet_cheques` VARCHAR (100) NULL,
  `fk_Banco_cheques` INT NULL,
  PRIMARY KEY (`Pk_idControl_cheques`),
  FOREIGN KEY (`fk_id_cuentabancaria`) REFERENCES `tbl_ctabancarias` (`pk_id_ctabancaria`),
  FOREIGN KEY (`fk_Banco_cheques`) REFERENCES `Tbl_CuentasBancos` (`Pk_idCuentas`),
  FOREIGN KEY (`fk_id_concepto`) REFERENCES `Tbl_ConceptosBancario` (`Pk_idConcepto`)
    )ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----Joshua Barrios -------  
CREATE TABLE IF NOT EXISTS `Tbl_Ctrl_chequesnominas` (
  `Pk_idControl_chequesN` INT NOT NULL,
  `fk_trabajadornominas` INT NOT NULL,
  `fk_id_concepto` INT NOT NULL,
  `montoNum_chequesN` FLOAT NOT NULL ,
  `fechaReg_chequesN` DATE NULL,
  `fechaAplicacion_chequesN` DATE NULL,
  `MontoLet_chequesN` VARCHAR (100) NULL,
  `fk_Banco_chequesN` INT NULL,
  PRIMARY KEY (`Pk_idControl_chequesN`),
  FOREIGN KEY (`fk_trabajadornominas`) REFERENCES `tbl_trabajador` (`pk_id_trabajador`),
  FOREIGN KEY (`fk_Banco_chequesN`) REFERENCES `Tbl_CuentasBancos` (`Pk_idCuentas`),
  FOREIGN KEY (`fk_id_concepto`) REFERENCES `Tbl_ConceptosBancario` (`Pk_idConcepto`)
    )ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE IF NOT EXISTS `Tbl_Movimientos_bancos` (
  `Pk_idMovimientos` INT NOT NULL AUTO_INCREMENT,
  `fk_tipo_pago` INT NOT NULL,
  `fk_id_concepto` INT NOT NULL,--
  `fecha_mov` DATE NULL,
  `fk_Cuenta_banco` INT NOT NULL,
  `fk_cuentarelacionada` INT NOT NULL,
  `Monto_mov` FLOAT NULL,
PRIMARY KEY (`Pk_idMovimientos`),
FOREIGN KEY (`fk_tipo_pago`) REFERENCES `Tbl_tiposPagos` (`Pk_idTipoPagos`),
FOREIGN KEY (`fk_id_concepto`) REFERENCES `Tbl_ConceptosBancario` (`Pk_idConcepto`),
FOREIGN KEY (`fk_Cuenta_banco`) REFERENCES `Tbl_CuentasBancos` (`Pk_idCuentas`),
FOREIGN KEY (`fk_cuentarelacionada`) REFERENCES `tbl_ctabancarias` (`pk_id_ctabancaria`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8;


    
CREATE TABLE IF NOT EXISTS `Tbl_Conciliacion` ( -- pendiente--
  `Pk_idConciliacion` INT NOT NULL,
  `fecha_reg_cnl` DATE NULL,
  `descripcion_cnl` VARCHAR(45) NULL,
  `movimientos_cnl` INT NULL,
  PRIMARY KEY (`Pk_idConciliacion`),
    FOREIGN KEY (`movimientos_cnl`) REFERENCES `Tbl_Movimientos_bancos` (`Pk_idMovimientos`)
	)ENGINE=InnoDB DEFAULT CHARSET=utf8;
-- ----0901-19-6128 Velvet Samayoa -------  
CREATE TABLE IF NOT EXISTS `Tbl_Disponibilidad` (
  `Pk_idDispo` INT NOT NULL,
  `fecha_dispo` DATE NULL,
  `Saldo_Dispo` FLOAT NULL,
  `Comentario_Dispo` VARCHAR(45) NULL,
  `fk_cuenta_Dispo` INT NULL,
  PRIMARY KEY (`Pk_idDispo`),
FOREIGN KEY (`fk_cuenta_Dispo`) REFERENCES `Tbl_CuentasBancos` (`Pk_idCuentas`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8;

/*CREATE TABLE IF NOT EXISTS `Tbl_ConexionTrabajadores` (
  `fk_cuentasConexion` INT NOT NULL,
  `fk_dNominasConexion` INT NOT NULL,
FOREIGN KEY (`fk_cuentasConexion`) REFERENCES `tbl_ctabancarias` (`pk_id_ctabancaria`),
FOREIGN KEY (`fk_dNominasConexion`) REFERENCES `tbl_detalleNominas` (`pk_id_nomina`)
)ENGINE=InnoDB DEFAULT CHARSET=utf8;*/




