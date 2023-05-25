using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Service.Data.Models;

namespace Service.Data;

public partial class FizzFleetDbContext : DbContext
{
    public FizzFleetDbContext()
    {
    }

    public FizzFleetDbContext(DbContextOptions<FizzFleetDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Almacen> Almacen { get; set; }

    public virtual DbSet<Bodega> Bodega { get; set; }

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<CategoriaProducto> CategoriaProducto { get; set; }

    public virtual DbSet<Ciudad> Ciudad { get; set; }

    public virtual DbSet<Cliente> Cliente { get; set; }

    public virtual DbSet<Contacto> Contacto { get; set; }

    public virtual DbSet<Cupon> Cupon { get; set; }

    public virtual DbSet<Departamento> Departamento { get; set; }

    public virtual DbSet<Don> Don { get; set; }

    public virtual DbSet<Empleado> Empleado { get; set; }

    public virtual DbSet<Envio> Envio { get; set; }

    public virtual DbSet<EstadoEnvio> EstadoEnvio { get; set; }

    public virtual DbSet<Horario> Horario { get; set; }

    public virtual DbSet<Locacion> Locacion { get; set; }

    public virtual DbSet<Marca> Marca { get; set; }

    public virtual DbSet<Mensajero> Mensajero { get; set; }

    public virtual DbSet<MetodoPago> MetodoPago { get; set; }

    public virtual DbSet<MovimientosInventario> MovimientosInventario { get; set; }

    public virtual DbSet<Nan> Nan { get; set; }

    public virtual DbSet<Pais> Pais { get; set; }

    public virtual DbSet<Pedido> Pedido { get; set; }

    public virtual DbSet<PedidoDetalle> PedidoDetalle { get; set; }

    public virtual DbSet<PedidoRevision> PedidoRevision { get; set; }

    public virtual DbSet<Producto> Producto { get; set; }

    public virtual DbSet<Proveedor> Proveedor { get; set; }

    public virtual DbSet<PubliacionCaracteristica> PubliacionCaracteristica { get; set; }

    public virtual DbSet<Publicacion> Publicacion { get; set; }

    public virtual DbSet<PublicacionCategoria> PublicacionCategoria { get; set; }

    public virtual DbSet<PublicacionImagen> PublicacionImagen { get; set; }

    public virtual DbSet<Reclamo> Reclamo { get; set; }

    public virtual DbSet<ReporteEnvio> ReporteEnvio { get; set; }

    public virtual DbSet<SeleccionProducto> SeleccionProducto { get; set; }

    public virtual DbSet<Sesion> Sesion { get; set; }

    public virtual DbSet<TarjetaBancaria> TarjetaBancaria { get; set; }

    public virtual DbSet<TipoCargo> TipoCargo { get; set; }

    public virtual DbSet<TipoIdentidad> TipoIdentidad { get; set; }

    public virtual DbSet<TipoRol> TipoRol { get; set; }

    public virtual DbSet<Usuario> Usuario { get; set; }

    public virtual DbSet<Vehiculo> Vehiculo { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=AGATA\\SQLEXPRESS;Database=FizzFleetMain;Trusted_Connection=True;Persist Security Info=True;Encrypt=true;TrustServerCertificate=yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Almacen>(entity =>
        {
            entity.Property(e => e.Ubicacion).HasMaxLength(50);

            entity.HasOne(d => d.FkBodegaNavigation).WithMany(p => p.Almacen)
                .HasForeignKey(d => d.FkBodega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Almacen_Bodega");
        });

        modelBuilder.Entity<Bodega>(entity =>
        {
            entity.Property(e => e.Codigo).HasMaxLength(20);
            entity.Property(e => e.Ubicacion).HasMaxLength(100);
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.Property(e => e.Descripcion).HasMaxLength(300);
            entity.Property(e => e.Etiqueta).HasMaxLength(50);
        });

        modelBuilder.Entity<CategoriaProducto>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.FkCategoriaNavigation).WithMany(p => p.CategoriaProducto)
                .HasForeignKey(d => d.FkCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CategoriaProducto_Categoria");

            entity.HasOne(d => d.FkProductoNavigation).WithMany(p => p.CategoriaProducto)
                .HasForeignKey(d => d.FkProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CategoriaProducto_Producto");
        });

        modelBuilder.Entity<Ciudad>(entity =>
        {
            entity.Property(e => e.CodigoPostal).HasMaxLength(20);
            entity.Property(e => e.Nombre).HasMaxLength(200);

            entity.HasOne(d => d.FkDepartamentoNavigation).WithMany(p => p.Ciudad)
                .HasForeignKey(d => d.FkDepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ciudad_Departamento");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.Property(e => e.Apellido1).HasMaxLength(100);
            entity.Property(e => e.Apellido2).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.Nombre1).HasMaxLength(100);
            entity.Property(e => e.Nombre2).HasMaxLength(100);
            entity.Property(e => e.NumeroIdentidad).HasMaxLength(20);
            entity.Property(e => e.Telofono).HasMaxLength(20);

            entity.HasOne(d => d.FkTipoIdentidadNavigation).WithMany(p => p.Cliente)
                .HasForeignKey(d => d.FkTipoIdentidad)
                .HasConstraintName("FK_Cliente_TipoIdentidad");
        });

        modelBuilder.Entity<Contacto>(entity =>
        {
            entity.Property(e => e.Celular).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.NombreReferente).HasMaxLength(200);
            entity.Property(e => e.Telefono).HasMaxLength(20);

            entity.HasOne(d => d.FkProveedorNavigation).WithMany(p => p.Contacto)
                .HasForeignKey(d => d.FkProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contacto_Proveedor");
        });

        modelBuilder.Entity<Cupon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cupón");

            entity.Property(e => e.Codigo).HasMaxLength(10);
            entity.Property(e => e.FechaCaducidad).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.ValorRequerido).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.FkCategoriaNavigation).WithMany(p => p.Cupon)
                .HasForeignKey(d => d.FkCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cupón_Categoria");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.FkPaisNavigation).WithMany(p => p.Departamento)
                .HasForeignKey(d => d.FkPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Departamento_Pais");
        });

