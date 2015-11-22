using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdQuestion
{
    public interface ILikeCookie
    {
        /// <summary>         
        /// GETS a cookie by type        
        /// </summary>        
        /// <typeparam name="T"></typeparam>         
        /// <returns></returns>         
        T MeWantCookie<T>() where T : ICookie, new();

        /// <summary>         
        /// GETS a cookie by name         
        /// </summary> 
        /// <param name="cookieName"></param>         
        /// <returns></returns>         
        HttpCookie MeWantCookie(string cookieName);
        /// <summary>         
        /// SETS a cookie         
        /// </summary>         
        /// <param name="cookie"></param>         
        void MeBakeCookie(ICookie cookie);

        /// <summary>         
        /// DELETES a cookie         
        /// </summary>         
        /// <param name="cookieName">The name of the cookie to delete</param>         
        void NomNomNom(string cookieName);

        /// <summary>         
        /// DELETES a cookie         
        /// </summary>         
        /// <typeparam name="T">The ICookie to delete, which defines the cookie name</typeparam>         
        void NomNomNom<T>() where T : ICookie, new();
    }

    public class HttpCookie
    {
    }

    public interface ICookie
    {
    }
}
