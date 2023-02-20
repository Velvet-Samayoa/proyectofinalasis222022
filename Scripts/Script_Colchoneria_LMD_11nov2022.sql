INSERT INTO `tbl_modulos` VALUES
('1000', 'SEGURIDAD', 'Seguridad', 1),
('2000', 'LOGISTICA', 'Logistica', 1),
('3000', 'COMPRAS Y VENTAS', 'Compras y Ventas', 1),
('5000', 'PRODUCCIÓN', 'Produccion', 1),
('6000', 'NOMINAS', 'Nominas', 1),
('7000', 'BANCOS', 'Bancos', 1),
('8000', 'CONTABILIDAD', 'Contabilidad', 1);

-- -----APLICACIONES
INSERT INTO `tbl_aplicaciones` VALUES
('1000', 'MDI SEGURIDAD', 'PARA SEGURIDAD', '1'),
('2000', 'MDI LOGISTICA', 'PARA LOGISTICA', '1'),
('3000', 'MDI COMPRAS Y VENTAS', 'PARA COMPRAS Y VENTAS', '1'),
('5000', 'MDI PRODUCCIÓN', 'PARA PRODUCCIÓN', '1'),
('6000', 'MDI NOMINAS', 'PARA NOMINAS', '1'),
('7000', 'MDI BANCOS', 'PARA BANCOS', '1'),
('8000', 'MDI CONTRABILIDAD', 'PARA CONTRABILIDAD', '1');

-- -----USUARIOS
INSERT INTO `tbl_usuarios` VALUES
('1', 'admin', 'admin', 'admin', 'HO0aGo4nM94=', 'esduardo@gmail.com', '2022-07-02 21:00:48', '1', 'COLOR FAVORITO', 'ROJO');

-- -----PERFILES
INSERT INTO `tbl_perfiles` VALUES
('1', 'ADMINISTRADOR', 'contiene todos los permisos del programa', 1),
('2', 'SEGURIDAD', 'contiene todos los permisos de seguridad', 1),
('3', 'LOGISTICA', 'contiene todos los permisos de logistica', 1),
('4', 'COMPRAS Y VENTAS', 'contiene todos los permisos de compras y ventas', 1),
('5', 'PRODUCCIÓN', 'contiene todos los permisos de producción', 1),
('6', 'NOMINAS', 'contiene todos los permisos de nominas', 1),
('7', 'BANCOS', 'contiene todos los permisos de bancos', 1),
('8', 'CONTABILIDAD', 'contiene todos los permisos de contabilidad', 1);

-- -----ASIGNACIÓNES MODULO A APLICACION
INSERT INTO `tbl_asignacionmoduloaplicacion` VALUES
('1000', '1000'),
('2000', '2000'),
('3000', '3000'),
('5000', '5000'),
('6000', '6000'),
('7000', '7000'),
('8000', '8000');

-- -----PERMISOS DE APLICACIONES A PERFILES
INSERT INTO `tbl_permisosAplicacionPerfil` VALUES
('1', '1000', '1', '1', '1', '1', '1'),
('1', '2000', '1', '1', '1', '1', '1'),
('1', '3000', '1', '1', '1', '1', '1'),
('1', '5000', '1', '1', '1', '1', '1'),
('1', '6000', '1', '1', '1', '1', '1'),
('1', '7000', '1', '1', '1', '1', '1'),
('1', '8000', '1', '1', '1', '1', '1'),
('2', '1000', '1', '1', '1', '1', '1'),
('3', '2000', '1', '1', '1', '1', '1'),
('4', '3000', '1', '1', '1', '1', '1'),
('5', '5000', '1', '1', '1', '1', '1'),
('6', '6000', '1', '1', '1', '1', '1'),
('7', '7000', '1', '1', '1', '1', '1'),
('8', '8000', '1', '1', '1', '1', '1');

-- -----ASIGNACIÓN DE PERFIL A USUARIO
INSERT INTO `tbl_asignacionesPerfilsUsuario` VALUES
('1', '1'); 


-- --Bancos
insert into `Tbl_tiposPagos` values (1,"Efectivo");
insert into `Tbl_tiposPagos` values (2,"Cheque");
insert into `Tbl_tiposPagos` values (3,"Transferencia");
insert into `Tbl_tiposPagos` values (4,"Tarjeta de Credito");
insert into `Tbl_tiposPagos` values (5,"Otros");

