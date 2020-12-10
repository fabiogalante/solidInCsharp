using Microsoft.EntityFrameworkCore;

using System;
using System.Linq;
using System.Security.Cryptography;

using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using solidInCsharp.Model;
using solidInCsharp.Repository;


namespace solidInCsharp.Service
{
    public interface ICriptografiaService
    {

		public bool ValidarSenha(string senhaCripto, string senhaDigitada);

		public string CriptografarSenha(string senha);

    }
}