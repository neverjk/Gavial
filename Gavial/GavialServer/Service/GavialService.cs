
using GavialServer.Entity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GavialServer
{
    public class GavialService : IPlay, IProfile
    {
        public List<Game> games;
        public List<ICallBack> allClients = new List<ICallBack>();
        public List<User> activeUsers = new List<User>();
        public List<User> allUsers = new List<User>();
        public const int usersCountPerGame= 5;
        public GavialContext gavialContext = new GavialContext();

        public GavialService()
        {
            games = new List<Game>();
        }

        public void JoinGame(string name, int gameId=-1)
        {
            if (gameId == -1)
            {
                foreach(var i in games)
                {
                    if (i.users.Count < usersCountPerGame)
                    {
                        int clientId = allUsers.IndexOf(allUsers.Find(x => x.Name == name));
                        i.users.Add(allUsers.Find(x => x.Name == name));
                        i.clients.Add(allClients[clientId]);
                        return;
                    }
                }
            }
            else if (games.Count>=gameId)
            {
                if (games[gameId].users.Count< usersCountPerGame)
                {
                    int clientId = allUsers.IndexOf(allUsers.Find(x => x.Name == name));
                    games[gameId].users.Add(allUsers.Find(x => x.Name == name));
                    games[gameId].clients.Add(allClients[clientId]);
                    return;
                }
            }
            else
            {
                games.Add(new Game());
                int clientId = allUsers.IndexOf(allUsers.Find(x => x.Name == name));
                games[games.Count-1].users.Add(allUsers.Find(x => x.Name == name));
                games[games.Count - 1].clients.Add(allClients[clientId]);
            }
        }
        public void SendMessage(MessageDto message)
        {
            throw new NotImplementedException();
        }
        public void Draw(Bitmap image, string name)
        {
            foreach (var i in games)
            {
                if (i.users.Find(x => x.Name == name) != null)
                {
                    i.drawing = image;
                    break;
                }
            }
        }
        public void LeaveGame(string name)
        {
            foreach(var i in games)
            {
                if (i.users.Find(x => x.Name == name) != null)
                {
                    int clientId = i.users.IndexOf(i.users.Find(x => x.Name == name));
                    i.clients.RemoveAt(clientId);
                    i.users.Remove(i.users.Find(x => x.Name == name));
                }
            }
        }

        public void LogIn(string name)
        {
            
        }
        public void LogOut(string name)
        {
            allUsers.Find(x => x.Name == name).Channel = null;
            activeUsers.Remove(allUsers.Find(x => x.Name == name));
        }
        public void Register(string name)
        {
            
        }

        public ProfileDto GetProfileInfo(string name)
        {
            ProfileDto res = new ProfileDto();
            foreach (var i in activeUsers)
            {
                if (i.Name == name)
                {
                    //return new ProfileDto() { BadWords= }
                }
            }
            return res;
        }
        public void SetProfileInfo(ProfileDto newProfileInfo)
        {
            throw new NotImplementedException();
        }

    }
}
