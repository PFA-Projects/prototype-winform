﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using CompetencePlus.Outils;
 


namespace CompetencePlus.PackageFilieres
{
    public class FiliereDAO : IGestion<Filiere>
    {
        public  void Add(Filiere f)
        {
            string Requete = "Insert into Filieres(Titre,Code,Description) values ('" + f.Titre + "','" + f.Code +"','"+f.Description+ "')";
            MyConnection.ExecuteNonQuery(Requete);
        }

        public  void Update(Filiere f )
        {
            string Requete = "Update Filieres set Code ='"+f.Code+"',Titre ='"+f.Titre+",Description="+f.Description+"' where id ="+f.Id;
            MyConnection.ExecuteNonQuery(Requete);
        }

        public  void Delete(int id)
        {
            string Requete = "Delete From Filieres where id="+id;
            MyConnection.ExecuteNonQuery(Requete);
        }

        public  List<Filiere> Select()
        {
            string Requete = "Select * from Filieres";
            List<Filiere> ListFiliere = new List<Filiere>();
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            while (read.Read())
            {
                Filiere f = new Filiere();
                f.Id = read.GetInt32(0);
                f.Titre = read.GetString(1);
                f.Code = read.GetString(2);
                f.Description = read.GetString(3);
                ListFiliere.Add(f);
                
            }
            MyConnection.Close();
            return ListFiliere;
            
        }

        public Filiere FindById(int id)
        {
            string Requete = "Select * from Filieres where id="+id;
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            read.Read();
            Filiere f = new Filiere();
            f.Id = read.GetInt32(0);
            f.Code = read.GetString(1);
            f.Titre = read.GetString(2);
            return f;
        }
        public Filiere FindByName(string Name)
        {
            string Requete = "Select * from Filieres where Nom=" + Name;
            OleDbDataReader read = MyConnection.ExecuteReader(Requete);
            Filiere f = new Filiere();
            f.Id = read.GetInt32(0);
            f.Code = read.GetString(1);
            f.Titre = read.GetString(2);
            return f;
        }


        
    }
}
