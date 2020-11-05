using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Renci.SshNet.Security.Cryptography;
using SshNet.Security.Cryptography;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace WebCadastroCoder.Models
{
    [Table("Usuario")]
    public class Usuario
    {
       
        //=============================
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Name { get; set; }

        [Display(Name = "Celular")]
        [Column("Celular")]
        public string Celular { get; set; }

        [Display(Name = "E-mail")]
        [Column("Email")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        
        [Display(Name = "Senha")]
        [Column("Senha")]

        public string Senha { get; }
        //public string Senha { set; }
       
  
    }
}
