using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Album
    {
        private string _dsAlbum;
        private string _nmArtista;
        private int _nrFaixas;
        private DateTime _dtLancamento;
        private Faixa[] _faixas;

        [Key]
        public Int32 ID { get; set; }

        [Required]
        public string TituloAlbum
        {
            get
            {
                return _dsAlbum;
            }
            set
            {
                _dsAlbum = value;
            }
        }

        [Required]
        public string NomeArtista
        {
            get
            {
                return _nmArtista;
            }
            set
            {
                _nmArtista = value;
            }
        }

        [Required]
        public int NumeroFaixas
        {
            get
            {
                return _nrFaixas;
            }
            set
            {
                _nrFaixas = value;
            }
        }

        [Required]
        public DateTime DataLancamento
        {
            get
            {
                return _dtLancamento;
            }
            set
            {
                _dtLancamento = value;
            }
        }

        [Required]
        public Faixa[] Faixas
        {
            get
            {
                return _faixas;
            }
            set
            {
                _faixas = value;
            }
        }

        public Album() { }

        public Album(string dsAlbum, string nmArtista, int nrFaixas, DateTime dtLancamento,
            Faixa[] faixas)
        {
            this._dsAlbum = dsAlbum;
            this._nmArtista = nmArtista;
            this._nrFaixas = nrFaixas;
            this._dtLancamento = dtLancamento;
            this._faixas = faixas;
        }

        public String getAlbum()
        {

            return "Álbum: " + TituloAlbum +
                   "Artista: " + NomeArtista +
                   "Número de Faixas: " + NumeroFaixas +
                   "Data de lançamento: " + DataLancamento;
        }
                   
        }
         public class DbAlbum : DbContext
            {
                 public DbSet<Album> Albuns { get; set; }
           }

}
