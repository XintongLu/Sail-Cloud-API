using System;
using System.Linq;

using Microsoft.Extensions.DependencyInjection;
using WebAPI.Models;

namespace WebAPI.Data
{
    public static class DbInitializer
    {
        public static void Initialize(APIContext context)
        {
            context.Database.EnsureCreated();
            // Look for any students.
            if (context.Utilisateur.Any())
            {
                return;   // DB has been seeded
            }

            var utilisateurs = new Utilisateur[]
            {
                new Utilisateur { UtilisateurId= new Guid("86128a5d-cae7-485b-9dd9-c2b8510a8d97"), Nom = "BAH",   Prénom = "Thierno",
                    Age = 21 },
                new Utilisateur { UtilisateurId= new Guid("ddeccfb3-bc32-42d0-9527-4316e17efa74"),Nom = "Xintong",   Prénom = "Lu",
                    Age = 99 },
           
            };

            foreach (Utilisateur s in utilisateurs)
            {
                context.Utilisateur.Add(s);
            }
            context.SaveChanges();

            var bateaux = new Bateau[]
           {
                new Bateau { Nom = "Arche de Noé",   Largeur = 555, Longueur=288, Poids=885,
                    AnnéeFabrication =1799, UtilisateurId=new Guid("86128a5d-cae7-485b-9dd9-c2b8510a8d97")},
                new Bateau { Nom = "Fly",   Largeur = 455, Longueur=298, Poids=825,
                    AnnéeFabrication =2010, UtilisateurId=new Guid("86128a5d-cae7-485b-9dd9-c2b8510a8d97")},
                new Bateau { Nom = "Titanic",   Largeur = 1155, Longueur=278, Poids=1185,
                    AnnéeFabrication =1899, UtilisateurId=new Guid("ddeccfb3-bc32-42d0-9527-4316e17efa74")},
                 new Bateau { Nom = "Fly2",   Largeur = 115, Longueur=478, Poids=185,
                    AnnéeFabrication =2015, UtilisateurId=new Guid("ddeccfb3-bc32-42d0-9527-4316e17efa74")},
                new Bateau { Nom = "BAC",   Largeur = 855, Longueur=248, Poids=185,
                    AnnéeFabrication =1909, UtilisateurId=new Guid("86128a5d-cae7-485b-9dd9-c2b8510a8d97")},

           };

            foreach (Bateau s in bateaux)
            {
                context.Bateau.Add(s);
            }
            context.SaveChanges();

        }
    }

  }
