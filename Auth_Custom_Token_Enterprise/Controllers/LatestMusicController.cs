using Auth_Custom_Token_Enterprise.DBContext;
using Auth_Custom_Token_Enterprise.Filters;
using Auth_Custom_Token_Enterprise.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Auth_Custom_Token_Enterprise.Controllers
{
    [APIAuthorizeAttribute]
    public class LatestMusicController : ApiController
    {
        private DatabaseContext db = new DatabaseContext();

        // GET: api/LatestMusic
        public List<MusicStore> GetMusicStore()
        {
            try
            {
                var listofSongs = db.MusicStore.ToList();
                return listofSongs;
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

      
    }
}