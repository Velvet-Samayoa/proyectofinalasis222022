use colchoneria;
/*Tabla Activos - Jonathan Xuyá 0901-18-11371*/
DROP TABLE IF EXISTS `tbl_ActivosFijos`;  
CREATE TABLE IF NOT EXISTS `tbl_ActivosFijos` (
	pk_ActivosFijos INT AUTO_INCREMENT NOT NULL,
    Edificaiones varchar(45) NOT NULL,
    Muebles varchar(45) NOT NULL,
    Equipos varchar(45) NOT NULL,
    Maquinaria varchar(45) NOT NULL,
    Herramientas varchar(45) NOT NULL,
    EquipoComputo varchar(45) NOT NULL,
    primary key (pk_ActivosFijos)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

/*TABLAS CUENTAS - DIANA VICTORES 9959-19-1471*/
create table tbl_encabezadoclasecuenta(
pkid_encabezadocuenta int not null, 
nombre_tipocuenta varchar(50) not null,
estatus_clasecuenta TINYINT NOT NULL, 
primary key (pkid_encabezadocuenta) 
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4;

/* DIANA VICTORES 9959-19-1471*/
create table tbl_tipocuenta(
pkid_tipocuenta int not null, 
nombre_tipocuenta varchar(50) not null,
serie_tipocuenta varchar(50) not null,
estatus_tipocuenta TINYINT NOT NULL, 
primary key (pkid_tipocuenta ) 
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4;

/*DIANA VICTORES 9959-19-1471*/
create table tbl_cuentas(
pkid_cuenta int not null, 
pkid_tipocuenta int not null, 
pkid_encabezadocuenta int not null,
nombre_cuenta varchar(50) not null,
cargo_cuenta float default 0,
abono_cuenta float default 0,
saldo_cuenta float default 0,
status_cuenta TINYINT NOT NULL, 
pkid_cuentaa int not null, 
primary key (
pkid_cuenta,  
pkid_tipocuenta,
pkid_cuentaa,
pkid_encabezadocuenta) ,

FOREIGN KEY (`pkid_tipocuenta`) REFERENCES `tbl_tipocuenta` (`pkid_tipocuenta`),
FOREIGN KEY (`pkid_cuentaa`) REFERENCES `tbl_cuentas` (`pkid_cuenta`),
FOREIGN KEY (`pkid_encabezadocuenta`) REFERENCES `tbl_encabezadoclasecuenta` (`pkid_encabezadocuenta`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4;

/*TABLAS POLIZA - DIANA VICTORES */
create table tbl_tipoPoliza(
	Pk_TipoPoliza int not null, 
	descripcion varchar(65),
	status_tipoPoliza TINYINT NOT NULL, 
	primary key (Pk_TipoPoliza)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

/* DIANA VICTORES 9959-19-1471*/
create table tbl_polizaEncabezado(
	Pk_PolizaEncabezado int not null, 
	fechaPoliza date,
	Pk_TipoPoliza int not null, 
	primary key(Pk_PolizaEncabezado,
    Pk_TipoPoliza),
    foreign key (Pk_TipoPoliza) references tbl_tipoPoliza (Pk_TipoPoliza)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

/* DIANA VICTORES 9959-19-1471*/
create table tbl_tipoOperacion(
	Pk_TipoOperacion int not null,
	nombre varchar(65), 
	status_tipoOperacion TINYINT NOT NULL, 
	primary key (Pk_TipoOperacion)
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

/*DIANA VICTORES 9959-19-1471*/
create table tbl_polizaDetalle(
	Pk_PolizaEncabezado int not null,
    Pk_TipoPoliza int not null,
    pkid_cuenta int not null ,
    fechaPoliza date,
	saldo float,
	concepto varchar(65),	
	primary key(Pk_PolizaEncabezado, 
    Pk_TipoPoliza, 
    pkid_cuenta),    
    foreign key (Pk_PolizaEncabezado) references tbl_polizaEncabezado (Pk_PolizaEncabezado),
	foreign key (pkid_cuenta) references tbl_cuentas (pkid_cuenta)
	
) ENGINE = InnoDB DEFAULT CHARSET=latin1;

-- -----------------------Joselyn Rivera------------------------------

CREATE TABLE `Tbl_Moneda` (
  `PKidMoneda` INT NOT NULL,
  `nombre_moneda` VARCHAR(45) NOT NULL,
  `tasa_moneda` DOUBLE NOT NULL,
  `estado` TINYINT(1)  NOT NULL,
  PRIMARY KEY (`PKidMoneda`))
ENGINE = InnoDB;

DROP TABLE IF EXISTS `tbl_areas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tbl_areas` (
  `KidArea` int(11) NOT NULL,
  `nombreArea` varchar(45) DEFAULT NULL,
  `estado` tinyint(2) NOT NULL,
  PRIMARY KEY (`KidArea`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tbl_areas`
--

LOCK TABLES `tbl_areas` WRITE;
/*!40000 ALTER TABLE `tbl_areas` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbl_areas` ENABLE KEYS */;
UNLOCK TABLES;

-- -----------------------Cambio Moneda------------------------------
CREATE TABLE `tbl_divisa` (
  `KidDivisa` varchar(11) NOT NULL,
  `Nombre` varchar(45) DEFAULT NULL,
  `estado` TINYINT
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `tbl_divisa`
  ADD PRIMARY KEY (`KidDivisa`);
  
  -- -----------------------Cambio Moneda------------------------------
  CREATE TABLE `tbl_tipocambio` (
  `KidMonedaBase` varchar(11) NOT NULL,
  `KidMonedaConversion` varchar(11) NOT NULL,
  `tipo_cambio` float DEFAULT NULL,
  `fecha_tipo_cambio` date DEFAULT NULL	
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

ALTER TABLE `tbl_tipocambio`
  ADD PRIMARY KEY (`KidMonedaBase`,`KidMonedaConversion`),
  ADD KEY `fk_tbl_tipoCambio_tbl_Divisa_idx` (`KidMonedaConversion`);
  
ALTER TABLE `tbl_tipocambio`
  ADD CONSTRAINT `fk_tbl_tipoCambio_tbl_Divisa` FOREIGN KEY (`KidMonedaConversion`) REFERENCES `tbl_divisa` (`KidDivisa`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  ADD CONSTRAINT `fk_tbl_tipoCambio_tbl_Divisa1` FOREIGN KEY (`KidMonedaBase`) REFERENCES `tbl_divisa` (`KidDivisa`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

  -- -----------------------Partida Presupuesto------------------------------
  -- -----------------------Gestion Presupuesto------------------------------
CREATE TABLE `tbl_presupuesto` (
  `Kidpresupuesto` INT NOT NULL ,
  `KidMoneda` INT,
  `KidArea` INT NOT NULL,
  `KidCuenta` VARCHAR(10) NOT NULL,
  `nombre` VARCHAR(45),
  `fecha` DATE NULL,
  `descripcion` VARCHAR(300) NULL,
  `monto` DOUBLE,
  `anotacion` VARCHAR(45),
  `status` TINYINT NULL,
  PRIMARY KEY (`Kidpresupuesto`),
  CONSTRAINT `FK_Moneda_Presupuesto`
    FOREIGN KEY (`KidMoneda`)
    REFERENCES `tbl_moneda` (`KidMoneda`),
     CONSTRAINT `FK_area_presupuesto`
    FOREIGN KEY (`KidArea`)
    REFERENCES `tbl_areas` (`KidArea`),
   CONSTRAINT `FK_cuentas_presupuesto`
    FOREIGN KEY (`KidCuenta`)
    REFERENCES `tbl_cuentas` (`KidCuenta`)
  )ENGINE = InnoDB;

CREATE TABLE  `tbl_tipo_poliza`(
	`KidTipoDePoliza` VARCHAR(5) NOT NULL,
    `descripcion` VARCHAR(200),
    `estado` TINYINT,
    PRIMARY KEY(`KidTipoDePoliza`)
)ENGINE = InnoDB;

 -- -----------------------Partida Presupuesto------------------------------
CREATE TABLE `tbl_poliza_encabezado` (
  `KidPoliza` INT NOT NULL AUTO_INCREMENT,
  `KidTipoDePoliza` INT NOT NULL,
  `fecha` DATE NULL,
  `total_debe` FLOAT NULL,
  `total_haber` FLOAT NULL,
  `estado` TINYINT NULL,
  PRIMARY KEY (`KidLibroDiario`, `KidPoliza`),
  CONSTRAINT `fk_polizaEncabezado_libroDiario`
    FOREIGN KEY (`KidPoliza`)
    REFERENCES `tbl_poliza_encabezado` (`KidPoliza`)
    )ENGINE = InnoDB; 

 -- -----------------------Partida Presupuesto------------------------------
CREATE TABLE `tbl_poliza_encabezado`(
	`KidPoliza` INT NOT NULL AUTO_INCREMENT,
    `KidTipoDePoliza` VARCHAR(5) NOT NULL,
    `KidDocumentoAsociado` INT NOT NULL,
    `descripcion` VARCHAR(150),
    `fecha_poliza` DATE,
    `total_poliza` DOUBLE,
    `estado` TINYINT,
    PRIMARY KEY(`KidPoliza`, `KidTipoDePoliza`, `KidDocumentoAsociado`),
    CONSTRAINT `fk_tipoDePoliza_PolizaEncabezado`
    FOREIGN KEY (`KidTipoDePoliza`)
    REFERENCES `tbl_tipo_poliza` (`KidTipoDePoliza`)
)ENGINE = InnoDB;

 -- -----------------------Partida Presupuesto------------------------------
 CREATE TABLE `tbl_poliza_detalle`(
	`KidPoliza` INT NOT NULL,
    `KidCuenta` VARCHAR(10) NOT NULL,
    `debe` DOUBLE,
    `haber` DOUBLE,
    PRIMARY KEY (KidPoliza, KidCuenta),
    CONSTRAINT `fk_PolizaEncabezado_PolizaDetalle`
    FOREIGN KEY (`KidPoliza`)
    REFERENCES `tbl_poliza_encabezado` (`KidPoliza`),
    CONSTRAINT `fk_Cuentas_PolizaDetalle`
    FOREIGN KEY (`KidCuenta`)
    REFERENCES `tbl_cuentas` (`KidCuenta`)
)ENGINE = InnoDB;

 -- -----------------------tbl_poliza_detalle------------------------------
CREATE TABLE `tbl_cuentas` (
  `KidCuenta` VARCHAR(10) NOT NULL,
  `KidTipoCuenta` VARCHAR(10) NOT NULL,
  `Kidentificador` INT,	
  `nombre` VARCHAR(25) NULL,
  `descripcion` VARCHAR(45) NULL,
  `estado` TINYINT NULL,
  PRIMARY KEY (`KidCuenta`, `KidTipoCuenta`,`Kidentificador`),
  CONSTRAINT `fk_tbl_cuentas_contables_tbl_tipoCuentaContable1`
    FOREIGN KEY (`KidTipoCuenta`)
    REFERENCES `tbl_tipoCuenta` (`KidTipoCuenta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

CREATE TABLE `tbl_tipoCuenta` (
  `KidTipoCuenta` VARCHAR(10) NOT NULL,
  `nombre_tipoCuenta` VARCHAR(25) NULL,
  `descripcion_tipoCuenta` VARCHAR(45) NULL,
  `estado` TINYINT NULL,
  PRIMARY KEY (`KidTipoCuenta`))
ENGINE = InnoDB;

CREATE TABLE `tbl_libroDiario` (
  `KidLibroDiario` INT NOT NULL ,
  `KidPoliza` VARCHAR(5) NOT NULL,
  `KidTipoDePoliza` INT NOT NULL,
  `descripcion` VARCHAR(150),
  `fecha_poliza` DATE,
  `fecha_poliza` DOUBLE,
  `estado` TINYINT NULL,
  PRIMARY KEY (`KidLibroDiario`, `KidPoliza`),
  CONSTRAINT `fk_polizaEncabezado_libroDiario`
    FOREIGN KEY (`KidPoliza`)
    REFERENCES `tbl_poliza_encabezado` (`KidPoliza`))
ENGINE = InnoDB; 

CREATE TABLE `tbl_cuentacontable` (
  `Codigo_CuentaContable` INT NOT NULL AUTO_INCREMENT,
  `Nombre_CuentaContable` VARCHAR(100) NULL DEFAULT NULL,
  `Clasificacion_CuentaContable` INT NULL DEFAULT NULL,
  `Estado_CuentaContable` VARCHAR(100) NULL DEFAULT NULL,
  `Monto_CuentaContable` VARCHAR(100) NULL DEFAULT NULL,
  PRIMARY KEY (`Codigo_CuentaContable`),
  CONSTRAINT `fk_cuentacontable_clasificacioncuenta1`
    FOREIGN KEY (`Clasificacion_CuentaContable`)
    REFERENCES `tbl_clasificacioncuenta` (`Codigo_clasificacion`)
    )ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4;

CREATE TABLE `tipo_cuenta_por_cobrar` (
  `pk_id_tipo_cuenta` int(11) NOT NULL,
  `nombre_cuenta` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;
CREATE TABLE `tbl_tipo_moneda` (
  `pkid_tipo_moneda` int NOT NULL,
  `nombre_tipo_moneda` varchar(50) NOT NULL,
  `descripcion_tipo_moneda` varchar(100) NOT NULL,
  `status_tipo_moneda` TINYINT NOT NULL,
   primary key(pkid_tipo_moneda)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE `tbl_movimiento` (
  `pkid_movimiento` int NOT NULL,
  `nombre_movimiento` varchar(50) NOT NULL,
  `status_movimiento` TINYINT NOT NULL,
  primary key(pkid_movimiento)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

 -- -----------------------Josue Amaya------------------------------
/* Josue Amaya 0901-19-12421 */
/* Tabla Cierre Cuentas Activos */
CREATE TABLE tbl_cierrectasact(
pkid_ctaAct INT AUTO_INCREMENT NOT NULL,
pkid_cuenta int not null,
nombre_cuenta VARCHAR (50) NOT NULL,
razon VARCHAR (50) NOT NULL,
monto FLOAT NOT NULL,
fecha DATE NOT NULL,
PRIMARY KEY(pkid_ctaAct,
pkid_cuenta),
FOREIGN KEY (`pkid_cuenta`) REFERENCES `tbl_cuentas` (`pkid_cuenta`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4;

/* Josue Amaya 0901-19-12421 */
/* Tabla Cierre Cuentas Pasivos */
CREATE TABLE tbl_cierrectaspas(
pkid_ctaPas INT AUTO_INCREMENT NOT NULL,
pkid_cuenta int not null,
nombre_cuenta VARCHAR (50) NOT NULL,
razon VARCHAR (50) NOT NULL,
monto FLOAT NOT NULL,
fecha DATE NOT NULL,
PRIMARY KEY (pkid_ctaPas,
pkid_cuenta),
FOREIGN KEY (`pkid_cuenta`) REFERENCES `tbl_cuentas` (`pkid_cuenta`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4;

/* Josue Amaya 0901-19-12421 */
/* Tabla Confirmar Cierre Cuentas */
CREATE TABLE tbl_confctascierrre(
pkid_confcierre INT AUTO_INCREMENT NOT NULL,
pkid_cuenta int not null,
cuenta_nombre VARCHAR(50) NOT NULL,
total_activo FLOAT NOT NULL,
total_pasivo FLOAT NOT NULL,
codigo_contador VARCHAR(20) NOT NULL,
nombre_contador VARCHAR(50) NOT NULL,
fecha_cierre DATE,
PRIMARY KEY (pkid_confcierre,
pkid_cuenta),
FOREIGN KEY (`pkid_cuenta`) REFERENCES `tbl_cuentas` (`pkid_cuenta`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4;

/* Josue Amaya 0901-19-12421 */
/* Tabla Cierre Activos */
CREATE TABLE tbl_cierreAct(
pkid_cierreA INT AUTO_INCREMENT NOT NULL,
pkid_cuenta int not null,
cuenta_nombre VARCHAR(50) NOT NULL,
monto_total FLOAT NOT NULL,
fecha_cierre DATE NOT NULL,
PRIMARY KEY (pkid_cierreA,
pkid_cuenta),
FOREIGN KEY (`pkid_cuenta`) REFERENCES `tbl_cuentas` (`pkid_cuenta`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4;

/* Josue Amaya 0901-19-12421 */
/* Tabla Cierre Pasivos */
CREATE TABLE tbl_cierrePas(
pkid_cierreP INT AUTO_INCREMENT NOT NULL,
pkid_cuenta int not null,
cuenta_nombre VARCHAR(50) NOT NULL,
monto_total FLOAT NOT NULL,
fecha_cierre DATE NOT NULL,
PRIMARY KEY (pkid_cierreP,
pkid_cuenta),
FOREIGN KEY (`pkid_cuenta`) REFERENCES `tbl_cuentas` (`pkid_cuenta`) 
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4;

/* Josue Amaya 0901-19-12421 */
/* Tabla Cierre General */
CREATE TABLE tbl_cierregeneral(
pkid_cierreG INT AUTO_INCREMENT NOT NULL,
pkid_cuenta int not null,
total_activo FLOAT NOT NULL,
total_pasivo FLOAT NOT NULL,
codigo_contador VARCHAR(20) NOT NULL,
nombre_contador VARCHAR(50) NOT NULL,
fecha_cierre DATE,
PRIMARY KEY (pkid_cierreG,
pkid_cuenta),
FOREIGN KEY (`pkid_cuenta`) REFERENCES `tbl_cuentas` (`pkid_cuenta`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8mb4;
