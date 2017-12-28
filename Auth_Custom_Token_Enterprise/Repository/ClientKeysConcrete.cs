using System.Data.Entity;
using System.Linq;
using Auth_Custom_Token_Enterprise.DBContext;
using Auth_Custom_Token_Enterprise.Models;
using Auth_Custom_Token_Enterprise.AES256Encryption;

namespace Auth_Custom_Token_Enterprise.Repository
{
    public class ClientKeysConcrete : IClientKeys
    {
        DatabaseContext _context;
        public ClientKeysConcrete()
        {
            _context = new DatabaseContext();
        }

        public void GenerateUniqueKey(out string ClientID, out string ClientSecert)
        {
            ClientID = EncryptionLibrary.KeyGenerator.GetUniqueKey();
            ClientSecert = EncryptionLibrary.KeyGenerator.GetUniqueKey();
        }

        public bool IsUniqueKeyAlreadyGenerate(int UserID)
        {
            bool keyExists = _context.ClientKey.Any(clientkeys => clientkeys.UserID.Equals(UserID));

            if (keyExists)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public int SaveClientIDandClientSecert(ClientKey ClientKeys)
        {
            _context.ClientKey.Add(ClientKeys);
            return _context.SaveChanges();
        }

        public ClientKey GetGenerateUniqueKeyByUserID(int UserID)
        {
            var clientkey = (from ckey in _context.ClientKey
                            where ckey.UserID  == UserID
                            select ckey).FirstOrDefault();
            return clientkey;
        }


        public int UpdateClientIDandClientSecert(ClientKey ClientKeys)
        {
            _context.Entry(ClientKeys).State = EntityState.Modified;
            _context.SaveChanges();
            return _context.SaveChanges();
        }

    }
}