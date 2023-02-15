using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ApplicationDesignWebApp.Services
{
    public class CharacterServices
    {
        private PROG455SP23Entities db = new PROG455SP23Entities();


        public List<Character> GetCharacters()
        {
            return db.Characters.ToList();
        }

        public bool GetCharacterByID(int? id, out Character character)
        {
            if (id == null)
            {
                character = null;
                return false;
            }

            character = db.Characters.Find(id);

            if (character == null)
            {
                return false;
            }
            
            return true;
        }

        public void SaveCharacterChanges(Character character)
        {
            db.Entry(character).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void AddCharacter(Character character)
        {
            db.Characters.Add(character);
            db.SaveChanges();
        }

        public void DeleteCharacterByID(int id)
        {
            if (GetCharacterByID(id, out Character character))
            {
                db.Characters.Remove(character);
                db.SaveChanges();
            }
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
        }
    }
}