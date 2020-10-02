using System;
using System.Collections.Generic;
using System.Text;
using Tp4.Models;

namespace Tp4.Services
{
    public class TwitterService : ITweeterService
    {
        public bool Authenticate(string utilisateur, string motDePasse)
        {
            if ( utilisateur.Equals("coco") && motDePasse.Equals("azerty") )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Tweet> GetTweets(string chaineDeCaractere)
        {
            List<Tweet> maListeDeTweet = new List<Tweet>();

            Tweet tweet1 = new Tweet("658bdy987", "30/09/2020", "Ceci est mon dernier tweet de septembre 2020", "Layboules", "jolb123", "Joey");
            Tweet tweet2 = new Tweet("658bha287", "01/10/3020", "Ceci est un tweet du tur-fu !", "McFly", "bftf", "Marty");
            Tweet tweet3 = new Tweet("124ajf987", "11/09/2020", "Bonne fête de l'aviation", "Laden", "Oussama", "Ben");
            Tweet tweet4 = new Tweet("666yyy666", "25/12/666", "Ceci est mon dernier tweet de septembre 2020", "Mhabite", "hell666", "Satan");

            maListeDeTweet.Add(tweet1);
            maListeDeTweet.Add(tweet2);
            maListeDeTweet.Add(tweet3);
            maListeDeTweet.Add(tweet4);

            return maListeDeTweet;
        }
    }
}
