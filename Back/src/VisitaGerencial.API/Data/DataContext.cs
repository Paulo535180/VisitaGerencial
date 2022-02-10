
using Microsoft.EntityFrameworkCore;
using VisitaGerencial.API.Models;

namespace VisitaGerencial.API.Data;

    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options){}

        public DbSet<Visita> CVG_VISITA {get;set;}
        public DbSet<Area> CVG_AREA {get;set;}
        public DbSet<AreaParticipante> CVG_AREA_PARTICIPANTE {get;set;}
        public DbSet<AcessoSistema> CVG_ACESSO_SISTEMA {get;set;}
        public DbSet<AnexoApontamento> CVG_ANEXO_APONTAMENTO {get;set;}
    }