insert into `Tbl_bancos` values (2,"BAM","Ciudad Quetzaltenango","2290-0010",1);
insert into `Tbl_bancos` values (3,"BANTRAB","Antigua Guatemala","2280-0250",1);
insert into `Tbl_bancos` values (4,"BANCO INDUSTRIAL","Ciudad Cayala","2290-9029",1);

insert into `Tbl_Miembros` values (1,"Joshua Alejandro Barrios Ortíz","Guatemala","3019 09201 0101",1);
insert into `Tbl_Miembros` values (2,"Jorge Mario Marroquin Roca","Guatemala","3323 09381 0101",1);
insert into `Tbl_Miembros` values (3,"Yordi Daniel Hernadez ","Guatemala","9212 23401 0101",1);
insert into `Tbl_Miembros` values (4,"Ester Daniela Lopez Cruz","Guatemala","5893 93301 0101",1);
insert into `Tbl_Miembros` values (5,"Derek Leonel Herrera Pineda","Guatemala","3232 03211 0101",1);

-- ------TRIGGER DE BANCOS ---------------
DELIMITER //
CREATE TRIGGER tgCheques  AFTER INSERT ON Tbl_Ctrl_cheques 
for each row begin
	insert into Tbl_Movimientos_bancos (fk_tipo_pago,fk_id_concepto,fecha_mov,fk_Cuenta_banco,fk_cuentarelacionada,Monto_mov) 
    values (2,new.fk_id_concepto,new.fechaReg_cheques,new.fk_Banco_cheques,new.fk_id_cuentabancaria,new.montoNum_cheques);
END//

DELIMITER //
CREATE TRIGGER tgSaldos  AFTER INSERT ON Tbl_Movimientos_bancos
for each row begin
	IF (select Clasificacion from Tbl_Movimientos_bancos inner join Tbl_ConceptosBancario on 
    Pk_idConcepto = fk_id_concepto where Pk_idMovimientos = new.Pk_idMovimientos)  = "Cargo" then
		UPDATE Tbl_CuentasBancos set SActual_montbancario = SActual_montbancario - new.Monto_mov where new.fk_Cuenta_banco = Pk_idCuentas;
		UPDATE Tbl_CuentasBancos set SConciliado_montbancario = SConciliado_montbancario - new.Monto_mov where new.fk_Cuenta_banco = Pk_idCuentas;
		UPDATE Tbl_CuentasBancos set TCargos_montbancario = TCargos_montbancario + new.Monto_mov where new.fk_Cuenta_banco = Pk_idCuentas;
   END IF;
    	IF (select Clasificacion from Tbl_Movimientos_bancos inner join Tbl_ConceptosBancario on 
    Pk_idConcepto = fk_id_concepto where Pk_idMovimientos = new.Pk_idMovimientos)  = "Abono" then
		UPDATE Tbl_CuentasBancos set SActual_montbancario = SActual_montbancario + new.Monto_mov where new.fk_Cuenta_banco = Pk_idCuentas;
		UPDATE Tbl_CuentasBancos set SConciliado_montbancario = SConciliado_montbancario + new.Monto_mov where new.fk_Cuenta_banco = Pk_idCuentas;
	    UPDATE Tbl_CuentasBancos set TAbonos_montbancario = TAbonos_montbancario + new.Monto_mov where new.fk_Cuenta_banco = Pk_idCuentas;
   END IF;
END//
drop trigger tgSaldos;
select * from Tbl_Movimientos_bancos;
insert into Tbl_Movimientos_bancos values (20,1,8,"2022-10-10",1,2,1000);

select nombre_banco,Nombre_cta,TCargos_montbancario,TAbonos_montbancario,SActual_montbancario from tbl_cuentasbancos inner join Tbl_bancos on fk_bancos = Pk_idbancos;


