using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ZAGS.Model
{

    //Модель таблицы Маридж
    public class Marriage
    {
        public int Id { get; set; }
        public string Fio1 { get; set; }
        public string Fio2 { get; set; }
        public DateTime Registration { get; set; }
    }

    class ApplicationContext : DbContext
    {
        //Само определение модели в таблицу
        public DbSet<Marriage> Marriage { get; set; } //Класс и название таблицы

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=db.db");
        }


    }
}
