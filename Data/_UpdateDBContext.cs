using System;
using System.Collections.Generic;
using AvicennaDispensing.Models;
using Microsoft.EntityFrameworkCore;

namespace AvicennaDispensing.Data;

public partial class _UpdateDBContext : DbContext
{
    public _UpdateDBContext()
    {
    }

    public _UpdateDBContext(DbContextOptions<_UpdateDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MultiBatch> MultiBatches { get; set; }

    public virtual DbSet<MultiBatchBalance> MultiBatchBalances { get; set; }

    public virtual DbSet<MultiBatchBalanceBin> MultiBatchBalanceBins { get; set; }

    public virtual DbSet<MultiBatchBalanceBinLog> MultiBatchBalanceBinLogs { get; set; }

    public virtual DbSet<MultiBatchInventoryBin> MultiBatchInventoryBins { get; set; }

    public virtual DbSet<MultiBatchItemBin> MultiBatchItemBins { get; set; }

    public virtual DbSet<MultiBatchItemMovement> MultiBatchItemMovements { get; set; }

    public virtual DbSet<MultiBatchTemp> MultiBatchTemps { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:AVICENNA_TRIAL");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MultiBatch>(entity =>
        {
            entity.HasKey(e => e.MultiBatchID).HasName("PK__MultiBat__6364E23716C76E51");

            entity.ToTable("MultiBatch");

            entity.Property(e => e.MultiBatchID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Barcode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BatchID)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExpiredDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ItemID)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdatebyID)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdatebyTime).HasColumnType("datetime");
            entity.Property(e => e.NIE_BPOM)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Quantity).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceSequenceNo)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.SRItemUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SequenceNo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StatusByDateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.StatusByUserID)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TransactionNo)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Bin).WithMany(p => p.MultiBatches)
                .HasForeignKey(d => d.BinID)
                .HasConstraintName("FK_MultiBatch_BinID");
        });

        modelBuilder.Entity<MultiBatchBalance>(entity =>
        {
            entity.HasKey(e => new { e.LocationID, e.ItemID, e.NIE_BPOM, e.BatchID, e.ExpiredDate }).HasName("PK__Multibat__40D94C49476AA5AC");

            entity.ToTable("MultiBatchBalance");

            entity.Property(e => e.LocationID)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ItemID)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NIE_BPOM)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BatchID)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExpiredDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Balance).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.Barcode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LastTransactionNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdateByTime).HasColumnType("smalldatetime");
            entity.Property(e => e.LastUpdateByid)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MultiBatchBalanceBin>(entity =>
        {
            entity.HasKey(e => e.MultiBatchBalanceBinID).HasName("PK__MultiBat__17B3F6561B571944");

            entity.ToTable("MultiBatchBalanceBin");

            entity.HasIndex(e => new { e.BinID, e.LocationID, e.ItemID, e.NIE_BPOM, e.BatchID, e.ExpiredDate }, "UQ_Bin_Item_BPOM_Batch_ED").IsUnique();

            entity.Property(e => e.Barcode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BatchID)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExpiredDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ItemID)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.LastUpdateUser)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.LocationID)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NIE_BPOM)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Quantity).HasColumnType("numeric(10, 2)");

            entity.HasOne(d => d.Bin).WithMany(p => p.MultiBatchBalanceBins)
                .HasForeignKey(d => d.BinID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MultiBatchBalanceBin_MultiBatchItemBin");

            entity.HasOne(d => d.MultiBatchBalance).WithMany(p => p.MultiBatchBalanceBins)
                .HasForeignKey(d => new { d.LocationID, d.ItemID, d.NIE_BPOM, d.BatchID, d.ExpiredDate })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MultiBatchBalanceBin_MultiBatchBalance");
        });

        modelBuilder.Entity<MultiBatchBalanceBinLog>(entity =>
        {
            entity.HasKey(e => e.MultiBatchBalanceBinLogID).HasName("PK__MultiBat__5036A50659544BBD");

            entity.ToTable("MultiBatchBalanceBinLog");

            entity.Property(e => e.MultiBatchBalanceBinLogID).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("smalldatetime");
            entity.Property(e => e.QtyIn).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.QtyOut).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.TransactionNo)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.MultiBatchBalanceBin).WithMany(p => p.MultiBatchBalanceBinLogs)
                .HasForeignKey(d => d.MultiBatchBalanceBinID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MultiBatchBalanceBinLog_MultiBatchBalanceBin");
        });

        modelBuilder.Entity<MultiBatchInventoryBin>(entity =>
        {
            entity.HasKey(e => new { e.TransactionNo, e.MultiBatchBalanceBinID });

            entity.ToTable("MultiBatchInventoryBin");

            entity.Property(e => e.TransactionNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FromQty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.LastUpdatebyID)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdatebyTime).HasColumnType("datetime");
            entity.Property(e => e.ToQty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.MultiBatchBalanceBin).WithMany(p => p.MultiBatchInventoryBins)
                .HasForeignKey(d => d.MultiBatchBalanceBinID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MultiBatchInventoryBin_MultiBatchBalanceBinID");
        });

        modelBuilder.Entity<MultiBatchItemBin>(entity =>
        {
            entity.HasKey(e => e.BinID).HasName("PK_MultiBatchItemBin_1");

            entity.ToTable("MultiBatchItemBin");

            entity.HasIndex(e => new { e.BinName, e.LocationID }, "UQ_Bin_Location").IsUnique();

            entity.Property(e => e.BinName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CreatedBy)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CreatedDate).HasColumnType("smalldatetime");
            entity.Property(e => e.LastUpdateDate).HasColumnType("smalldatetime");
            entity.Property(e => e.LastUpdateUser)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.LocationID)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MultiBatchItemMovement>(entity =>
        {
            entity.HasKey(e => e.MultiBatchItemMovementID).HasName("PK__MultiBat__6364E2371F5CB452");

            entity.ToTable("MultiBatchItemMovement");

            entity.Property(e => e.MultiBatchItemMovementID)
                .ValueGeneratedOnAdd()
                .HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ItemID)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdateByDateTime).HasColumnType("datetime");
            entity.Property(e => e.LastUpdateByUserID)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.LocationID)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MovementDate).HasColumnType("datetime");
            entity.Property(e => e.MultiBatchID).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.QuantityIn).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.QuantityOut).HasColumnType("numeric(10, 2)");
            entity.Property(e => e.SequenceNo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.ServiceUnitID)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.TransactionNo)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.MultiBatch).WithMany(p => p.MultiBatchItemMovements)
                .HasForeignKey(d => d.MultiBatchID)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__MultiBatc__Multi__2144FCC4");
        });

        modelBuilder.Entity<MultiBatchTemp>(entity =>
        {
            entity.HasKey(e => e.MBTempID).HasName("PK_MultiBatchTemp_1");

            entity.ToTable("MultiBatchTemp");

            entity.Property(e => e.MBTempID).ValueGeneratedNever();
            entity.Property(e => e.Barcode)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BatchID)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExpiredDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ItemID)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdateByUserID)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdateDateTime).HasColumnType("datetime");
            entity.Property(e => e.LocationID)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.NIE_BPOM)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Quantity).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ReferenceNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ReferenceSequenceNo)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.SRItemUnit)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SequenceNo)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StatusByDateTime).HasColumnType("smalldatetime");
            entity.Property(e => e.StatusByUserID)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.TransactionNo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
