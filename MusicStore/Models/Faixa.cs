using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Faixa
    {
        [Key]
        public int _faixaID { get; set; }

        [Required]
        private string _dsFaixa;

        private string _nmFeat;

        [Association("Album","_faixaID","_albumID")]
        public Album _albumID { get; set; }

        [Required]
        public string TituloFaixa
        {
            get
            {
                return _dsFaixa;
            }
            set
            {
                _dsFaixa = value;
            }
        }

        public string NomeFeat
        {
            get
            {
                return _nmFeat;
            }
            set
            {
                _nmFeat = value;
            }
        }
       
    }
    public class DbFaixa : DbContext
    {
        public DbSet<Faixa> Faixas { get; set; }
    }
}