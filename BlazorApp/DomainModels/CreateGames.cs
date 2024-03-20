using DomainModels;
using System;
using Npgsql;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace DomainModels
{
    public class GameDataService
    {

        public void InsertDummyDataIntoDB(List<PC_Game> AllPCGames, List<PS_Game> AllPSGames, List<XBOX_Game> AllXBOXGames)
        {
            string connectionString = "Host=ep-bitter-salad-a2i17tas.eu-central-1.aws.neon.tech;Database=GamersLounge;Username=GamersLounge_owner;Password=XJYz1P7LupEn";

            using var connection = new NpgsqlConnection(connectionString);
            connection.Open();
            using (var cmd = new NpgsqlCommand())
            {
                cmd.Connection = connection;
                foreach (var game in AllPCGames)
                {
                    if (game is PC_Game pc_game)
                    {
                        string createdDate = pc_game.created != DateTime.MinValue ? DateTimeToString(pc_game.created) : "NULL";
                        string updatedDate = pc_game.updated != DateTime.MinValue ? DateTimeToString(pc_game.updated) : "NULL";

                        //string insertCommand = $@"INSERT INTO Item(itemID, gameName, price, orderStatus, condition, created, updated, genre, manufacture, addToFaverite, description, operatingSystem, yearDeployed)
                        //                                  VALUES('{Item.itemID}', '{Item.gameName}', '{Item.price}', '{Item.orderStatus}', '{Item.condition}', '{Item.created}','{Item.updated}','{Item.genre}','{Item.manufacture}','{Item.addToFaverite}','{Item.description}', '{Item.operatingSystem}', '{Item.yearDeployed}')";
                        string insertCommand = $@"INSERT INTO pc_games(addtofavorite, condition, created, gamename, genre, itemid, manufacture, price, updated, userid, orderstatus, description)
                                                          VALUES('{pc_game.addToFaverite}', '{pc_game.condition}', {createdDate}, '{pc_game.gameName}', '{pc_game.genre}', '{pc_game.itemID}', '{pc_game.manufacture}','{pc_game.price}',{updatedDate},'{pc_game.itemID}','{pc_game.orderStatus}','{pc_game.description}')";

                        cmd.CommandText = insertCommand;
                        cmd.ExecuteNonQuery();
                    }
                }
                foreach (var game in AllPSGames)
                {
                    if (game is PS_Game ps_Game)
                    {
                        string createdDate = ps_Game.created != DateTime.MinValue ? DateTimeToString(ps_Game.created) : "NULL";
                        string updatedDate = ps_Game.updated != DateTime.MinValue ? DateTimeToString(ps_Game.updated) : "NULL";

                        string insertCommand = $@"INSERT INTO ps_games(addtofavorite, condition, created, gamename, genre, itemid, manufacture, price, updated, userid, orderstatus, description)
                                                          VALUES('{ps_Game.addToFaverite}', '{ps_Game.condition}', {createdDate}, '{ps_Game.gameName}', '{ps_Game.genre}', '{ps_Game.itemID}','{ps_Game.manufacture}','{ps_Game.price}',{updatedDate},'{ps_Game.itemID}','{ps_Game.orderStatus}','{ps_Game.description}')";

                        cmd.CommandText = insertCommand;
                        cmd.ExecuteNonQuery();
                    }
                }
                foreach (var game in AllXBOXGames)
                {
                    if (game is XBOX_Game xbox_Game)
                    {
                        string createdDate = xbox_Game.created != DateTime.MinValue ? DateTimeToString(xbox_Game.created) : "NULL";
                        string updatedDate = xbox_Game.updated != DateTime.MinValue ? DateTimeToString(xbox_Game.updated) : "NULL";

                        string insertCommand = $@"INSERT INTO xbox_games(addtofavorite, condition, created, gamename, genre, itemid, manufacture, price, updated, userid, orderstatus, description)
                                                          VALUES('{xbox_Game.addToFaverite}', '{xbox_Game.condition}', {createdDate}, '{xbox_Game.gameName}', '{xbox_Game.genre}', '{xbox_Game.itemID}', '{xbox_Game.manufacture}','{xbox_Game.price}',{updatedDate},'{xbox_Game.itemID}','{xbox_Game.orderStatus}','{xbox_Game.description}')";

                        cmd.CommandText = insertCommand;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
        private string DateTimeToString(DateTime dateTime)
        {
            return $"'{dateTime.ToString("yyyy-MM-dd HH:mm:ss")}'";
        }
    }
}
