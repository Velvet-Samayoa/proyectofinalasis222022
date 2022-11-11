USE `colchoneria`;
alter table tblcotizaciones add column fk_codigo_producto int;
alter table tblcotizaciones add constraint fk2_codigo_producto foreign key (fk_codigo_producto ) references tbl_producto(pk_codigo_producto );
ALTER TABLE `tbldetalleventa` DROP FOREIGN KEY `tbldetalleventa_ibfk_1`;
ALTER TABLE `tbldetalleventa` DROP COLUMN PkId_DetalleVenta;
