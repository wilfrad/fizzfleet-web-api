using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Service.Data.Migrations;

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

    public virtual DbSet<Almacen> Almacens { get; set; }

    public virtual DbSet<Bodega> Bodegas { get; set; }

    public virtual DbSet<CategoriaProducto> CategoriaProductos { get; set; }

    public virtual DbSet<Categorium> Categoria { get; set; }

    public virtual DbSet<Ciudad> Ciudads { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Contacto> Contactos { get; set; }

    public virtual DbSet<Cupon> Cupons { get; set; }

    public virtual DbSet<Departamento> Departamentos { get; set; }

    public virtual DbSet<Don> Dons { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Envio> Envios { get; set; }

    public virtual DbSet<EstadoEnvio> EstadoEnvios { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<Locacion> Locacions { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Mensajero> Mensajeros { get; set; }

    public virtual DbSet<MetodoPago> MetodoPagos { get; set; }

    public virtual DbSet<MovimientosInventario> MovimientosInventarios { get; set; }

    public virtual DbSet<Nan> Nans { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<PedidoDetalle> PedidoDetalles { get; set; }

    public virtual DbSet<PedidoRevision> PedidoRevisions { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedor> Proveedors { get; set; }

    public virtual DbSet<PubliacionCaracteristica> PubliacionCaracteristicas { get; set; }

    public virtual DbSet<Publicacion> Publicacions { get; set; }

    public virtual DbSet<PublicacionCategorium> PublicacionCategoria { get; set; }

    public virtual DbSet<PublicacionImagen> PublicacionImagens { get; set; }

    public virtual DbSet<Reclamo> Reclamos { get; set; }

    public virtual DbSet<ReporteEnvio> ReporteEnvios { get; set; }

    public virtual DbSet<SeleccionProducto> SeleccionProductos { get; set; }

    public virtual DbSet<Sesion> Sesions { get; set; }

    public virtual DbSet<TarjetaBancarium> TarjetaBancaria { get; set; }

    public virtual DbSet<TipoCargo> TipoCargos { get; set; }

    public virtual DbSet<TipoIdentidad> TipoIdentidads { get; set; }

    public virtual DbSet<TipoRol> TipoRols { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Vehiculo> Vehiculos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=AGATA\\SQLEXPRESS;Database=FizzFleetMain;Trusted_Connection=true;Persist Security Info=True;Encrypt=true;TrustServerCertificate=yes");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Almacen>(entity =>
        {
            entity.ToTable("Almacen");

            entity.Property(e => e.Ubicación).HasMaxLength(50);

            entity.HasOne(d => d.FkBodegaNavigation).WithMany(p => p.Almacens)
                .HasForeignKey(d => d.FkBodega)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Almacen_Bodega");
        });

        modelBuilder.Entity<Bodega>(entity =>
        {
            entity.ToTable("Bodega");

            entity.Property(e => e.Codigo).HasMaxLength(20);
            entity.Property(e => e.Ubicación).HasMaxLength(100);
        });

        modelBuilder.Entity<CategoriaProducto>(entity =>
        {
            entity.ToTable("CategoriaProducto");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.FkCategoriaNavigation).WithMany(p => p.CategoriaProductos)
                .HasForeignKey(d => d.FkCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CategoriaProducto_Categoria");

            entity.HasOne(d => d.FkProductoNavigation).WithMany(p => p.CategoriaProductos)
                .HasForeignKey(d => d.FkProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CategoriaProducto_Producto");
        });

        modelBuilder.Entity<Categorium>(entity =>
        {
            entity.Property(e => e.Descripción).HasMaxLength(300);
            entity.Property(e => e.Etiqueta).HasMaxLength(50);
        });

        modelBuilder.Entity<Ciudad>(entity =>
        {
            entity.ToTable("Ciudad");

            entity.Property(e => e.CodigoPostal).HasMaxLength(20);
            entity.Property(e => e.Nombre).HasMaxLength(200);

            entity.HasOne(d => d.FkDepartamentoNavigation).WithMany(p => p.Ciudads)
                .HasForeignKey(d => d.FkDepartamento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ciudad_Departamento");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.ToTable("Cliente");

            entity.Property(e => e.Apellido1).HasMaxLength(100);
            entity.Property(e => e.Apellido2).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.Nombre1).HasMaxLength(100);
            entity.Property(e => e.Nombre2).HasMaxLength(100);
            entity.Property(e => e.NumeroIdentidad).HasMaxLength(20);
            entity.Property(e => e.Telofono).HasMaxLength(20);

            entity.HasOne(d => d.FkTipoIdentidadNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.FkTipoIdentidad)
                .HasConstraintName("FK_Cliente_TipoIdentidad");
        });

        modelBuilder.Entity<Contacto>(entity =>
        {
            entity.ToTable("Contacto");

            entity.Property(e => e.Celular).HasMaxLength(20);
            entity.Property(e => e.Email).HasMaxLength(200);
            entity.Property(e => e.NombreReferente).HasMaxLength(200);
            entity.Property(e => e.Telefono).HasMaxLength(20);

            entity.HasOne(d => d.FkProveedorNavigation).WithMany(p => p.Contactos)
                .HasForeignKey(d => d.FkProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Contacto_Proveedor");
        });

        modelBuilder.Entity<Cupon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cupón");

            entity.ToTable("Cupon");

            entity.Property(e => e.Codigo).HasMaxLength(10);
            entity.Property(e => e.FechaCaducidad).HasColumnType("datetime");
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.ValorRequerido).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.FkCategoriaNavigation).WithMany(p => p.Cupons)
                .HasForeignKey(d => d.FkCategoria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Cupón_Categoria");
        });

        modelBuilder.Entity<Departamento>(entity =>
        {
            entity.ToTable("Departamento");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.FkPaisNavigation).WithMany(p => p.Departamentos)
                .HasForeignKey(d => d.FkPais)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Departamento_Pais");
        });

        modelBuilder.Entity<Don>(entity =>
        {
            entity.ToTable("Don");

            entity.Property(e => e.Don1).HasColumnName("DON");

            entity.HasOne(d => d.FkNanNavigation).WithMany(p => p.Dons)
                .HasForeignKey(d => d.FkNan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Don_Nan");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.ToTable("Empleado");

            entity.Property(e => e.FechaContratación).HasColumnType("date");
            entity.Property(e => e.FechaUltmaRenovación).HasColumnType("date");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(300)
                .IsFixedLength();
            entity.Property(e => e.NumeroIdentidad).HasMaxLength(20);
            entity.Property(e => e.Telefono).HasMaxLength(20);

            entity.HasOne(d => d.FkCargoNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.FkCargo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Empleado_TipoCargo");

            entity.HasOne(d => d.FkHorarioNavigation).WithMany(p => p.Empleados)
                .HasForeignKey(d => d.FkHorario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Empleado_Horario");
        });

        modelBuilder.Entity<Envio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Envío");

            entity.ToTable("Envio");

            entity.HasOne(d => d.FkMensajeroNavigation).WithMany(p => p.Envios)
                .HasForeignKey(d => d.FkMensajero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Envío_Mensajero");

            entity.HasOne(d => d.FkPedidoNavigation).WithMany(p => p.Envios)
                .HasForeignKey(d => d.FkPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Envío_PedidoRevisión");
        });

        modelBuilder.Entity<EstadoEnvio>(entity =>
        {
            entity.ToTable("EstadoEnvio");

            entity.Property(e => e.Descripción).HasMaxLength(300);
            entity.Property(e => e.Estado).HasMaxLength(50);
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity.ToTable("Horario");

            entity.Property(e => e.HoraEntrada).HasPrecision(1);
            entity.Property(e => e.HoraSalida).HasPrecision(1);
            entity.Property(e => e.Salario).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Locacion>(entity =>
        {
            entity.ToTable("Locacion");

            entity.HasOne(d => d.FkCiudadNavigation).WithMany(p => p.Locacions)
                .HasForeignKey(d => d.FkCiudad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Locacion_Ciudad");

            entity.HasOne(d => d.FkClienteNavigation).WithMany(p => p.Locacions)
                .HasForeignKey(d => d.FkCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Locacion_Cliente");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.ToTable("Marca");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.FkProveedorNavigation).WithMany(p => p.Marcas)
                .HasForeignKey(d => d.FkProveedor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Marca_Proveedor");
        });

        modelBuilder.Entity<Mensajero>(entity =>
        {
            entity.ToTable("Mensajero");

            entity.HasOne(d => d.FkEmpleadoNavigation).WithMany(p => p.Mensajeros)
                .HasForeignKey(d => d.FkEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Mensajero_Empleado");

            entity.HasOne(d => d.FkVehiculoNavigation).WithMany(p => p.Mensajeros)
                .HasForeignKey(d => d.FkVehiculo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Mensajero_Vehiculo");
        });

        modelBuilder.Entity<MetodoPago>(entity =>
        {
            entity.ToTable("MetodoPago");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.IdTransacción).HasMaxLength(100);

            entity.HasOne(d => d.FkTarjetaNavigation).WithMany(p => p.MetodoPagos)
                .HasForeignKey(d => d.FkTarjeta)
                .HasConstraintName("FK_MetodoPago_TarjetaBancaria");
        });

        modelBuilder.Entity<MovimientosInventario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inventarios");

            entity.ToTable("MovimientosInventario");

            entity.Property(e => e.FechaEntrada).HasColumnType("datetime");
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.Observaciones).HasMaxLength(300);

            entity.HasOne(d => d.FkEmpleadoNavigation).WithMany(p => p.MovimientosInventarios)
                .HasForeignKey(d => d.FkEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientosInventario_Empleado");

            entity.HasOne(d => d.FkProductoNavigation).WithMany(p => p.MovimientosInventarios)
                .HasForeignKey(d => d.FkProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientosInventario_Producto");

            entity.HasOne(d => d.FkReclamoNavigation).WithMany(p => p.MovimientosInventarios)
                .HasForeignKey(d => d.FkReclamo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MovimientosInventario_Reclamo");
        });

        modelBuilder.Entity<Nan>(entity =>
        {
            entity.ToTable("Nan");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Nan1).HasColumnName("NAN");
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.Property(e => e.Nacionalidad).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(200);
            entity.Property(e => e.Siglas).HasMaxLength(10);
            entity.Property(e => e.ZonaHoraria).HasMaxLength(10);
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.ToTable("Pedido");

            entity.Property(e => e.CodigoCupón).HasMaxLength(20);
            entity.Property(e => e.FechaPago).HasColumnType("datetime");
            entity.Property(e => e.Iva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("IVA");
            entity.Property(e => e.PrecioFinal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ValorTotalSinIva).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.FkMetodoPagoNavigation).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.FkMetodoPago)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Pedido_MetodoPago");
        });

        modelBuilder.Entity<PedidoDetalle>(entity =>
        {
            entity.ToTable("PedidoDetalle");

            entity.HasOne(d => d.FkPedidoNavigation).WithMany(p => p.PedidoDetalles)
                .HasForeignKey(d => d.FkPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedidoDetalle_Pedido");

            entity.HasOne(d => d.FkSelecciónProductoNavigation).WithMany(p => p.PedidoDetalles)
                .HasForeignKey(d => d.FkSelecciónProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedidoDetalle_SelecciónProducto");
        });

        modelBuilder.Entity<PedidoRevision>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EnvíoSalida");

            entity.ToTable("PedidoRevision");

            entity.Property(e => e.NombreRemitente).HasMaxLength(200);
            entity.Property(e => e.NumeroIdentidad).HasMaxLength(20);

            entity.HasOne(d => d.FkEmpleadoNavigation).WithMany(p => p.PedidoRevisions)
                .HasForeignKey(d => d.FkEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedidoRevisión_Empleado");

            entity.HasOne(d => d.FkPedidoNavigation).WithMany(p => p.PedidoRevisions)
                .HasForeignKey(d => d.FkPedido)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PedidoRevisión_Pedido");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.ToTable("Producto");

            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.ValorUnitario).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.FkAlmacenNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.FkAlmacen)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Producto_Almacen");

            entity.HasOne(d => d.FkMarcaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.FkMarca)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Producto_Marca");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.ToTable("Proveedor");

            entity.Property(e => e.Nit)
                .HasMaxLength(100)
                .HasColumnName("NIT");
            entity.Property(e => e.NombreTitular).HasMaxLength(100);

            entity.HasOne(d => d.FkCiudadNavigation).WithMany(p => p.Proveedors)
                .HasForeignKey(d => d.FkCiudad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Proveedor_Ciudad");
        });

        modelBuilder.Entity<PubliacionCaracteristica>(entity =>
        {
            entity.ToTable("PubliacionCaracteristica");

            entity.Property(e => e.Caracteristica).HasMaxLength(100);
            entity.Property(e => e.Valor).HasMaxLength(100);

            entity.HasOne(d => d.FkPublicaciónNavigation).WithMany(p => p.PubliacionCaracteristicas)
                .HasForeignKey(d => d.FkPublicación)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PubliacionCaracteristica_Publicación");
        });

        modelBuilder.Entity<Publicacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Publicación");

            entity.ToTable("Publicacion");

            entity.Property(e => e.Descripción).HasMaxLength(300);
            entity.Property(e => e.FechaModificación).HasColumnType("datetime");
            entity.Property(e => e.FechaPublicación).HasColumnType("date");
            entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Titulo).HasMaxLength(200);

            entity.HasOne(d => d.FkEmpleadoNavigation).WithMany(p => p.Publicacions)
                .HasForeignKey(d => d.FkEmpleado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Publicación_Empleado");

            entity.HasOne(d => d.FkProductoNavigation).WithMany(p => p.Publicacions)
                .HasForeignKey(d => d.FkProducto)
                .HasConstraintName("FK_Publicacion_Producto");
        });

        modelBuilder.Entity<PublicacionCategorium>(entity =>
        {
            entity.HasOne(d => d.FkCategoriaProductoNavigation).WithMany(p => p.PublicacionCategoria)
                .HasForeignKey(d => d.FkCategoriaProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PublicacionCategoria_CategoriaProducto");

            entity.HasOne(d => d.FkPublicaciónNavigation).WithMany(p => p.PublicacionCategoria)
                .HasForeignKey(d => d.FkPublicación)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PublicacionCategoria_Publicacion");
        });

        modelBuilder.Entity<PublicacionImagen>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PublicaciónImagen");

            entity.ToTable("PublicacionImagen");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.FkPublicaciónNavigation).WithMany(p => p.PublicacionImagens)
                .HasForeignKey(d => d.FkPublicación)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_PublicaciónImagen_Publicación");
        });

        modelBuilder.Entity<Reclamo>(entity =>
        {
            entity.ToTable("Reclamo");

            entity.Property(e => e.Tipo).HasMaxLength(100);
        });

        modelBuilder.Entity<ReporteEnvio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ReporteEnvío");

            entity.ToTable("ReporteEnvio");

            entity.Property(e => e.FechaEntrega).HasColumnType("date");
            entity.Property(e => e.Observasiones).HasMaxLength(300);

            entity.HasOne(d => d.FkEstadoNavigation).WithMany(p => p.ReporteEnvios)
                .HasForeignKey(d => d.FkEstado)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReporteEnvio_EstadoEnvio");

            entity.HasOne(d => d.FkMensajeroNavigation).WithMany(p => p.ReporteEnvios)
                .HasForeignKey(d => d.FkMensajero)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ReporteEnvío_Mensajero");
        });

        modelBuilder.Entity<SeleccionProducto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SelecciónProducto");

            entity.ToTable("SeleccionProducto");

            entity.Property(e => e.FechaAñadido).HasColumnType("datetime");

            entity.HasOne(d => d.FkClienteNavigation).WithMany(p => p.SeleccionProductos)
                .HasForeignKey(d => d.FkCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SelecciónProducto_Cliente");

            entity.HasOne(d => d.FkProductoNavigation).WithMany(p => p.SeleccionProductos)
                .HasForeignKey(d => d.FkProducto)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SelecciónProducto_Producto");
        });

        modelBuilder.Entity<Sesion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Sesión");

            entity.ToTable("Sesion");

            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaInicio).HasColumnType("datetime");

            entity.HasOne(d => d.FkUsuarioNavigation).WithMany(p => p.Sesions)
                .HasForeignKey(d => d.FkUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sesión_Usuario");
        });

        modelBuilder.Entity<TipoCargo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_TipoCargo_1");

            entity.ToTable("TipoCargo");

            entity.Property(e => e.Cargo).HasMaxLength(100);
        });

        modelBuilder.Entity<TipoIdentidad>(entity =>
        {
            entity.ToTable("TipoIdentidad");

            entity.Property(e => e.Siglas).HasMaxLength(10);
            entity.Property(e => e.Tipo).HasMaxLength(100);
        });

        modelBuilder.Entity<TipoRol>(entity =>
        {
            entity.ToTable("TipoRol");

            entity.Property(e => e.Rol).HasMaxLength(50);
            entity.Property(e => e.Siglas).HasMaxLength(10);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.ToTable("Usuario");

            entity.Property(e => e.Usuario1).HasColumnName("Usuario");

            entity.HasOne(d => d.FkRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.FkRol)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_TipoRol");
        });

        modelBuilder.Entity<Vehiculo>(entity =>
        {
            entity.ToTable("Vehiculo");

            entity.Property(e => e.Marca).HasMaxLength(50);
            entity.Property(e => e.Placa).HasMaxLength(10);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