        modelBuilder.Entity<Don>(entity =>
        {
            entity.Property(e => e.DON1).HasColumnName("DON");

            entity.HasOne(d => d.FkNanNavigation).WithMany(p => p.Don)
                .HasForeignKey(d => d.FkNan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Don_Nan");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.Property(e => e.FechaContratacion).HasColumnType("date");
            entity.Property(e => e.FechaUltmaRenovacion).HasColumnType("date");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(300)
                .IsFixedLength();
            entity.Property(e => e.NumeroIdentidad).HasMaxLength(20);
            entity.Property(e => e.Telefono).HasMaxLength(20);

            entity.HasOne(d => d.FkCargoNavigation).WithMany(p => p.Empleado)
                .HasForeignKey(d => d.FkCargo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Empleado_TipoCargo");

            entity.HasOne(d => d.FkHorarioNavigation).WithMany(p => p.Empleado)
                .HasForeignKey(d => d.FkHorario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Empleado_Horario");
        });

        modelBuilder.Entity<Envio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Envío");

            entity.HasOne(d => d.FkMensajeroNavigation).WithMany(p => p.Envio)
                .HasForeignKey(d => d.FkMensajero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Envío_Mensajero");

            entity.HasOne(d => d.FkPedidoNavigation).WithMany(p => p.Envio)
                .HasForeignKey(d => d.FkPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Envío_PedidoRevisión");
        });

        modelBuilder.Entity<EstadoEnvio>(entity =>
        {
            entity.Property(e => e.Descripcion).HasMaxLength(300);
            entity.Property(e => e.Estado).HasMaxLength(50);
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity.Property(e => e.HoraEntrada).HasPrecision(1);
            entity.Property(e => e.HoraSalida).HasPrecision(1);
            entity.Property(e => e.Salario).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Locacion>(entity =>
        {
            entity.HasOne(d => d.FkCiudadNavigation).WithMany(p => p.Locacion)
                .HasForeignKey(d => d.FkCiudad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Locacion_Ciudad");

            entity.HasOne(d => d.FkClienteNavigation).WithMany(p => p.Locacion)
                .HasForeignKey(d => d.FkCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Locacion_Cliente");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.FkProveedorNavigation).WithMany(p => p.Marca)
                .HasForeignKey(d => d.FkProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Marca_Proveedor");
        });

        modelBuilder.Entity<Mensajero>(entity =>
        {
            entity.HasOne(d => d.FkEmpleadoNavigation).WithMany(p => p.Mensajero)
                .HasForeignKey(d => d.FkEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Mensajero_Empleado");

            entity.HasOne(d => d.FkVehiculoNavigation).WithMany(p => p.Mensajero)
                .HasForeignKey(d => d.FkVehiculo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Mensajero_Vehiculo");
        });

        modelBuilder.Entity<MetodoPago>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdTransaccion).HasMaxLength(100);

            entity.HasOne(d => d.FkTarjetaNavigation).WithMany(p => p.MetodoPago)
                .HasForeignKey(d => d.FkTarjeta)
                .HasConstraintName("FK_MetodoPago_TarjetaBancaria");
        });

        modelBuilder.Entity<MovimientosInventario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inventarios");

            entity.Property(e => e.FechaEntrada).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.Observaciones).HasMaxLength(300);

            entity.HasOne(d => d.FkEmpleadoNavigation).WithMany(p => p.MovimientosInventario)
                .HasForeignKey(d => d.FkEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientosInventario_Empleado");

            entity.HasOne(d => d.FkProductoNavigation).WithMany(p => p.MovimientosInventario)
                .HasForeignKey(d => d.FkProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientosInventario_Producto");

            entity.HasOne(d => d.FkReclamoNavigation).WithMany(p => p.MovimientosInventario)
                .HasForeignKey(d => d.FkReclamo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientosInventario_Reclamo");
        });

        modelBuilder.Entity<Nan>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.NAN1).HasColumnName("NAN");
        });

        modelBuilder.Entity<Pais>(entity =>
        {
            entity.Property(e => e.Nacionalidad).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.Siglas).HasMaxLength(10);
            entity.Property(e => e.ZonaHoraria).HasMaxLength(10);
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.Property(e => e.CodigoCupon).HasMaxLength(20);
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.IVA).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PrecioFinal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValorTotalSinIva).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.FkMetodoPagoNavigation).WithMany(p => p.Pedido)
                .HasForeignKey(d => d.FkMetodoPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pedido_MetodoPago");
        });

        modelBuilder.Entity<PedidoDetalle>(entity =>
        {
            entity.HasOne(d => d.FkPedidoNavigation).WithMany(p => p.PedidoDetalle)
                .HasForeignKey(d => d.FkPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedidoDetalle_Pedido");

            entity.HasOne(d => d.FkSeleccionProductoNavigation).WithMany(p => p.PedidoDetalle)
                .HasForeignKey(d => d.FkSeleccionProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedidoDetalle_SelecciónProducto");
        });

        modelBuilder.Entity<PedidoRevision>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EnvíoSalida");

            entity.Property(e => e.NombreRemitente).HasMaxLength(200);
            entity.Property(e => e.NumeroIdentidad).HasMaxLength(20);

            entity.HasOne(d => d.FkEmpleadoNavigation).WithMany(p => p.PedidoRevision)
                .HasForeignKey(d => d.FkEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedidoRevisión_Empleado");

            entity.HasOne(d => d.FkPedidoNavigation).WithMany(p => p.PedidoRevision)
                .HasForeignKey(d => d.FkPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedidoRevisión_Pedido");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.ValorUnitario).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.FkAlmacenNavigation).WithMany(p => p.Producto)
                .HasForeignKey(d => d.FkAlmacen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Producto_Almacen");

            entity.HasOne(d => d.FkMarcaNavigation).WithMany(p => p.Producto)
                .HasForeignKey(d => d.FkMarca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Producto_Marca");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.Property(e => e.NIT).HasMaxLength(100);
            entity.Property(e => e.NombreTitular).HasMaxLength(100);

            entity.HasOne(d => d.FkCiudadNavigation).WithMany(p => p.Proveedor)
                .HasForeignKey(d => d.FkCiudad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Proveedor_Ciudad");
        });

        modelBuilder.Entity<PubliacionCaracteristica>(entity =>
        {
            entity.Property(e => e.Caracteristica).HasMaxLength(100);
            entity.Property(e => e.Valor).HasMaxLength(100);

            entity.HasOne(d => d.FkPublicacionNavigation).WithMany(p => p.PubliacionCaracteristica)
                .HasForeignKey(d => d.FkPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PubliacionCaracteristica_Publicación");
        });

        modelBuilder.Entity<Publicacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Publicación");

            entity.Property(e => e.Descripcion).HasMaxLength(300);
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.FechaPublicacion).HasColumnType("date");
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Titulo).HasMaxLength(200);

            entity.HasOne(d => d.FkEmpleadoNavigation).WithMany(p => p.Publicacion)
                .HasForeignKey(d => d.FkEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Publicación_Empleado");

            entity.HasOne(d => d.FkProductoNavigation).WithMany(p => p.Publicacion)
                .HasForeignKey(d => d.FkProducto)
                .HasConstraintName("FK_Publicacion_Producto");
        });

        modelBuilder.Entity<PublicacionCategoria>(entity =>
        {
            entity.HasOne(d => d.FkCategoriaProductoNavigation).WithMany(p => p.PublicacionCategoria)
                .HasForeignKey(d => d.FkCategoriaProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PublicacionCategoria_CategoriaProducto");

            entity.HasOne(d => d.FkPublicacionNavigation).WithMany(p => p.PublicacionCategoria)
                .HasForeignKey(d => d.FkPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PublicacionCategoria_Publicacion");
        });

        modelBuilder.Entity<PublicacionImagen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PublicaciónImagen");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.FkPublicacionNavigation).WithMany(p => p.PublicacionImagen)
                .HasForeignKey(d => d.FkPublicacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PublicaciónImagen_Publicación");
        });

        modelBuilder.Entity<Reclamo>(entity =>
        {
            entity.Property(e => e.Tipo).HasMaxLength(100);
        });

        modelBuilder.Entity<ReporteEnvio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ReporteEnvío");

            entity.Property(e => e.FechaEntrega).HasColumnType("date");
            entity.Property(e => e.Observasiones).HasMaxLength(300);

            entity.HasOne(d => d.FkEstadoNavigation).WithMany(p => p.ReporteEnvio)
                .HasForeignKey(d => d.FkEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReporteEnvio_EstadoEnvio");

            entity.HasOne(d => d.FkMensajeroNavigation).WithMany(p => p.ReporteEnvio)
                .HasForeignKey(d => d.FkMensajero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReporteEnvío_Mensajero");
        });

        modelBuilder.Entity<SeleccionProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SelecciónProducto");

            entity.Property(e => e.FechaAñadido).HasColumnType("datetime");

            entity.HasOne(d => d.FkClienteNavigation).WithMany(p => p.SeleccionProducto)
                .HasForeignKey(d => d.FkCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SelecciónProducto_Cliente");

            entity.HasOne(d => d.FkProductoNavigation).WithMany(p => p.SeleccionProducto)
                .HasForeignKey(d => d.FkProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SelecciónProducto_Producto");
        });

        modelBuilder.Entity<Sesion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Sesión");

            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");

            entity.HasOne(d => d.FkUsuarioNavigation).WithMany(p => p.Sesion)
                .HasForeignKey(d => d.FkUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sesión_Usuario");
        });

        modelBuilder.Entity<TipoCargo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TipoCargo_1");

            entity.Property(e => e.Cargo).HasMaxLength(100);
        });

        modelBuilder.Entity<TipoIdentidad>(entity =>
        {
            entity.Property(e => e.Estado).HasDefaultValueSql("((0))");
            entity.Property(e => e.Siglas).HasMaxLength(10);
            entity.Property(e => e.Tipo).HasMaxLength(100);
        });

        modelBuilder.Entity<TipoRol>(entity =>
        {
            entity.Property(e => e.Rol).HasMaxLength(50);
            entity.Property(e => e.Siglas).HasMaxLength(10);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.Property(e => e.Usuario1).HasColumnName("Usuario");

            entity.HasOne(d => d.FkRolNavigation).WithMany(p => p.Usuario)
                .HasForeignKey(d => d.FkRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_TipoRol");
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.Property(e => e.Marca).HasMaxLength(50);
            entity.Property(e => e.Placa).HasMaxLength(10);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
