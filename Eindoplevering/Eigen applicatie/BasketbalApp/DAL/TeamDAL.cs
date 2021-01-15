using Logic.Interface.Dto_s;
using Logic.Interface.DTOs;
using Logic.Interface.interfaces;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DAL
{
    public class TeamDAL : ITeamDal
    {
        private static string GetConnectionString()
        {
            var builder = new
            ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json",
            optional: true, reloadOnChange: true);

            return builder.Build().GetSection("ConnectionStrings").GetSection("BasketbalDb").Value;
        }

        public List<TeamDto> GetData()
        {
            List<TeamDto> data = new List<TeamDto>();
            string query = "SELECT * FROM team";
            using MySqlConnection mySqlConnection = new MySqlConnection(GetConnectionString());
            try
            {
                using var cmd = new MySqlCommand(query, mySqlConnection);
                mySqlConnection.Open();
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        data.Add(new TeamDto
                        {
                            IdTeam = Convert.ToInt32(reader["idTeam"].ToString()),
                            Name = Convert.ToString(reader["Name"].ToString()),
                            Owner = Convert.ToString(reader["Owner"].ToString())
                        });
                    }
                }
            }
            catch (MySqlException e)
            {
                throw e;
            }
            finally
            {
                mySqlConnection.Close();
            }
            return data;
        }

        public List<PlayerDto> GetById(int id)
        {
            List<PlayerDto> data = new List<PlayerDto>();
            string query = "select speler.LastName, speler.FirstName from speler_team INNER JOIN speler ON speler.idPlayer = speler_team.idPlayer INNER JOIN team ON team.idTeam = speler_team.idTeam where speler_team.idTeam= @idteam";
            using MySqlConnection mySqlConnection = new MySqlConnection(GetConnectionString());
            try
            {
                using var cmd = new MySqlCommand(query, mySqlConnection);
                cmd.Parameters.Add("@idteam", MySqlDbType.Int32);
                cmd.Parameters["@idteam"].Value = id;
                mySqlConnection.Open();
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new PlayerDto
                    {
                        LastName = Convert.ToString(reader["LastName"].ToString()),
                        FirstName = Convert.ToString(reader["FirstName"].ToString())
                    });
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                mySqlConnection.Close();
            }
            return data;
        }

        public void Create(TeamDto teamDto)
        {
            string Insertdata = "Insert into team Values(NULL, @name, @owner)";
            using MySqlConnection mySqlConnection = new MySqlConnection(GetConnectionString());
            try
            {
                using MySqlCommand cmd = new MySqlCommand(Insertdata, mySqlConnection);
                cmd.Parameters.AddWithValue("@name", teamDto.Name);
                cmd.Parameters.AddWithValue("@owner", teamDto.Owner);
                mySqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        public TeamDto GetTeamById(int id)
        {
            TeamDto team = new TeamDto();
            string query = "select * from team where idTeam = @idteam";
            using MySqlConnection mySqlConnection = new MySqlConnection(GetConnectionString());
            try
            {
                using var cmd = new MySqlCommand(query, mySqlConnection);
                cmd.Parameters.Add("@idteam", MySqlDbType.Int32);
                cmd.Parameters["@idteam"].Value = id;
                mySqlConnection.Open();
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    {
                        team.IdTeam = Convert.ToInt32(reader["idTeam"].ToString());
                        team.Name = Convert.ToString(reader["Name"].ToString());
                        team.Owner = Convert.ToString(reader["Owner"].ToString());
                    }
                }
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                mySqlConnection.Close();
            }
            return team;
        }

        public void Delete(int id)
        {
            string query = "Delete From team where idTeam = @idteam";
            using MySqlConnection mySqlConnection = new MySqlConnection(GetConnectionString());
            try
            {
                using MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);
                cmd.Parameters.Add("@idteam", MySqlDbType.Int32);
                cmd.Parameters["@idteam"].Value = id;
                mySqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        public void Edit(TeamDto teamDto)
        {
            string Updatequery = "Update team set Name = @name where idTeam = @idteam";
            using MySqlConnection mySqlConnection = new MySqlConnection(GetConnectionString());
            try
            {
                using MySqlCommand cmd = new MySqlCommand(Updatequery, mySqlConnection);
                cmd.Parameters.AddWithValue("@name", teamDto.Name);
                cmd.Parameters.Add("@idteam", MySqlDbType.Int32);
                cmd.Parameters["@idteam"].Value = teamDto.IdTeam;
                mySqlConnection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                mySqlConnection.Close();
            }
        }
    }
}
