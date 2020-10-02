using System;
using System.Collections.Generic;
using System.Text;
using Tp4.Models;

namespace Tp4.Services
{
    public interface ITweeterService
    {
        Boolean Authenticate(string utilisateur, string motDePasse);

        List<Tweet> GetTweets(string chaineDeCaractere);
    }
}
