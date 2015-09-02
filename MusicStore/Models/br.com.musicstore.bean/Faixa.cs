using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Faixa
    {

        public Album albumID { get; set; }
        private string _dsFaixa;
        private string _nmFeat;
        private Album cadA = new Album();


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
}