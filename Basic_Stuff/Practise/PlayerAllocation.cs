using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    class Player
    {
        public string playerName { get; set; }
        public int Score { get; set; }
        public Player(string Name, int score)
        {
            playerName = Name;
            Score = score;
        }
    }

    class PlayerAllocation : IPractise
    {
        public void Test()
        {
            List<Player> _players = new List<Player>();
            _players.Add(new Player("player0", 55));
            _players.Add(new Player("player1", 60));
            _players.Add(new Player("player2", 45));
            _players.Add(new Player("player3", 50));
            _players.Add(new Player("player4", 40));
            //_players.Add(new Player("player5", 25));

            dividePlayer(_players.ToArray());
        }


        private static void dividePlayer(Player[] players)
        {
            int minScore = 0;
            Player[] _players = players;
            if (_players.Count() % 2 == 1)
            {
                minScore = _players.Min(x => x.Score);
                _players = _players.Where(x => x.Score != minScore).OrderBy(x => x.Score).ToArray();
            }
            else
                _players = _players.OrderBy(x => x.Score).ToArray();

            _players = _players.Reverse().ToArray();

            List<Player> Team1 = new List<Player>();
            List<Player> Team2 = new List<Player>();

            int len = _players.Count() - 1;
            int maxTeam = (len + 1) / 2;

            for (int i = 0; i <= len / 2; i++)
            {
                int teamLen = Team2.Count();
                if (maxTeam == teamLen)
                    break;
                if (maxTeam - teamLen == 1)
                {
                    Team2.Add(_players[maxTeam]);
                    Team1.Add(_players[maxTeam - 1]);
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        Team1.Add(_players[i]);
                        Team1.Add(_players[len - i]);
                    }
                    else
                    {
                        Team2.Add(_players[i]);
                        Team2.Add(_players[len - i]);
                    }
                }
            }

            Console.WriteLine("Team 1");
            foreach (Player p in Team1)
            {
                Console.WriteLine("Name :" + p.playerName + "\t Score:" + p.Score);
            }

            Console.WriteLine("Team 2");
            foreach (Player p in Team2)
            {
                Console.WriteLine("Name :" + p.playerName + "\t Score:" + p.Score);
            }

            int DiffScore = Team1.Sum(x => x.Score) - Team2.Sum(x => x.Score);
            if (DiffScore >= 0)
            {
                Team2.Add(players.Where(x => x.Score == minScore).FirstOrDefault());
            }
            else
            {
                Team1.Add(players.Where(x => x.Score == minScore).FirstOrDefault());
            }

            DiffScore = Team1.Sum(x => x.Score) - Team2.Sum(x => x.Score);
            DiffScore = DiffScore >= 0 ? DiffScore : DiffScore * -1;

            Console.WriteLine(DiffScore);



        }


    }

}