-- PRODUCCION
-- Store procedure produccion (ordenes agregar o editar)
DROP procedure IF EXISTS `pa_produccion_ordenes_agregareditar`;
DELIMITER $$
USE `colchoneria`$$
CREATE PROCEDURE `pa_produccion_ordenes_agregareditar` (
_pk_idordenes_tbl_ordenes int,
_fk_idrecetas_tbl_recetas int,
_prioridad_tbl_ordenes varchar(45),
_producto_fabricar_tbl_ordenes varchar(45),
_cantidad_tbl_ordenes int,
_fechaini_tbl_ordenes VARCHAR(25),
_fechaentrega_tbl_ordenes VARCHAR(25),
_fechacreacion_orden_tbl_ordenes varchar(45),
_detalle_tbl_ordenes varchar(300)
)
BEGIN
if _pk_idordenes_tbl_ordenes = 0 then
	insert into tbl_ordenes (fk_idrecetas_tbl_recetas,prioridad_tbl_ordenes,producto_fabricar_tbl_ordenes,cantidad_tbl_ordenes,fechaini_tbl_ordenes,fechaentrega_tbl_ordenes,fechacreacion_orden_tbl_ordenes,detalle_tbl_ordenes)
    values (_fk_idrecetas_tbl_recetas,_prioridad_tbl_ordenes,_producto_fabricar_tbl_ordenes,_cantidad_tbl_ordenes,_fechaini_tbl_ordenes,_fechaentrega_tbl_ordenes,_fechacreacion_orden_tbl_ordenes,_detalle_tbl_ordenes);
else
	update tbl_ordenes
    set
		fk_idrecetas_tbl_recetas = _fk_idrecetas_tbl_recetas,
        prioridad_tbl_ordenes = _prioridad_tbl_ordenes,
        producto_fabricar_tbl_ordenes = _producto_fabricar_tbl_ordenes,
        cantidad_tbl_ordenes = _cantidad_tbl_ordenes,
        fechaini_tbl_ordenes = _fechaini_tbl_ordenes,
        fechaentrega_tbl_ordenes = _fechaentrega_tbl_ordenes,
        fechacreacion_orden_tbl_ordenes =_fechacreacion_orden_tbl_ordenes,
        detalle_tbl_ordenes = _detalle_tbl_ordenes
        where pk_idordenes_tbl_ordenes = _pk_idordenes_tbl_ordenes;
end if;

END$$

DELIMITER ;

-- Store procedure produccion (ordenes ver)
DROP procedure IF EXISTS `pa_produccion_ordenes_ver`;

DELIMITER $$
USE `colchoneria`$$
CREATE PROCEDURE `pa_produccion_ordenes_ver` ()
BEGIN
	select *
    from tbl_ordenes;
END$$

DELIMITER ;

DELIMITER $$
USE `colchoneria`$$
CREATE PROCEDURE `pa_recetas_agregareditar` (
_pk_idrecetas_tbl_recetas INT,
_producto_tbl_recetas varchar(45),
_nombre_material_tbl_recetas varchar(100),
_cantidad_tbl_recetas varchar(100),
_medida_tbl_recetas varchar(45)
)
BEGIN
if _pk_idrecetas_tbl_recetas = 0 then
    insert into tbl_recetas (producto_tbl_recetas,nombre_material_tbl_recetas,cantidad_tbl_recetas,medida_tbl_recetas)
    values (_producto_tbl_recetas,_nombre_material_tbl_recetas,_cantidad_tbl_recetas,_medida_tbl_recetas);
else
    update tbl_recetas
    set
        producto_tbl_recetas = _producto_tbl_recetas,
        nombre_material_tbl_recetas = _nombre_material_tbl_recetas,
        cantidad_tbl_recetas = _cantidad_tbl_recetas,
        medida_tbl_recetas = _medida_tbl_recetas
        where pk_idrecetas_tbl_recetas = _pk_idrecetas_tbl_recetas;
end if;

END$$

DELIMITER ;


-- Nominas
INSERT INTO `tbl_departamentos` VALUES 
('2000', 'Logistica', 'DEPTO. LOGISTICA', '1'), 
('3000', 'Compras', 'DEPTO. COMPRAS', '1'), 
('4000', 'Comercial', 'DEPTO. COMERCIAL', '1'), 
('5000', 'Marketing Y Publicidad', 'DEPTO. Marketing y Publicidad', '0'), 
('6000', 'Recursos Humanos', 'DEPTO. RRHH', '0');

INSERT INTO `tbl_puestosdetrabajo` VALUES 
('2001', 'JEFE DE LOGISTICA', '1'), ('2002', 'ASISTENTE DE LOGISTICA', '0'), ('2003', 'ANALISTA DE ABASTECIMIENTO', '0'), 
('3001', 'GESTOR DE PROVEEDORES', '1'), ('3002', 'GESTOR DE PRODUCTOS', '1'), ('3003', 'ANALISTA DE COMPRAS', '0'), 
('4001', 'DIRECTOR COMERCIAL', '1'), ('4002', 'GERENTE DE VENTAS', '1'), ('4003', 'VENDEDOR', '0'), 
('5001', 'ANALISTA DE MARKETING', '1'), ('5002', 'SUPERVISOR DE MARKETING', '1'), ('5003', 'PUBLICISTA', '0'), 
('6001', 'DIRECTOR DE RRHH', '1'), ('6002', 'ADMINISTRADOR DE PERSONAL', '1'), ('6003', 'RECLUTADOR', '0');

