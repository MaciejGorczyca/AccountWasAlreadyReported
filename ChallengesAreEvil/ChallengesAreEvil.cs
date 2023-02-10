using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChallengesAreEvil
{
    public partial class ChallengesAreEvilForm : Form
    {

        LeagueConnection lc;
        
        public ChallengesAreEvilForm()
        {
            InitializeComponent();
        }

        private void ChallengesAreEvilForm_Load(object sender, EventArgs e)
        {
            lc = new LeagueConnection();
        }

        private void editMessageLabel(String msg)
        {
            messageLabel.Text = msg;
        }

        private Boolean checkIfLeagueIsConnected()
        {
            if (!lc.IsConnected)
            {
                editMessageLabel("Not connected to League Client! You need to log in first and wait few seconds. If you run LoL as admin, run this app as admin too!");
                return false;
            }
            return true;
        }

        private async void removeTokensButton_Click(object sender, EventArgs e)
        {
            if (checkIfLeagueIsConnected())
            {
                String nick = nickTextBox.Text;
                JsonArray summonerArray = (JsonArray) await lc.Post("/lol-summoner/v2/summoners/names", "[\"" + nick + "\"]");
                if (summonerArray.Count == 0)
                {
                    appendText("Not found: " + nick);
                    return;
                }
                JsonObject summoner = (JsonObject)summonerArray[0];
                appendText(summoner.ToString());
                
                long summonerId = (long)summoner["summonerId"];
                appendText("Summoner ID: " + summonerId);
                
                Random random = new Random();
                
                for (int i = 0; i < 10; i++)
                {
                    long gameId = random.Next();
                    String body = "{\"gameId\":" + gameId + ",\"offenses\":\"NEGATIVE_ATTITUDE,VERBAL_ABUSE,LEAVING_AFK\",\"reportedSummonerId\":" + summonerId + "}";
                    appendText(body);
                    JsonObject reportResponse = (JsonObject) await lc.Post("/lol-end-of-game/v2/player-complaints", body);
                    appendText(reportResponse.ToString());
                }

            }
        }

        private void appendText(String text)
        {
            printTextBox.AppendText(text + "\r\n");
        }

        private void clearPrintButton_Click(object sender, EventArgs e)
        {
            printTextBox.Clear();
        }
    }
}