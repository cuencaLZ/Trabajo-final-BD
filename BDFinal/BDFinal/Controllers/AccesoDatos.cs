using BDFinal.Models;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Web;

namespace BDFinal.Controllers
{
	public class AccesoDatos
	{
        public class TraductorDataAccess
        {
            string connectionString = ("Server=127.0.0.1;Database=animes;Uid=root;Pwd=SQL852147852");
       

            public IEnumerable<Animes> GetAllTraductores()
            {
                try
                {
                    List<Animes> animesList = new List<Animes>();
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        string sqlQuery = "SELECT * FROM animes";
                        MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                        con.Open();
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            Animes anime = new Animes();
                            anime.titulo = rdr["titulo"].ToString();
                            anime.valoración = rdr["valoracion"].ToString();
                            anime.ranking = rdr["ranking"].ToString();
                            anime.generos = rdr["generos"].ToString();
                            anime.url = rdr["url"].ToString();
                            anime.image = rdr["image"].ToString();
                            anime.descripcion = rdr["descripcion"].ToString();
                            anime.edad = rdr["edad"].ToString();
                            animesList.Add(anime);
                        }
                        con.Close();
                    }
                    return animesList;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public IEnumerable<Animes> GetAmorTraductor()
            {
                try
                {
                    List<Animes> animesList = new List<Animes>();
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        string sqlQuery = "SELECT * FROM animes where generos LIKE '%Romance%'";
                        MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                        con.Open();
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            Animes anime = new Animes();
                            anime.titulo = rdr["titulo"].ToString();
                            anime.valoración = rdr["valoracion"].ToString();
                            anime.ranking = rdr["ranking"].ToString();
                            anime.generos = rdr["generos"].ToString();
                            anime.url = rdr["url"].ToString();
                            anime.image = rdr["image"].ToString();
                            anime.descripcion = rdr["descripcion"].ToString();
                            anime.edad = rdr["edad"].ToString();
                            animesList.Add(anime);
                        }
                        con.Close();
                    }
                    return animesList;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public IEnumerable<Animes> GetActionTraductor()
            {
                try
                {
                    List<Animes> animesList = new List<Animes>();
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        string sqlQuery = "SELECT * FROM animes where generos LIKE '%Action%'";
                        MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                        con.Open();
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            Animes anime = new Animes();
                            anime.titulo = rdr["titulo"].ToString();
                            anime.valoración = rdr["valoracion"].ToString();
                            anime.ranking = rdr["ranking"].ToString();
                            anime.generos = rdr["generos"].ToString();
                            anime.url = rdr["url"].ToString();
                            anime.image = rdr["image"].ToString();
                            anime.descripcion = rdr["descripcion"].ToString();
                            anime.edad = rdr["edad"].ToString();
                            animesList.Add(anime);
                        }
                        con.Close();
                    }
                    return animesList;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public IEnumerable<Animes> GetDramaTraductor()
            {
                try
                {
                    List<Animes> animesList = new List<Animes>();
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        string sqlQuery = "SELECT * FROM animes where generos LIKE '%Drama%'";
                        MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                        con.Open();
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            Animes anime = new Animes();
                            anime.titulo = rdr["titulo"].ToString();
                            anime.valoración = rdr["valoracion"].ToString();
                            anime.ranking = rdr["ranking"].ToString();
                            anime.generos = rdr["generos"].ToString();
                            anime.url = rdr["url"].ToString();
                            anime.image = rdr["image"].ToString();
                            anime.descripcion = rdr["descripcion"].ToString();
                            anime.edad = rdr["edad"].ToString();
                            animesList.Add(anime);
                        }
                        con.Close();
                    }
                    return animesList;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            public IEnumerable<Animes> GetBuscadorTraductor(String generos)
            {
                try
                {
                    List<Animes> animesList = new List<Animes>();
                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        string sqlQuery = "SELECT * FROM animes where generos LIKE '%"+generos+"%'";
                        MySqlCommand cmd = new MySqlCommand(sqlQuery, con);
                        con.Open();
                        MySqlDataReader rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            Animes anime = new Animes();
                            anime.titulo = rdr["titulo"].ToString();
                            anime.valoración = rdr["valoracion"].ToString();
                            anime.ranking = rdr["ranking"].ToString();
                            anime.generos = rdr["generos"].ToString();
                            anime.url = rdr["url"].ToString();
                            anime.image = rdr["image"].ToString();
                            anime.descripcion = rdr["descripcion"].ToString();
                            anime.edad = rdr["edad"].ToString();
                            animesList.Add(anime);
                        }
                        con.Close();
                    }
                    return animesList;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }


        }
    }
}