INSERT INTO `tbl_trabajador` VALUES
(1, '2022-10-18', 'Amerigo', 'achalliss0@time.com', '4 Carpenter Court', '12345671', 1),
(2, '2022-10-19', 'Merrill', 'mfilponi1@sprger.com', '649 Vermont Avenue', '12345672', 1),
(3, '2022-10-21', 'Morgan', 'mstonhard2@bing.com', '48922 Bayside Avenue', '12345673', 1),
(4, '2022-10-18', 'Mirna', 'mstilell3@jappost.jp', '8 1st Center', '12345674', 1),
(5, '2022-10-23', 'Leilah', 'lgerlack4@pcwld.com', '38208 Miller Junction', '12345675', 1),
(6, '2022-10-18', 'Waite', 'wvaken5@e-recht24.de', '2 Hoffman Lane', '12345676', 1),
(7, '2022-10-18', 'Fionnula', 'fgihs6@japapost.jp', '7 Talisman Lane', '12345677', 1),
(8, '2022-10-20', 'Giulietta', 'gcheow7@12rg.co.uk', '03806 Hanson Lane', '12345678', 1),
(9, '2022-10-19', 'Brande', 'bsyns8@ustream.tv', '3 1st Center', '12345679', 1),
(10, '2022-10-19', 'Adrea', 'ahutcnce9@fema.gov', '3094 Calypso Plaza', '12345670', 1),
(11, '2022-10-20', 'Wadsworth', 'wtrewetta@51.la', '87 Amoth Parkway', '12345680', 1),
(12, '2022-10-19', 'Dirk', 'dbolverb@issuu.com', '4000 Magdeline Park', '12345681', 1),
(13, '2022-10-23', 'Towny', 'tdurranc@bloo.com', '5 Barnett Way', '12345682', 1),
(14, '2022-10-23', 'Jinny', 'jlaxtond@google.com', '14 Forster Road', '12345683', 1),
(15, '2022-10-22', 'Hannah', 'hmerrelle@java.com', '21 Autumn Leaf Hill', '12345684', 1);

INSERT INTO `tbl_contrato` VALUES 
('1', '5000', '1', '80', '1', '1'), 
('2', '5000', '1', '80', '2', '1'),
('3', '10000', '2', '160', '2', '1'),
('4', '10000', '2', '160', '1', '1');

INSERT INTO `tbl_percepciones` VALUES 
('1', 'IGSS', '0', '4.83', '0', '1'), 
('2', 'FORMACIÓN PROFESIONAL', '0', '0.1', '0', '1'), 
('3', 'HORAS EXTRAS', '1', '150', '0', '1'), 
('4', 'BONIFICACIÓN INCENTIVO', '1', '0', '250', '1');

INSERT INTO `tbl_asignacion_puestodepartamento` VALUES 
('2001', '2000'), ('2002', '2000'), ('2003', '2000'), 
('3001', '3000'), ('3002', '3000'), ('3003', '3000'), 
('4001', '4000'), ('4002', '4000'), ('4003', '4000'), 
('5001', '5000'), ('5002', '5000'), ('5003', '5000'), 
('6001', '6000'), ('6002', '6000'), ('6003', '6000');

INSERT INTO `tbl_asignacion_puestotrabajador` VALUES 
('2001', '1'), ('2002', '2'), ('2003', '3'), 
('3001', '4'), ('3002', '5'), ('3003', '6'), 
('4001', '7'), ('4002', '8'), ('4003', '9'), 
('5001', '10'), ('5002', '11'), ('5003', '12'), 
('6001', '13'), ('6002', '14'), ('6003', '15');

INSERT INTO `tbl_asignacion_contratopercepciones` VALUES 
('1', '1'), ('1', '2'), ('1', '3');

INSERT INTO `tbl_asignacion_contratotrabajador` VALUES 
('1', '1'), ('1', '2'), ('1', '3'), ('1', '4');

INSERT INTO `tbl_horasextras` VALUES 
('1', '2022-10-26', '1.5'), ('1', '2022-10-27', '1.5');
