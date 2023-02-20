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



