﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FIL_ROUGEEntities : DbContext
    {
        public FIL_ROUGEEntities()
            : base("name=FIL_ROUGEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Commande> Commande { get; set; }
        public virtual DbSet<Commercial> Commercial { get; set; }
        public virtual DbSet<Comprend> Comprend { get; set; }
        public virtual DbSet<Contient> Contient { get; set; }
        public virtual DbSet<Livraison> Livraison { get; set; }
        public virtual DbSet<Delivre> Delivre { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<Fournisseur> Fournisseur { get; set; }
        public virtual DbSet<Sous_Rubrique> Sous_Rubrique { get; set; }
        public virtual DbSet<Vend> Vend { get; set; }
    }
}
